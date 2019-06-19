using System.ComponentModel.DataAnnotations;

namespace LanguageOmg.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}