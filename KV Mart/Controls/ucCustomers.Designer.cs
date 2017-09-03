namespace KVM.Controls
{
    partial class ucCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomers));
            this.rcCustomer = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grdCus = new DevExpress.XtraGrid.GridControl();
            this.grvCus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCdt = new DevExpress.XtraGrid.GridControl();
            this.grvCdt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgCol = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCol)).BeginInit();
            this.SuspendLayout();
            // 
            // rcCustomer
            // 
            this.rcCustomer.ExpandCollapseItem.Id = 0;
            this.rcCustomer.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcCustomer.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.bDelete});
            this.rcCustomer.Location = new System.Drawing.Point(0, 0);
            this.rcCustomer.MaxItemId = 4;
            this.rcCustomer.Name = "rcCustomer";
            this.rcCustomer.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.rcCustomer.Size = new System.Drawing.Size(971, 141);
            // 
            // bNew
            // 
            this.bNew.Caption = "&New";
            this.bNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bNew.Glyph")));
            this.bNew.Id = 1;
            this.bNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNew.LargeGlyph")));
            this.bNew.Name = "bNew";
            this.bNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNew_ItemClick);
            // 
            // bEdit
            // 
            this.bEdit.Caption = "&Edit";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 2;
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            this.bEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bEdit_ItemClick);
            // 
            // bDelete
            // 
            this.bDelete.Caption = "&Delete";
            this.bDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("bDelete.Glyph")));
            this.bDelete.Id = 3;
            this.bDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDelete.LargeGlyph")));
            this.bDelete.Name = "bDelete";
            this.bDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDelete_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Customers";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 141);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grdCus);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdCdt);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(971, 527);
            this.splitContainerControl1.SplitterPosition = 469;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // grdCus
            // 
            this.grdCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCus.Location = new System.Drawing.Point(0, 0);
            this.grdCus.MainView = this.grvCus;
            this.grdCus.MenuManager = this.rcCustomer;
            this.grdCus.Name = "grdCus";
            this.grdCus.Size = new System.Drawing.Size(469, 527);
            this.grdCus.TabIndex = 0;
            this.grdCus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCus});
            // 
            // grvCus
            // 
            this.grvCus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCID,
            this.colCNM,
            this.colADR,
            this.colPHN});
            this.grvCus.GridControl = this.grdCus;
            this.grvCus.Name = "grvCus";
            this.grvCus.OptionsView.ShowGroupPanel = false;
            this.grvCus.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.grvCus_PopupMenuShowing);
            this.grvCus.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvCus_SelectionChanged);
            // 
            // colCID
            // 
            this.colCID.Caption = "ID";
            this.colCID.FieldName = "ID";
            this.colCID.Name = "colCID";
            this.colCID.OptionsColumn.AllowEdit = false;
            this.colCID.OptionsColumn.AllowFocus = false;
            this.colCID.OptionsColumn.ReadOnly = true;
            // 
            // colCNM
            // 
            this.colCNM.Caption = "Name";
            this.colCNM.FieldName = "CustomerName";
            this.colCNM.Name = "colCNM";
            this.colCNM.OptionsColumn.AllowEdit = false;
            this.colCNM.OptionsColumn.AllowFocus = false;
            this.colCNM.OptionsColumn.ReadOnly = true;
            this.colCNM.Visible = true;
            this.colCNM.VisibleIndex = 0;
            this.colCNM.Width = 189;
            // 
            // colADR
            // 
            this.colADR.Caption = "Address";
            this.colADR.FieldName = "Address";
            this.colADR.Name = "colADR";
            this.colADR.OptionsColumn.AllowEdit = false;
            this.colADR.OptionsColumn.AllowFocus = false;
            this.colADR.OptionsColumn.ReadOnly = true;
            this.colADR.Visible = true;
            this.colADR.VisibleIndex = 1;
            this.colADR.Width = 267;
            // 
            // colPHN
            // 
            this.colPHN.Caption = "Phone";
            this.colPHN.FieldName = "Phone";
            this.colPHN.Name = "colPHN";
            this.colPHN.OptionsColumn.AllowEdit = false;
            this.colPHN.OptionsColumn.AllowFocus = false;
            this.colPHN.OptionsColumn.ReadOnly = true;
            this.colPHN.Visible = true;
            this.colPHN.VisibleIndex = 2;
            this.colPHN.Width = 112;
            // 
            // grdCdt
            // 
            this.grdCdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCdt.Location = new System.Drawing.Point(0, 0);
            this.grdCdt.MainView = this.grvCdt;
            this.grdCdt.MenuManager = this.rcCustomer;
            this.grdCdt.Name = "grdCdt";
            this.grdCdt.Size = new System.Drawing.Size(497, 527);
            this.grdCdt.TabIndex = 0;
            this.grdCdt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCdt});
            // 
            // grvCdt
            // 
            this.grvCdt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTDT,
            this.colDSC,
            this.colDBA,
            this.colCDA,
            this.colBAL});
            this.grvCdt.GridControl = this.grdCdt;
            this.grvCdt.Name = "grvCdt";
            this.grvCdt.OptionsView.ShowGroupPanel = false;
            // 
            // colTDT
            // 
            this.colTDT.Caption = "Transaction Date";
            this.colTDT.FieldName = "TransDate";
            this.colTDT.GroupFormat.FormatString = "d";
            this.colTDT.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTDT.Name = "colTDT";
            this.colTDT.OptionsColumn.AllowEdit = false;
            this.colTDT.OptionsColumn.AllowFocus = false;
            this.colTDT.OptionsColumn.ReadOnly = true;
            this.colTDT.Visible = true;
            this.colTDT.VisibleIndex = 0;
            // 
            // colDSC
            // 
            this.colDSC.Caption = "Reference";
            this.colDSC.FieldName = "Description";
            this.colDSC.Name = "colDSC";
            this.colDSC.OptionsColumn.AllowEdit = false;
            this.colDSC.OptionsColumn.AllowFocus = false;
            this.colDSC.OptionsColumn.ReadOnly = true;
            this.colDSC.Visible = true;
            this.colDSC.VisibleIndex = 1;
            // 
            // colDBA
            // 
            this.colDBA.Caption = "Debit";
            this.colDBA.FieldName = "Debit";
            this.colDBA.Name = "colDBA";
            this.colDBA.OptionsColumn.AllowEdit = false;
            this.colDBA.OptionsColumn.AllowFocus = false;
            this.colDBA.OptionsColumn.ReadOnly = true;
            this.colDBA.Visible = true;
            this.colDBA.VisibleIndex = 2;
            // 
            // colCDA
            // 
            this.colCDA.Caption = "Credit";
            this.colCDA.FieldName = "Credit";
            this.colCDA.Name = "colCDA";
            this.colCDA.OptionsColumn.AllowEdit = false;
            this.colCDA.OptionsColumn.AllowFocus = false;
            this.colCDA.OptionsColumn.ReadOnly = true;
            this.colCDA.Visible = true;
            this.colCDA.VisibleIndex = 3;
            // 
            // colBAL
            // 
            this.colBAL.Caption = "Balance";
            this.colBAL.FieldName = "Balance";
            this.colBAL.Name = "colBAL";
            this.colBAL.OptionsColumn.AllowEdit = false;
            this.colBAL.OptionsColumn.AllowFocus = false;
            this.colBAL.OptionsColumn.ReadOnly = true;
            this.colBAL.Visible = true;
            this.colBAL.VisibleIndex = 4;
            // 
            // imgCol
            // 
            this.imgCol.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCol.ImageStream")));
            this.imgCol.InsertGalleryImage("new_16x16.png", "office2013/actions/new_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/new_16x16.png"), 0);
            this.imgCol.Images.SetKeyName(0, "new_16x16.png");
            this.imgCol.InsertGalleryImage("edit_16x16.png", "office2013/edit/edit_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/edit/edit_16x16.png"), 1);
            this.imgCol.Images.SetKeyName(1, "edit_16x16.png");
            this.imgCol.InsertGalleryImage("deletelist_16x16.png", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 2);
            this.imgCol.Images.SetKeyName(2, "deletelist_16x16.png");
            this.imgCol.InsertGalleryImage("report_16x16.png", "images/reports/report_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/report_16x16.png"), 3);
            this.imgCol.Images.SetKeyName(3, "report_16x16.png");
            // 
            // ucCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.rcCustomer);
            this.Name = "ucCustomers";
            this.Size = new System.Drawing.Size(971, 668);
            ((System.ComponentModel.ISupportInitialize)(this.rcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grdCus;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCus;
        private DevExpress.XtraGrid.Columns.GridColumn colCID;
        private DevExpress.XtraGrid.Columns.GridColumn colCNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colPHN;
        private DevExpress.XtraGrid.GridControl grdCdt;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCdt;
        private DevExpress.XtraGrid.Columns.GridColumn colTDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDSC;
        private DevExpress.XtraGrid.Columns.GridColumn colDBA;
        private DevExpress.XtraGrid.Columns.GridColumn colCDA;
        private DevExpress.XtraGrid.Columns.GridColumn colBAL;
        public DevExpress.XtraBars.Ribbon.RibbonControl rcCustomer;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDelete;
        private DevExpress.Utils.ImageCollection imgCol;
    }
}
