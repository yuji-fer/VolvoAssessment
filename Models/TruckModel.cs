using System.ComponentModel.DataAnnotations;

namespace VolvoTest.MVC.Models
{
    public class TruckModel
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        [Display(Name = "Model")]
        public string Name { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}