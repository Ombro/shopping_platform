using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        Show form_show;

        public Login()
        {
            InitializeComponent();
        }

        public Login(Show form_show)
        {
            this.form_show = form_show;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //指定查询的表和字段
                sb.Append("SELECT * ");
                sb.Append("FROM Account  ");

                //筛选条件
                sb.Append("WHERE UserName = ?UserName AND Passwd = ?Passwd ");

                //排序
                sb.Append("ORDER BY UserID DESC ");


                MySqlParameter[] parameters = {
                    new MySqlParameter("?UserName", MySqlDbType.String),
                    new MySqlParameter("?Passwd", MySqlDbType.String)
                };

                parameters[0].Value = textBox1.Text;
                parameters[1].Value = textBox2.Text;

                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                

                if(dt.Read())
                {
                    string name = dt.GetString(1);
                    MyDel del = new MyDel(Close);

                    State state = new State(del, this.form_show, name);
                    state.label1.Text = "登陆成功！！！";
                    //state.label1.Text = dt.GetString(0);
                    
                    state.ShowDialog();

                    

                }
                else
                {
                    MessageBox.Show("找不到用户！！！", "提示信息！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                








            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.ShowDialog();
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //制定查询的表和字段
                sb.Append("SELECT URI ");
                sb.Append("FROM Account  ");

                //筛选条件
                sb.Append("WHERE UserName = ?UserName ");

                //排序
                sb.Append("ORDER BY UserID DESC ");


                MySqlParameter[] parameters = {
                    new MySqlParameter("?UserName", MySqlDbType.String)
                };

                parameters[0].Value = textBox1.Text;

                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);


                if (dt.Read())
                {
                    string img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(0);
                    pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                }
            }
            catch(Exception ex)
            {
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
