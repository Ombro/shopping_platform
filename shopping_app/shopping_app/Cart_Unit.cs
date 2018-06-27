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
    public partial class Cart_Unit : Form
    {
        public Cart_Unit()
        {
            InitializeComponent();
        }

        private void GWCSPXX_Load(object sender, EventArgs e)
        {


        }

        private void SPDJ_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                int dj = Int32.Parse(SPDJ.Text);
                int sl = Int32.Parse(domainUpDown1.Text);
                double sum = dj * sl;
                ZJG.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("unable to convert");
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
