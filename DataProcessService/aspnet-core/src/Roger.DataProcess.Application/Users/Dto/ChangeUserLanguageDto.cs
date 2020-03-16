using System.ComponentModel.DataAnnotations;

namespace Roger.DataProcess.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}