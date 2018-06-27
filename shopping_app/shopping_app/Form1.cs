using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.IO;
using System.Net;
using shopping_app;
using MySql.Data.MySqlClient;

namespace shopping_app
{
    public delegate void Show(string username);        //申明委托
    public partial class Form1 : XtraForm
    {
        public string username ="";
        public Classify classify = new Classify();
        public Form_INFO info = new Form_INFO();
        public string cur_class = "";
        public Form1()
        {
            InitializeComponent();

            //图书分类界面
            classify.Name = "CLASSIFY";
            classify.TopLevel = false;
            this.panel1.Controls.Clear();
            classify.Parent = this.panel1;
            classify.Dock = System.Windows.Forms.DockStyle.Fill;
            classify.Show();
            classify.Visible = false;

            //用户资料界面
            info.TopLevel = false;
            this.panel1.Controls.Clear();
            info.Dock = System.Windows.Forms.DockStyle.Fill;
            info.Name = "INFO";
            this.panel1.Controls.Add(info);
            info.Show();
            info.Visible = false;

            //用户登陆界面
            Show form_show = new Show(show);
            Login login = new Login(form_show);
            login.ShowDialog();
        }

        public void show(string username)
        {
            this.username = username;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * ");
            sb.Append("FROM Account  ");
            sb.Append("WHERE UserName = ?UserName ");
            sb.Append("ORDER BY UserID DESC ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("?UserName", MySqlDbType.String)
                };
            parameters[0].Value = username;
            MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
            if (dt.Read())
            {
                this.panel1.Controls.Clear();
                Form_INFO form_info = new Form_INFO(username);
                string img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(6);
                form_info.cur_account.Text = dt.GetString(1);
                form_info.cur_nickname.Text = dt.GetString(2);
                form_info.TopLevel = false;
                form_info.Dock = System.Windows.Forms.DockStyle.Fill;
                form_info.pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                this.panel1.Controls.Add(form_info);
                form_info.Show();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void inboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "程序设计";
            classify.cur_class = Class;

            //显示图书分类界面
            info.Visible = false;
            classify.Visible = true;
            
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void organizerGroup_ItemChanged(object sender, EventArgs e)
        {

        }

        private void calendarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool flag = true;
            foreach (Control ctrl in this.panel1.Controls)
            {
                if (ctrl.Name == "INFO")
                {
                    info.Visible = true;
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Form_INFO info = new Form_INFO();
                info.TopLevel = false;
                this.panel1.Controls.Clear();
                info.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel1.Controls.Add(info);
                info.Show();
            }
        }

        private void tasksItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {







            //Order_Container container = new Order_Container();
            //container.TopLevel = false;
            //this.panel1.Controls.Clear();
            //container.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.panel1.Controls.Add(container);

            ////查询订单数
            //try
            //{
            //    StringBuilder sb = new StringBuilder();

            //    //指定查询的表和字段
            //    sb.Append("SELECT UserName,Passwd ");
            //    sb.Append("FROM Account  ");

            //    //筛选条件
            //    sb.Append("WHERE UserName = ?UserName AND Passwd = ?Passwd ");

            //    //排序
            //    sb.Append("ORDER BY UserID DESC ");


            //    MySqlParameter[] parameters = {
            //        new MySqlParameter("?UserName", MySqlDbType.String),
            //        new MySqlParameter("?Passwd", MySqlDbType.String)
            //    };

            //    //parameters[0].Value = textBox1.Text;
            //    //parameters[1].Value = textBox2.Text;

            //    MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);


            //    if (dt.Read())
            //    {
            //        MyDel del = new MyDel(Close);

            //        State state = new State(del);
            //        state.label1.Text = "登陆成功！！！";
            //        //state.label1.Text = dt.GetString(0);
            //        state.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("找不到用户！！！", "提示信息！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}




            //Order_Form order_form = new Order_Form();
            //order_form.TopLevel = false;
            //container.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.panel1.Controls.Add(order_form);



            //Order_Form info = new Order_Form();
            ////取消顶级容器
            //info.TopLevel = false;
            ////清除原先窗口控件
            //this.panel1.Controls.Clear();
            ////填充父窗口
            //info.Dock = System.Windows.Forms.DockStyle.Fill;
            ////添加窗口
            //this.panel1.Controls.Add(info);
            ////显示窗口
            //info.Show();



            ////获取图片名称
            //OpenFileDialog img = new OpenFileDialog();
            //img.Title = "select an image^_^";
            //img.InitialDirectory = @"C:\";
            //img.Filter = "jpg图像(*.jpg)|*.jpg|png图像(*.png)|.png|gif图像(*.gif)|.gif";
            //img.FilterIndex = 1;
            //img.RestoreDirectory = true;
            //if(img.ShowDialog()==DialogResult.OK)
            //{
            //    label1.Text = System.IO.Path.GetFileName(img.FileName);


            //    //System.IO.Path.GetFullPath(img.FileName);                         //绝对路径

            //    //System.IO.Path.GetExtension(img.FileName);                        //文件扩展名

            //    //System.IO.Path.GetFileNameWithoutExtension(img.FileName);         //文件名没有扩展名

            //    //System.IO.Path.GetFileName(img.FileName);                         //得到文件

            //    //System.IO.Path.GetDirectoryName(img.FileName);                    //得到路径
            //}




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Filename = "";
            string Filepath = "";
            string Newfilename = "";

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
            }
            FTP upload = new FTP();
            upload.UploadFile(Filepath);

            FTP rename = new FTP();
            Newfilename = DateTime.Now.ToFileTimeUtc().ToString();      //重命名为时间戳
            label1.Text = Newfilename;
            rename.Rename(Filename, Newfilename);

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            FTP delete = new FTP();
            delete.Delete("kali_wallpaper.jpg");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //删除测试
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM Account WHERE UserName = ?UserName ");
            MySqlParameter[] parameters = {
                                     new MySqlParameter("?UserName", MySqlDbType.String)
                                 };
            parameters[0].Value = "hhb";
            SQLHelper.ExecuteNonQuery(sb.ToString(), CommandType.Text, parameters);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Goods add_goods = new Add_Goods();
            add_goods.ShowDialog();
        }

        private void outboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "图形图像";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }

        private void draftsItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "操作系统";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }

        private void outboxItem_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void trashItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "网络通讯";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "信息安全";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "人工智能";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "移动开发";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "计算机理论";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string Class = "计算机认证";
            classify.cur_class = Class;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Goods  ");
                sb.Append("WHERE Classify = ?Classify ");
                sb.Append("ORDER BY Price ASC ");
                MySqlParameter[] parameters = {
                    new MySqlParameter("?Classify", MySqlDbType.String)
                };
                parameters[0].Value = Class;
                MySqlDataReader dt = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, parameters);
                if (dt.HasRows)
                {
                    string img_path;
                    int i = 0;
                    classify.flowLayoutPanel1.Controls.Clear();
                    while (dt.Read())
                    {
                        Goods goods = new Goods();
                        goods.Name = "goods_" + i.ToString();
                        goods.TopLevel = false;
                        goods.Width = panel1.Width / 5;
                        goods.Height = panel1.Width / 5;
                        img_path = System.Configuration.ConfigurationManager.AppSettings["IP_Address"].ToString() + dt.GetString(4);
                        goods.img.Image = Image.FromStream(System.Net.WebRequest.Create(img_path).GetResponse().GetResponseStream());
                        goods.goodsname.Text = dt.GetString(1);
                        goods.price.Text = dt.GetString(2);
                        classify.flowLayoutPanel1.Controls.Add(goods);
                        goods.Show();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.panel1.Controls.Add(classify);
            classify.Show();
        }
    }
}