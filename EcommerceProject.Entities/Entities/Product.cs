using EcommerceProject.Entities.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.Entities.Entities
{
    [Table("Product")]
    public class Product : Notifiers
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_NAME")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        
        [Column("PRD_Price")]
        [Display(Name = "Valor")]
        public decimal Price { get; set; }

        [Column("PRD_Status")]
        public bool Status { get; set; }
    }
}
