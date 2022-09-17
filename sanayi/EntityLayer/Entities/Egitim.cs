using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    internal class Egitim
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]//Boş Geçilemezlil
        [Display(Name = "Eğitim Adı")] // Görünecek isim
        [StringLength(50, ErrorMessage = "Max 50 karakter olmaktadır")]
        public String Egitim_Ad { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]//Boş Geçilemezlil
        [Display(Name = "Eğitmen")] // Görünecek isim
        [StringLength(50, ErrorMessage = "Max 50 karakter olmaktadır")]
        public string Egtm_Egitmen { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]//Boş Geçilemezlil
        [Display(Name = "Eğitim Yeri")] // Görünecek isim
        [StringLength(50, ErrorMessage = "Max 50 karakter olmaktadır")]
        public string Egtm_Yeri { get; set; }

        [Display(Name = "Eğitim Tarihi")] // Görünecek isim
        public DateTime Egtm_Tarihi { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]//Boş Geçilemezlil
        [Display(Name = "Onay")] // Görünecek isim
        public bool IsApproved { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]//Boş Geçilemezlil
        [Display(Name = "Eğitim ile ilgili resim")] // Görünecek isim
        public string Egtm_Image { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]//Boş Geçilemezlil
        [Display(Name = "Birimi")] // Görünecek isim
        public int UnitsId { get; set; }
        public virtual Units Units { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Cart> Cart { get; set; }
        public virtual List<Sales> Sales { get; set; }



    }
}
