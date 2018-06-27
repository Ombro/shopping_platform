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
    public partial class SPXX : Form
    {
        public SPXX()
        {
            InitializeComponent();
        }

        private void btnGWC_Click(object sender, EventArgs e)
        {
            GWC gwc = new GWC();
            gwc.Show();

        }

        private void labJG_Click(object sender, EventArgs e)
        {

        }

        private void labSPMZ_Click(object sender, EventArgs e)
        {

        }
    }
}
