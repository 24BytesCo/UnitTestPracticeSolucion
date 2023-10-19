using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.Domain
{
    // La clase es una anotación personalizada que se utiliza para validar si una fecha es futura o no.
    public class DateInFutureAttribute : ValidationAttribute
    {
        private readonly Func<DateTime> _dateTimeReceived;

        // Constructor predeterminado que utiliza DateTime.Now como fuente de tiempo para la validación.
        public DateInFutureAttribute() : this(() => DateTime.Now)
        {

        }

        // Constructor que permite proporcionar una fuente de tiempo personalizada para la validación.
        public DateInFutureAttribute(Func<DateTime> dateTimeReceived)
        {
            _dateTimeReceived = dateTimeReceived;
            ErrorMessage = "La fecha debe ser futura"; // Mensaje de error predeterminado si la fecha no es futura.
        }

        // Método IsValid es invocado durante la validación para determinar si la fecha es futura.
        public override bool IsValid(object value)
        {
            bool isValid = false;

            if (value is DateTime dateTime)
            {
                // Compara la fecha proporcionada con la fecha actual o la fecha personalizada y establece isValid en true si la fecha es futura.
                isValid = dateTime > _dateTimeReceived();
            }

            return isValid; 
        }
    }
}
