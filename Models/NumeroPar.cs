namespace LaboratorioMVC.Models
{
    /// <summary>
    /// Modelo utilizado para verificar si un número es par.
    /// </summary>
    public class NumeroPar
    {
        /// <summary>
        /// Número que ingresará el usuario.
        /// </summary>
        public int? Numero { get; set; }

        /// <summary>
        /// Indica si el número es par.
        /// </summary>
        public bool EsPar { get; set; }

        /// <summary>
        /// Determina si el número es par.
        /// </summary>
        public void VerificarParidad()
        {
            if (Numero.HasValue)
            {
                EsPar = Numero.Value % 2 == 0;
            }
        }
    }
}