using System.ComponentModel.DataAnnotations.Schema;

namespace PedaleaShop.WebApi.Domain.Entities
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public AspNetUsers User { get; set; }
    }
}
