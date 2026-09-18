using Microsoft.AspNetCore.Mvc.ModelBinding;
using Practica1PrograWebRegistroTecnologico.Validation;
using System.ComponentModel.DataAnnotations;

namespace Practica1PrograWebRegistroTecnologico.Models
{
    public class EquipoTecnologico
    {
        [BindNever]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Length(1, 50, ErrorMessage = "El nombre debe tener entre 1 y 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria")]
        [Length(1, 30, ErrorMessage = "La marca debe tener entre 1 y 30 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(1, 5000, ErrorMessage = "El precio debe ser un valor positivo entre 1 y 5000")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "El código de inventario es obligatorio")]
        [ValidacionCodigoEquipo(ErrorMessage = "El código de inventario debe empezar con 'EQ-'")]
        public string CodigoInventario { get; set; }
    }
}
