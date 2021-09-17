using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VolvoTest.MVC.Models
{
    public class Truck
    {
        public int Id { get; set; }

        public string Brand { get => "Volvo"; }

        [Required]
        [RegularExpression(@"^FH|FM$")]
        [Display(Name = "Model")]
        public string TruckModel { get; set; }

        [Display(Name = "Manufacture Year")]
        [Range(2021, 2021)]
        public short ManufactureYear { get; set; }

        [Display(Name = "Model Year")]
        [Required]
        [Range(2021, 2022)]
        public short ModelYear { get; set; }
        
        [Required]
        [RegularExpression(@"^[0-9]{11}$")]
        public long Renavam { get; set; }

        [RegularExpression(@"^[A-Z]{3}([0-9]{4}|[0-9]+[A-J]+[0-9]{2})$")]
        [Required]
        public string Plate { get; set;}

        [RegularExpression(@"^[A-Z0-9]{17}$")]
        [Required]
        public string Chassi { get; set;}

        [Display(Name = "Horse Power")]
        [Required]
        [Range(200, 1000)]
        public short HorsePower { get; set; }
    }
}