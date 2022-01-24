using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testapi.Models
{
    public class MNasabah
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nama")]
        public string Nama { get; set; }

        [Required]
        [Display(Name = "Alamat")]
        public string Alamat { get; set; }

        [Required]
        [Display(Name = "Tempat_tanggal_lahir")]
        public string TTL { get; set; }

        [Required]
        [Display(Name = "Tgl_Lahir")]
        public string Tgl_Lahir { get; set; }

        [Required]
        [Display(Name = "NoKTP")]
        public string NoKTP { get; set; }

        [Required]
        [Display(Name = "NoHP")]
        public string NoHP { get; set; }
    }
}
