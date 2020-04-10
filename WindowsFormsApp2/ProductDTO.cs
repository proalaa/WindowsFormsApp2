using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace WindowsFormsApp2
{
   
    public class ProductDTO 
    {
        public long SKU { get; set; }
        public string اسم_المنتج { get; set; }
        public double الكمية { get; set; }
        public string الوحده { get; set; }
        public decimal سعر_الشراء { get; set; }
        public decimal السعر_المقترح { get; set; }
        public decimal السعر_النهائي { get; set; }
        public ProductDTO()
        {
            
        }
        public List<ProductDTO> GetProducts(long SKU)
        {
            using (var db = new Entities())
            {
                return (from b in db.productsAllnfoes
                        where b.SKU == SKU
                        select new ProductDTO {
                            SKU = b.SKU,
                            اسم_المنتج = b.اسم_المنتج,
                            الكمية = b.الكمية,
                            الوحده = b.الوحده,
                            سعر_الشراء = b.سعر_الشراء,
                            السعر_المقترح = b.سعر_البيع
                            ,السعر_النهائي = b.سعر_البيع
                        }).ToList();
               
            }

        }

       
    }
}