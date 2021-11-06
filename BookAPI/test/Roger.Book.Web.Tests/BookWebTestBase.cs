using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Abp.AspNetCore.TestBase;
using Roger.Book.EntityFrameworkCore;
using Roger.Book.Tests.TestDatas;
using Roger.Book.Web.Controllers;
using Roger.Book.Web.Startup;
using Roger.Book.Web.Tests.Controllers;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Shouldly;

namespace Roger.Book.Web.Tests
{
    public abstract class BookWebTestBase : AbpAspNetCoreIntegratedTestBase<Startup>
    {
        protected static readonly Lazy<string> ContentRootFolder;

        static BookWebTestBase()
        {
            ContentRootFolder = new Lazy<string>(WebContentDirectoryFinder.CalculateContentRootFolder, true);
        }

        protected BookWebTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            return base
                .CreateWebHostBuilder()
                .UseContentRoot(ContentRootFolder.Value)
                .UseSetting(WebHostDefaults.ApplicationKey, typeof(BookWebModule).Assembly.FullName);
        }

        #region Get response

        protected async Task<T> GetResponseAsObjectAsync<T>(string url,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            var strResponse = await GetResponseAsStringAsync(url, expectedStatusCode);
            return JsonConvert.DeserializeObject<T>(strResponse, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        protected async Task<string> GetResponseAsStringAsync(string url,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            var response = await GetResponseAsync(url, expectedStatusCode);
            return await response.Content.ReadAsStringAsync();
        }

        protected async Task<HttpResponseMessage> GetResponseAsync(string url,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            var response = await Client.GetAsync(url);
            response.StatusCode.ShouldBe(expectedStatusCode);
            return response;
        }

        #endregion

        #region UsingDbContext

        protected void UsingDbContext(Action<BookDbContext> action)
        {
            using (var context = IocManager.Resolve<BookDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected T UsingDbContext<T>(Func<BookDbContext, T> func)
        {
            T result;

            using (var context = IocManager.Resolve<BookDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected async Task UsingDbContextAsync(Func<BookDbContext, Task> action)
        {
            using (var context = IocManager.Resolve<BookDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected async Task<T> UsingDbContextAsync<T>(Func<BookDbContext, Task<T>> func)
        {
            T result;

            using (var context = IocManager.Resolve<BookDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }

        #endregion

        #region ParseHtml

        protected IHtmlDocument ParseHtml(string htmlString)
        {
            return new HtmlParser().ParseDocument(htmlString);
        }

        #endregion
    }
}