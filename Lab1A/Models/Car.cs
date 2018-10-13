using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1A.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string VIN { get; set; }
        public string Colour { get; set; }
        public int DealershipId { get; set; }
    }
}
