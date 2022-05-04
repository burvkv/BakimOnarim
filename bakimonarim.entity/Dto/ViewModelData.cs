using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.entity.Dto
{
    using System.ComponentModel.DataAnnotations;

    public partial class Sale
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string ProductCategoryName { get; set; }

        [Display(Name = "Subcategory")]
        public string ProductSubcategoryName { get; set; }

        [Display(Name = "Product")]
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        [Display(Name = "Quantity")]
        public int SalesQuantity { get; set; }

        [Display(Name = "Amount")]
        public decimal SalesAmount { get; set; }

        [Display(Name = "Date")]
        public DateTime DateKey { get; set; }

        [Display(Name = "Store")]
        public string StoreName { get; set; }
    }
}
