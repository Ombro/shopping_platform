namespace shopping_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.organizerGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.calendarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.inboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.outboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.draftsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.trashItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.panel1);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1282, 853);
            this.splitContainerControl.SplitterPosition = 165;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.organizerGroup;
            this.navBarControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mailGroup,
            this.organizerGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.inboxItem,
            this.outboxItem,
            this.draftsItem,
            this.trashItem,
            this.calendarItem,
            this.tasksItem,
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(165, 853);
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl1";
            // 
            // organizerGroup
            // 
            this.organizerGroup.Caption = "用户中心";
            this.organizerGroup.Expanded = true;
            this.organizerGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.calendarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.tasksItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.organizerGroup.LargeImageIndex = 1;
            this.organizerGroup.Name = "organizerGroup";
            this.organizerGroup.ItemChanged += new System.EventHandler(this.organizerGroup_ItemChanged);
            // 
            // calendarItem
            // 
            this.calendarItem.Caption = "个人资料";
            this.calendarItem.Name = "calendarItem";
            this.calendarItem.SmallImageIndex = 4;
            this.calendarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.calendarItem_LinkClicked);
            // 
            // tasksItem
            // 
            this.tasksItem.Caption = "所有订单";
            this.tasksItem.Name = "tasksItem";
            this.tasksItem.SmallImageIndex = 5;
            this.tasksItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.tasksItem_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "购物车";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "收藏夹";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // mailGroup
            // 
            this.mailGroup.Caption = "图书分类";
            this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.inboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.outboxItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.draftsItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.trashItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.mailGroup.LargeImageIndex = 0;
            this.mailGroup.Name = "mailGroup";
            // 
            // inboxItem
            // 
            this.inboxItem.Caption = "程序设计";
            this.inboxItem.Name = "inboxItem";
            this.inboxItem.SmallImageIndex = 0;
            this.inboxItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.inboxItem_LinkClicked);
            // 
            // outboxItem
            // 
            this.outboxItem.Caption = "图形图像";
            this.outboxItem.Name = "outboxItem";
            this.outboxItem.SmallImageIndex = 1;
            this.outboxItem.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.outboxItem_LinkPressed);
            this.outboxItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.outboxItem_LinkClicked);
            // 
            // draftsItem
            // 
            this.draftsItem.Caption = "操作系统";
            this.draftsItem.Name = "draftsItem";
            this.draftsItem.SmallImageIndex = 2;
            this.draftsItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.draftsItem_LinkClicked);
            // 
            // trashItem
            // 
            this.trashItem.Caption = "网络通讯";
            this.trashItem.Name = "trashItem";
            this.trashItem.SmallImageIndex = 3;
            this.trashItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.trashItem_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "信息安全";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "人工智能";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "移动开发";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "计算机理论";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem6_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "计算机认证";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png");
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 853);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 72);
            this.button4.TabIndex = 4;
            this.button4.Text = "商品上架";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除hhb账户";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "上传图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.splitContainerControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup mailGroup;
        private DevExpress.XtraNavBar.NavBarGroup organizerGroup;
        private DevExpress.XtraNavBar.NavBarItem inboxItem;
        private DevExpress.XtraNavBar.NavBarItem outboxItem;
        private DevExpress.XtraNavBar.NavBarItem draftsItem;
        private DevExpress.XtraNavBar.NavBarItem trashItem;
        private DevExpress.XtraNavBar.NavBarItem calendarItem;
        private DevExpress.XtraNavBar.NavBarItem tasksItem;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
