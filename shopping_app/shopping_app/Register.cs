using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using shopping_app;

namespace shopping_app
{
    public delegate void MyDel();       //申明委托

    public partial class Register : Form
    {
        public string Filename = "";
        public string Filepath = "";
        public string Newfilename = "";
        public bool Register_State = false;


        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nickname.Text == "" || username.Text == "" || passwd.Text == "" || contact.Text == "")
            {
                MessageBox.Show("请填写完整信息！！！");
            }
            else if(Newfilename == "")
            {
                MessageBox.Show("请上传您的头像！！！");
            }
            else
            {
                //string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
                try
                {
                    FTP upload = new FTP();
                    upload.UploadFile(Filepath);

                    FTP rename = new FTP();
                    rename.Rename(Filename, Newfilename);


                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO Account(UserName,NickName,Passwd,Contact,Balance,URI) ");
                    sb.Append("VALUES(?UserName,?NickName,?Passwd,?Contact,?Balance,?URI) ");
                    MySqlParameter[] parameters = {
                                     new MySqlParameter("?NickName", MySqlDbType.String),
                                     new MySqlParameter("?UserName", MySqlDbType.String),
                                     new MySqlParameter("?Passwd", MySqlDbType.String),
                                     new MySqlParameter("?Contact", MySqlDbType.String),
                                     new MySqlParameter("?Balance", MySqlDbType.Double),
                                     new MySqlParameter("?URI", MySqlDbType.String)
                                 };
                    parameters[0].Value = nickname.Text.ToString();
                    parameters[1].Value = username.Text.ToString();
                    parameters[2].Value = passwd.Text.ToString();
                    parameters[3].Value = contact.Text.ToString();
                    parameters[4].Value = 0;
                    parameters[5].Value = Newfilename;
                    SQLHelper.ExecuteNonQuery(sb.ToString(), CommandType.Text, parameters);

                    MyDel del = new MyDel(Close);

                    State state_form = new State(del);
                    state_form.label1.Text = "注册成功！！！";
                    state_form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void 账号_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            //FTP upload = new FTP();
            //upload.UploadFile(Filepath);

            //FTP rename = new FTP();
            //Newfilename = DateTime.Now.ToFileTimeUtc().ToString();      //重命名为时间戳
            //rename.Rename(Filename, Newfilename);
            //Img_Name = Newfilename;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT NickName ");
                sb.Append("FROM Account  ");
                sb.Append("WHERE NickName = ?NickName ");
                sb.Append("ORDER BY UserID DESC ");
                MySqlParameter[] parameters = {
                        new MySqlParameter("?NickName", MySqlDbType.String)
                    };
                parameters[0].Value = nickname.Text;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.Read())
                {
                    nickname.Text = "";
                    MessageBox.Show("该昵称已存在！！！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT UserName ");
                sb.Append("FROM Account  ");
                sb.Append("WHERE UserName = ?UserName ");
                sb.Append("ORDER BY UserID DESC ");
                MySqlParameter[] parameters = {
                        new MySqlParameter("?UserName", MySqlDbType.String)
                    };
                parameters[0].Value = username.Text;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.Read())
                {
                    username.Text = "";
                    MessageBox.Show("该账号已存在！！！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
