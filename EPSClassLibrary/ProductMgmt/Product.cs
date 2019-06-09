using EPSClassLibrary.UserMgmt;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPSClassLibrary.ProductMgmt
{
    public class Product
    {
        public Product()
        {
            Images = new List<ProductImages>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Minimum Price Required")]
        public int MinPrice { get; set; }
        [Required(ErrorMessage = "Maximum Price Required")]
        public int MaxPrice { get; set; }
        [Required(ErrorMessage = "Condition Of Item Required")]
        public int Condition { get; set; }
        [Required(ErrorMessage = "Product Description Required")]
        public string Description { get; set; }
        public string DateAdded { get; set; }
        public bool Available { get; set; }
        public User User { get; set; }
        [Required(ErrorMessage = "Minimum Price Required")]
        public Category Category { get; set; }
        public ICollection<ProductImages> Images { get; set; }

    }
}
