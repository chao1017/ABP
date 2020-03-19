using System.ComponentModel.DataAnnotations;

namespace MyHouse.MyProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}