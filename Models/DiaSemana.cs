namespace LaboratorioMVC.Models
{
    /// <summary>
    /// Modelo utilizado para identificar el día de la semana.
    /// </summary>
    public class DiaSemana
    {
        /// <summary>
        /// Número del día seleccionado.
        /// </summary>
        public int? NumeroDia { get; set; }

        /// <summary>
        /// Nombre del día identificado.
        /// </summary>
        public string NombreDia { get; set; }
    }
}