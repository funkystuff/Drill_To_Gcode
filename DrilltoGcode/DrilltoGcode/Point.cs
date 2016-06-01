using System;

namespace DrilltoGcode
{
    /// <summary>
    /// Punto geometrico bidimensionale.
    /// </summary>
    public class Point
    {
        #region Proprietà

        /// <summary>
        /// Posizione X
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Posizione Y
        /// </summary>
        public double Y { get; set; } 

        #endregion

        #region Costruttori

        /// <summary>
        /// Costruttore.
        /// </summary>
        /// <param name="x_value">Valore X</param>
        /// <param name="y_value">Valore Y</param>
        public Point(double x_value, double y_value)
        {
            X = x_value;
            Y = y_value;
        }

        /// <summary>
        /// Costruttore di base.
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }

        #endregion

        /// <summary>
        /// Crea una stringa che rappresenta la classe.
        /// </summary>
        /// <returns>Stringa</returns>
        public override string ToString()
        {
            return String.Format("Punto: {0} ; {1}", X, Y);
        }
    }
}
