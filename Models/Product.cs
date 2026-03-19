using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "ID")]
        public int ProductId { get; set; }
        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        public string Name { get; set; } = null!;
        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Ürün Fiyatı zorunludur.")]
        [Range(0, 100000, ErrorMessage = "Fiyat 0 ile 100000 arasında olmalı")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;


        [Display(Name = "Aktif")]
        public bool IsActive { get; set; }
        [Display(Name = "Kategori ID")]
        public int CategoryId { get; set; }
    }
}