using Abp.Application.Services.Dto;

namespace Roger.DataProcess.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

