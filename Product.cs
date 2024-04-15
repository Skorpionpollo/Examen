using System.ComponentModel.DataAnnotations;

namespace Actividades.Datos
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un número entero positivo")]
        public int NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido")]
        [StringLength(200, ErrorMessage = "El nombre del producto no debe exceder los 200 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El departamento es requerido")]
        public Departamento Departamento { get; set; }
    }

    public enum Departamento
    {
        Frutas,
        Verduras,
        Lacteos
    }
}
