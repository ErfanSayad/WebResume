using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.Entities;

public class MySkills
{
    public int Id { get; set; }

    [Required(ErrorMessage = "وارد کردن نام مهارت الزامی است")]
    public string SkillTitle { get; set; }


    [Range(1, 100, ErrorMessage = "درصد تسلط باید بین 1 تا 100 باشد")]
    public int Percentage { get; set; }
}
