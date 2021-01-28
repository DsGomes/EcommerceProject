using EcommerceProject.Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Entities.Entities
{
    public class BaseEntity : Notifiers
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
