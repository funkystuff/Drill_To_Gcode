using System;
using System.Windows.Forms;

namespace DrilltoGcode
{
    public partial class NormalizeForm : Form
    {
        public NormalizeForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
