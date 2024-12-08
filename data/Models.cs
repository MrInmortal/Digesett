using System.ComponentModel.DataAnnotations;


namespace DIGESETTApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Cedula { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Clave { get; set; } = "";
    }

    public class Multa
    {
        public int Id { get; set; }
        public int AgenteId { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria.")]
        public string Cedula { get; set; } = "";

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "Debe seleccionar un concepto.")]
        public int ConceptoId { get; set; }

        public ConceptoMulta Concepto { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; } = "";

        [Required(ErrorMessage = "Las coordenadas son obligatorias.")]
        public string Coordenadas { get; set; } = "";

        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public string Foto { get; set; } = "";

        public DateTime Fecha { get; set; }

        public bool Activa { get; set; } = true;

        [Required(ErrorMessage = "El monto es obligatorio.")]
        public decimal Monto { get; set; }
    }

    public class ConceptoMulta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = "";
        public string? Nombre { get; set; }
    }
}
