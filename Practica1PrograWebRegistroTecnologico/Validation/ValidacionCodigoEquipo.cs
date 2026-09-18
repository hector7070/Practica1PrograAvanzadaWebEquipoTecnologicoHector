using System.ComponentModel.DataAnnotations;

namespace Practica1PrograWebRegistroTecnologico.Validation
{
    public class ValidacionCodigoEquipo : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string codigoInventario = value as string;
            if (string.IsNullOrEmpty(codigoInventario))
            {
                return new ValidationResult("El código de inventario es obligatorio.");
            }
            // Validar que el código de inventario empiece con EQ-
            if (!codigoInventario.StartsWith("EQ-"))
            {
                return new ValidationResult("El código de inventario debe empezar con 'EQ-'");
            }
            return ValidationResult.Success;
        }
    }
}
