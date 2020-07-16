using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Roger.TestApi.Roles.Dto;
using Roger.TestApi.Users.Dto;

namespace Roger.TestApi.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
