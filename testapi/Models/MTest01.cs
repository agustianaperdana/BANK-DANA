using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testapi.Models
{
    [Table("Test01")]
    public class MTest01
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nama")]
        public string Nama { get; set; }

        [Required]
        [Display(Name = "Status")]
        public Int16 Status { get; set; }

        [Required]
        [Display(Name = "Created")]
        public DateTime Created { get; set; }

        [Required]
        [Display(Name = "Updated")]
        public DateTime Updated { get; set; }

        
    }
}
