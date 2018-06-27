using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping_app
{
    public partial class GWC : Form
    {
        public GWC()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GWC_Load(object sender, EventArgs e)
        {
            Cart_Unit gwcspxx = new Cart_Unit();
            gwcspxx.Width = 800;
            gwcspxx.Height = 200;
            gwcspxx.TopLevel = false;
            this.flowlayout.Controls.Add(gwcspxx);
            gwcspxx.Show();

            this.flowlayout.Show();
        }
    }
}
