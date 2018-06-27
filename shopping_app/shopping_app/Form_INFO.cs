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
    public partial class Form_INFO : Form
    {
        public string username;

        public Form_INFO()
        {
            InitializeComponent();
        }

        public Form_INFO(String username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nick_name_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //制定查询的表和字段
                sb.Append("SELECT NickName ");
                sb.Append("FROM Account  ");

                //筛选条件
                sb.Append("WHERE NickName = ?NickName ");

                MySqlParameter[] parameters = {
                    new MySqlParameter("?NickName", MySqlDbType.String)
                };

                parameters[0].Value = nickname.Text;

                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);


                if (dt.Read())
                {
                    if(dt.GetString(0)!=nickname.Text)
                    {
                        if (MessageBox.Show("该昵称已存在，请重新输入！！！", "提示信息！", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            nickname.Text = "";
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //////////////////
            //这里写检验信息//
            //////////////////

            //StringBuilder sb = new StringBuilder();
            //sb.Append("SELECT * ");
            //sb.Append("FROM Account  ");
            //sb.Append("WHERE UserName = ?UserName ");
            //sb.Append("ORDER BY UserID DESC ");
            //MySqlParameter[] parameters = {
            //        new MySqlParameter("?UserName", MySqlDbType.String)
            //    };
            //parameters[0].Value = username;
            //MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
            //if (dt.Read())


            //    StringBuilder sb = new StringBuilder();
            //sb.Append("UPDATE Account SET Name = ?Name WHERE ID = ?ID AND UserID = ?UserID");
            //MySqlParameter[] parameters = {
            //    new MySqlParameter("?ID", MySqlDbType.Int64),
            //    new MySqlParameter("?UserID", MySqlDbType.Int32),
            //    new MySqlParameter("?Name", MySqlDbType.String)
            //};
            //parameters[0].Value = id;
            //parameters[1].Value = userId;
            //parameters[2].Value = name;
            //return SQLHelper.ExecuteNonQuery(sb.ToString(), CommandType.Text, parameters);
        }
    }
}
