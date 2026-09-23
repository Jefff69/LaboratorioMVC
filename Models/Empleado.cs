using System;

namespace LaboratorioMVC.Models
{
    /// <summary>
    /// Representa los datos de un empleado
    /// para calcular su salario semanal.
    /// </summary>
    public class Empleado
    {
        /// <summary>
        /// Costo de una hora de trabajo.
        /// </summary>
        public decimal CostoPorHora { get; set; }

        /// <summary>
        /// Cantidad de horas trabajadas por día.
        /// </summary>
        public decimal HorasTrabajadas { get; set; }

        /// <summary>
        /// Cantidad de días trabajados por semana.
        /// </summary>
        public int DiasTrabajados { get; set; }

        /// <summary>
        /// Calcula el salario total semanal.
        /// </summary>
        /// <returns>El salario calculado.</returns>
        public decimal CalcularSalario()
        {
            return CostoPorHora * HorasTrabajadas * DiasTrabajados;
        }
    }
}