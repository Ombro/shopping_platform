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
    public partial class Goods_Manage : Form
    {
        public Goods_Manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Name LIKE ?Name ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                        new MySqlParameter("?Name", MySqlDbType.String)
                    };
                parameters[0].Value = "%" + search.Text + "%";
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    int i = 0;
                    string img_path;
                    flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = flowLayoutPanel1.Width / 5;
                        goods.Height = flowLayoutPanel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("无近似商品！！！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
