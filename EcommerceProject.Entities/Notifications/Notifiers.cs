using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.Entities.Notifications
{
    public class Notifiers
    {
        public Notifiers()
        {
            Notifications = new List<Notifiers>();
        }

        [NotMapped]
        public string NameProperty { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifiers> Notifications { get; set; }

        public bool ValidatePropertyString(string valor, string nameProperty)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notifiers
                {
                    Message = "Campo Obrigatório",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }

        public bool ValidatePropertyInt(int valor, string nameProperty)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notifiers
                {
                    Message = "Valor deve ser maior que 0",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }

        public bool ValidatePropertyDecimal(decimal valor, string nameProperty)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notifiers
                {
                    Message = "Valor deve ser maior que 0",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }
    }
}
