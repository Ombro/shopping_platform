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
    public partial class Add_Goods : Form
    {
        public string Filename = "";
        public string Filepath = "";
        public string Newfilename = "";

        public Add_Goods()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Title = "select an image^_^";
            img.InitialDirectory = @"C:\";
            img.Filter = "jpg图像(*.jpg)|*.jpg|png图像(*.png)|.png|gif图像(*.gif)|.gif|所有文件(*.*)|*.*";
            img.FilterIndex = 1;
            img.RestoreDirectory = true;
            if (img.ShowDialog() == DialogResult.OK)
            {
                Filename = System.IO.Path.GetFileName(img.FileName);
                Filepath = System.IO.Path.GetFullPath(img.FileName);
                pictureBox1.Image = Image.FromFile(Filepath);
                Newfilename = DateTime.Now.ToFileTimeUtc().ToString() + ".jpg";      //重命名为时间戳
            }
        }

        private void GoodUp_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (name.Text == "" || number.Text == "" || price.Text == "" || brief.Text == ""|| number.Value == 0|| Filepath == "")
                {
                    MessageBox.Show("请填写完整的商品信息！！！");
                }
                else
                {
                    FTP upload = new FTP();
                    upload.UploadFile(Filepath);
                    FTP rename = new FTP();
                    rename.Rename(Filename, Newfilename);
                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append("INSERT INTO Goods(Name,Price,Quantity,URI,Brief,Classify) ");
                    sb1.Append("VALUES(?Name,?Price,?Quantity,?URI,?Brief,?Classify) ");
                    MySqlParameter[] parameters1 = {
                                     new MySqlParameter("?Name", MySqlDbType.String),
                                     new MySqlParameter("?Price", MySqlDbType.Double),
                                     new MySqlParameter("?Quantity", MySqlDbType.Int32),
                                     new MySqlParameter("?URI", MySqlDbType.String),
                                     new MySqlParameter("?Brief", MySqlDbType.String),
                                     new MySqlParameter("?Classify", MySqlDbType.String)
                                 };
                    parameters1[0].Value = "《" + name.Text.ToString() + "》";
                    parameters1[1].Value = Convert.ToDouble(price.Text);
                    parameters1[2].Value = Convert.ToInt32(number.Value);
                    parameters1[3].Value = Newfilename.ToString();
                    parameters1[4].Value = brief.Text.ToString();
                    parameters1[5].Value = classify.Text.ToString(); ;
                    SQLHelper.ExecuteNonQuery(sb1.ToString(), CommandType.Text, parameters1);
                    MessageBox.Show("商品上架成功！！！");
                }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void name_Leave(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Name ");
            sb.Append("FROM Goods  ");
            sb.Append("WHERE Name = ?Name ");
            sb.Append("ORDER BY Price DESC ");
            MySqlParameter[] parameters = {
                        new MySqlParameter("?Name", MySqlDbType.String)
                    };
            parameters[0].Value = name.Text;
            MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
            if (dt.Read())
            {
                name.Text = "";
                MessageBox.Show("该商品名已存在！！！");
            }
        }

        private void number_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
