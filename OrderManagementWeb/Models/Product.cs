using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagementWeb.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(100)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Code is required")]
        [StringLength(50)]
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 999999999, ErrorMessage = "Price must be greater than 0")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be 0 or greater")]
        public int Stock { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        public Product()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
    }
}
