using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilltoGcode
{
    public enum drilltype {PLATED,NONPLATED};
    public class point {
        double x;
        double y;
        public point(double xi,double yi)
        {
            x = xi;
            y = yi;
        }
        public point()
        {
            x = 0;
            y = 0;
        }
        public override string ToString()
        {
            return "Punto: "+x.ToString()+" ; "+y.ToString();
        }
        public double X
        {
            get { return x; }
            set { if (value != x) x = value; }
        }
        public double Y
        {
            get { return y; }
            set { if (value != y) y = value; }
        }
    };
    public class DrillTool
    {
        //Variabili
        string toolname;
        double drilldiameter;
        int drillquantity;
        drilltype type;
        m_unit unit;
        List<point> points;
        bool normalized;
        int lastnormval;
        //Proprietà
        [DisplayName("Name"), Description("Name of related tool"), ReadOnlyAttribute(true)]
        public string TOOLNAME
        {
            get { return toolname; }
            set { if (value != toolname) toolname = value; }
        }
        [DisplayName("Diameter"), Description("Diameter of the related tool"), ReadOnlyAttribute(false)]
        public double DRILLDIAMETER
        {
            get { return drilldiameter; }
            set { if (value != drilldiameter) drilldiameter = value; }
        }
        [DisplayName("Quantity"), Description("Number of points of related tool"), ReadOnlyAttribute(true)]
        public int DRILLQUANTITY
        {
            get { return drillquantity; }
            set { if (value != drillquantity) drillquantity = value; }
        }
        [DisplayName("Plating"), Description("The property says the type of drill"), ReadOnlyAttribute(false)]
        public drilltype TYPE
        {
            get { return type; }
            set { if (value != type) type = value; }
        }
        [DisplayName("Points"), Description("List of point associated with the related tool"), ReadOnlyAttribute(false)]
        public List<point> POINTS
        {
            get { return points; }
            set { if (value != points)
                    points = value;
            }
        }
        [DisplayName("Unit"), Description("The measure unit of drill file"), ReadOnlyAttribute(false)]
        public m_unit UNIT
        {
            get { return unit; }
            set { if (value != unit) unit = value; }
        }
        [DisplayName("Normalized"),Description("The property says if the tool is normalized"),ReadOnlyAttribute(true)]
        public bool NORMALIZED
        {
            get { return normalized; }
            set { if (value != normalized) normalized = value;}
        }
        [Browsable(false)]
        public int LASTNORMVAL
        {
            get { return lastnormval; }
            set { if (value != lastnormval) lastnormval = value; }
        }

        //Costruttore
        public DrillTool()
        {
            toolname = "***";
            drilldiameter = 0;
            drillquantity = 0;
            type = drilltype.NONPLATED;
            unit = m_unit.METRIC;
            points = new List<point>();
            normalized = false;
            lastnormval = 0;
        }
        //Membri
        public DrillTool(string name,double diameter,int quantity,drilltype tp,m_unit un)
        {
            toolname = name;
            drilldiameter = diameter;
            drillquantity = quantity;
            type = tp;
            unit = un;
            points = new List<point>();
            normalized = false;
            lastnormval = 0;
        }
        public override string ToString()
        {
            return toolname;
        }

        void AddPoint(point p)
        {
            points.Add(p);
            this.Update();
        }

        public void Update()
        {
            drillquantity = points.Count; 
        }
    }
}
