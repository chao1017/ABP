using System;
using System.Collections.Generic;
using System.Text;
using Roger.DataProcessAPI.Localization;
using Volo.Abp.Application.Services;

namespace Roger.DataProcessAPI
{
    /* Inherit your application services from this class.
     */
    public abstract class DataProcessAPIAppService : ApplicationService
    {
        protected DataProcessAPIAppService()
        {
            LocalizationResource = typeof(DataProcessAPIResource);
        }
    }
}
