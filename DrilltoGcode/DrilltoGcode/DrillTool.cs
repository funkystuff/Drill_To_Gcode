using System.Collections.Generic;
using System.ComponentModel;

namespace DrilltoGcode
{
    /// <summary>
    /// Drill tool.
    /// </summary>
    public class DrillTool
    {
        #region Variabili

        private List<Point> _Points;

        #endregion

        #region Proprietà

        [DisplayName("Points"), Description("List of point associated with the related tool"), ReadOnlyAttribute(false)]
        public List<Point> Points
        {
            get { return _Points; }
        }

        [DisplayName("Name"), Description("Name of related tool"), ReadOnlyAttribute(true)]
        public string ToolName { get; set; }

        [DisplayName("Diameter"), Description("Diameter of the related tool"), ReadOnlyAttribute(false)]
        public double DrillDiameter { get; set; }
        
        [DisplayName("Quantity"), Description("Number of points of related tool"), ReadOnlyAttribute(true)]
        public int DrillQuantity { get; set; }
        
        [DisplayName("Plating"), Description("Type of drill"), ReadOnlyAttribute(false)]
        public DrillType Type { get; set; }

        [DisplayName("Unit"), Description("The measurement unit of drill file"), ReadOnlyAttribute(false)]
        public Units Unit { get; set; }

        [DisplayName("Normalized"), Description("The tool is normalized"), ReadOnlyAttribute(true)]
        public bool Normalized { get; set; }

        [Browsable(false)]
        public int LastNormal { get; set; }

        #endregion

        #region Costruttori

        /// <summary>
        /// Costruttore di base.
        /// </summary>
        public DrillTool()
        {
            _Points = new List<Point>();
            Normalized = false;
            LastNormal = 0;

            ToolName = "***";
            DrillDiameter = 0;
            DrillQuantity = 0;
            Type = DrillType.NonPLated;
            Unit = Units.Metric;
        }

        /// <summary>
        /// Costruttore.
        /// </summary>
        /// <param name="name">Nome del tool</param>
        /// <param name="diameter">Diametro foro</param>
        /// <param name="quantity">Quantità dei fori</param>
        /// <param name="type">Tipo metalizzazione</param>
        /// <param name="unit">Unità di misura</param>
        public DrillTool(string name, double diameter, int quantity, DrillType type, Units unit)
            : this()
        {
            ToolName = name;
            DrillDiameter = diameter;
            DrillQuantity = quantity;
            Type = type;
            Unit = unit;
        } 

        #endregion

        #region Metodi

        /// <summary>
        /// Converte il tool in stringa.
        /// </summary>
        /// <returns>Valore stringa che rappresenta il tool</returns>
        public override string ToString()
        {
            return ToolName;
        }

        /// <summary>
        /// Aggiunge un punto alla lista di punti.
        /// </summary>
        /// <param name="point">Punto da aggiungere</param>
        public void AddPoint(Point point)
        {
            _Points.Add(point);
            this.Update();
        }

        /// <summary>
        /// Aggiorna il numero di fori.
        /// </summary>
        public void Update()
        {
            DrillQuantity = _Points.Count;
        }

        #endregion
    }
}
