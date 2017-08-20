namespace KVM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bQSell = new DevExpress.XtraBars.BarButtonItem();
            this.bSell = new DevExpress.XtraBars.BarButtonItem();
            this.bPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.bCat = new DevExpress.XtraBars.BarButtonItem();
            this.bPrd = new DevExpress.XtraBars.BarButtonItem();
            this.bSup = new DevExpress.XtraBars.BarButtonItem();
            this.bCus = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bUsers = new DevExpress.XtraBars.BarButtonItem();
            this.bDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bQSell,
            this.bSell,
            this.bPurchase,
            this.bCat,
            this.bPrd,
            this.bSup,
            this.bCus,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.bUsers,
            this.bDatabase,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1097, 143);
            // 
            // bQSell
            // 
            this.bQSell.Caption = "Quick Sell";
            this.bQSell.Glyph = ((System.Drawing.Image)(resources.GetObject("bQSell.Glyph")));
            this.bQSell.Id = 1;
            this.bQSell.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bQSell.LargeGlyph")));
            this.bQSell.Name = "bQSell";
            this.bQSell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bQSell_ItemClick);
            // 
            // bSell
            // 
            this.bSell.Caption = "Sell";
            this.bSell.Glyph = ((System.Drawing.Image)(resources.GetObject("bSell.Glyph")));
            this.bSell.Id = 2;
            this.bSell.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bSell.LargeGlyph")));
            this.bSell.Name = "bSell";
            this.bSell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bSell_ItemClick);
            // 
            // bPurchase
            // 
            this.bPurchase.Caption = "Purchase";
            this.bPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("bPurchase.Glyph")));
            this.bPurchase.Id = 3;
            this.bPurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPurchase.LargeGlyph")));
            this.bPurchase.Name = "bPurchase";
            this.bPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPurchase_ItemClick);
            // 
            // bCat
            // 
            this.bCat.Caption = "Categories";
            this.bCat.Glyph = ((System.Drawing.Image)(resources.GetObject("bCat.Glyph")));
            this.bCat.Id = 4;
            this.bCat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bCat.LargeGlyph")));
            this.bCat.Name = "bCat";
            // 
            // bPrd
            // 
            this.bPrd.Caption = "Products";
            this.bPrd.Glyph = ((System.Drawing.Image)(resources.GetObject("bPrd.Glyph")));
            this.bPrd.Id = 5;
            this.bPrd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPrd.LargeGlyph")));
            this.bPrd.Name = "bPrd";
            // 
            // bSup
            // 
            this.bSup.Caption = "Suppliers";
            this.bSup.Glyph = ((System.Drawing.Image)(resources.GetObject("bSup.Glyph")));
            this.bSup.Id = 6;
            this.bSup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bSup.LargeGlyph")));
            this.bSup.Name = "bSup";
            // 
            // bCus
            // 
            this.bCus.Caption = "Customers";
            this.bCus.Glyph = ((System.Drawing.Image)(resources.GetObject("bCus.Glyph")));
            this.bCus.Id = 7;
            this.bCus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bCus.LargeGlyph")));
            this.bCus.Name = "bCus";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 11;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 12;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // bUsers
            // 
            this.bUsers.Caption = "Users";
            this.bUsers.Id = 13;
            this.bUsers.Name = "bUsers";
            // 
            // bDatabase
            // 
            this.bDatabase.Caption = "Database";
            this.bDatabase.Id = 14;
            this.bDatabase.Name = "bDatabase";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 15;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bQSell);
            this.ribbonPageGroup1.ItemLinks.Add(this.bSell);
            this.ribbonPageGroup1.ItemLinks.Add(this.bPurchase, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Sales";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bCat);
            this.ribbonPageGroup2.ItemLinks.Add(this.bPrd);
            this.ribbonPageGroup2.ItemLinks.Add(this.bSup);
            this.ribbonPageGroup2.ItemLinks.Add(this.bCus);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Stocks";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Reports";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Settings";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bUsers);
            this.ribbonPageGroup4.ItemLinks.Add(this.bDatabase);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Settings";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Theme";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 752);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bQSell;
        private DevExpress.XtraBars.BarButtonItem bSell;
        private DevExpress.XtraBars.BarButtonItem bPurchase;
        private DevExpress.XtraBars.BarButtonItem bCat;
        private DevExpress.XtraBars.BarButtonItem bPrd;
        private DevExpress.XtraBars.BarButtonItem bSup;
        private DevExpress.XtraBars.BarButtonItem bCus;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem bUsers;
        private DevExpress.XtraBars.BarButtonItem bDatabase;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

