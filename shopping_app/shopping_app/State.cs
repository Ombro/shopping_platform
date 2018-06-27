using System;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Text;
using System.Data;

namespace shopping_app
{
    public partial class State : Form
    {
        public string username;
        MyDel mydel;
        Show form_show;

        public State(MyDel del)
        {
            this.mydel = del;
            InitializeComponent();
        }

        public State(MyDel del, string username)
        {
            this.mydel = del;
            this.username = username;
            InitializeComponent();
        }

        public State(MyDel del, Show form_show, string username)
        {
            this.mydel = del;
            this.form_show = form_show;
            this.username = username;
            InitializeComponent();
        }

        private void Register_State_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_show(username);
            this.Close();
            mydel();
            
        }

        private void Register_State_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                form_show(username);
                mydel();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
