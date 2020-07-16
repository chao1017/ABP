using System.ComponentModel.DataAnnotations;

namespace Roger.TestApi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}