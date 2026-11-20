using System.ComponentModel.DataAnnotations;

namespace day6_ba_thang.Models
{
    public class product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =3)]
        public string Name { get; set; }
        [Range(0,1000.00)]
        public decimal price {  get; set; }
        public string description {  get; set; }
    }
}
