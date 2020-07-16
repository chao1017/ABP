using Abp.Application.Services.Dto;

namespace Roger.TestApi.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

