using System.Data;

namespace PrimerParcialPooII.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }



        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public DataSetDateTime LastMovement { get; set; }
    }

}