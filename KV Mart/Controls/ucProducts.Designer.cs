namespace KVM.Controls
{
    partial class ucProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProducts));
            this.rcProducts = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDel = new DevExpress.XtraBars.BarButtonItem();
            this.bRptProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCAT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPKG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMFG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgCol = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCol)).BeginInit();
            this.SuspendLayout();
            // 
            // rcProducts
            // 
            this.rcProducts.ExpandCollapseItem.Id = 0;
            this.rcProducts.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcProducts.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.bDel,
            this.bRptProducts,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.rcProducts.Location = new System.Drawing.Point(0, 0);
            this.rcProducts.MaxItemId = 9;
            this.rcProducts.Name = "rcProducts";
            this.rcProducts.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.rcProducts.Size = new System.Drawing.Size(1072, 141);
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
            // bDel
            // 
            this.bDel.Caption = "&Delete";
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 3;
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.Name = "bDel";
            this.bDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDel_ItemClick);
            // 
            // bRptProducts
            // 
            this.bRptProducts.Caption = "Product List";
            this.bRptProducts.Id = 4;
            this.bRptProducts.Name = "bRptProducts";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Expiring Products";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Daily Sales";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Monthly Sales";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Yearly Sales";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Products";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bRptProducts);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Reports";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Charts";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.rcProducts;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCAT});
            this.grd.Size = new System.Drawing.Size(1072, 464);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPID,
            this.colCAT,
            this.colSCT,
            this.colCMP,
            this.colPNM,
            this.colPKG,
            this.colBVL,
            this.colSVL,
            this.colMFG,
            this.colEXP,
            this.colQTY,
            this.colBCD,
            this.colHSN,
            this.colTAX});
            this.grv.GridControl = this.grd;
            this.grv.GroupCount = 1;
            this.grv.Name = "grv";
            this.grv.OptionsBehavior.AutoExpandAllGroups = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCAT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grv.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grv_RowStyle);
            this.grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.grv_PopupMenuShowing);
            // 
            // colPID
            // 
            this.colPID.Caption = "gridColumn1";
            this.colPID.FieldName = "ID";
            this.colPID.Name = "colPID";
            this.colPID.OptionsColumn.AllowEdit = false;
            this.colPID.OptionsColumn.AllowFocus = false;
            this.colPID.OptionsColumn.ReadOnly = true;
            // 
            // colCAT
            // 
            this.colCAT.Caption = "Category";
            this.colCAT.ColumnEdit = this.repCAT;
            this.colCAT.FieldName = "Category";
            this.colCAT.Name = "colCAT";
            this.colCAT.OptionsColumn.AllowEdit = false;
            this.colCAT.OptionsColumn.AllowFocus = false;
            this.colCAT.OptionsColumn.ReadOnly = true;
            this.colCAT.Visible = true;
            this.colCAT.VisibleIndex = 0;
            // 
            // repCAT
            // 
            this.repCAT.AutoHeight = false;
            this.repCAT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCAT.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category")});
            this.repCAT.Name = "repCAT";
            // 
            // colSCT
            // 
            this.colSCT.Caption = "Sub-Category";
            this.colSCT.FieldName = "SubCategory";
            this.colSCT.Name = "colSCT";
            this.colSCT.OptionsColumn.AllowEdit = false;
            this.colSCT.OptionsColumn.AllowFocus = false;
            this.colSCT.OptionsColumn.ReadOnly = true;
            this.colSCT.Visible = true;
            this.colSCT.VisibleIndex = 0;
            // 
            // colCMP
            // 
            this.colCMP.Caption = "Company";
            this.colCMP.FieldName = "Company";
            this.colCMP.Name = "colCMP";
            this.colCMP.OptionsColumn.AllowEdit = false;
            this.colCMP.OptionsColumn.AllowFocus = false;
            this.colCMP.OptionsColumn.ReadOnly = true;
            this.colCMP.Visible = true;
            this.colCMP.VisibleIndex = 1;
            // 
            // colPNM
            // 
            this.colPNM.Caption = "Product Name";
            this.colPNM.FieldName = "ProductName";
            this.colPNM.Name = "colPNM";
            this.colPNM.OptionsColumn.AllowEdit = false;
            this.colPNM.OptionsColumn.AllowFocus = false;
            this.colPNM.OptionsColumn.ReadOnly = true;
            this.colPNM.Visible = true;
            this.colPNM.VisibleIndex = 2;
            // 
            // colPKG
            // 
            this.colPKG.Caption = "Pkg. Size";
            this.colPKG.FieldName = "PackageSize";
            this.colPKG.Name = "colPKG";
            this.colPKG.OptionsColumn.AllowEdit = false;
            this.colPKG.OptionsColumn.AllowFocus = false;
            this.colPKG.OptionsColumn.ReadOnly = true;
            this.colPKG.Visible = true;
            this.colPKG.VisibleIndex = 3;
            // 
            // colBVL
            // 
            this.colBVL.Caption = "Buying Value";
            this.colBVL.FieldName = "BuyingValue";
            this.colBVL.Name = "colBVL";
            this.colBVL.OptionsColumn.AllowEdit = false;
            this.colBVL.OptionsColumn.AllowFocus = false;
            this.colBVL.OptionsColumn.ReadOnly = true;
            this.colBVL.Visible = true;
            this.colBVL.VisibleIndex = 4;
            // 
            // colSVL
            // 
            this.colSVL.Caption = "Selling Value";
            this.colSVL.FieldName = "SellingValue";
            this.colSVL.Name = "colSVL";
            this.colSVL.OptionsColumn.AllowEdit = false;
            this.colSVL.OptionsColumn.AllowFocus = false;
            this.colSVL.OptionsColumn.ReadOnly = true;
            this.colSVL.Visible = true;
            this.colSVL.VisibleIndex = 5;
            // 
            // colMFG
            // 
            this.colMFG.Caption = "Mfg. Date";
            this.colMFG.FieldName = "MfgDate";
            this.colMFG.Name = "colMFG";
            this.colMFG.OptionsColumn.AllowEdit = false;
            this.colMFG.OptionsColumn.AllowFocus = false;
            this.colMFG.OptionsColumn.ReadOnly = true;
            this.colMFG.Visible = true;
            this.colMFG.VisibleIndex = 6;
            // 
            // colEXP
            // 
            this.colEXP.Caption = "Exp. Date";
            this.colEXP.FieldName = "ExpDate";
            this.colEXP.Name = "colEXP";
            this.colEXP.OptionsColumn.AllowEdit = false;
            this.colEXP.OptionsColumn.AllowFocus = false;
            this.colEXP.OptionsColumn.ReadOnly = true;
            this.colEXP.Visible = true;
            this.colEXP.VisibleIndex = 7;
            // 
            // colQTY
            // 
            this.colQTY.Caption = "Quantity";
            this.colQTY.FieldName = "Quantity";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.AllowFocus = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 8;
            // 
            // colBCD
            // 
            this.colBCD.Caption = "BarCode";
            this.colBCD.FieldName = "BarCode";
            this.colBCD.Name = "colBCD";
            this.colBCD.OptionsColumn.AllowEdit = false;
            this.colBCD.OptionsColumn.AllowFocus = false;
            this.colBCD.OptionsColumn.ReadOnly = true;
            this.colBCD.Visible = true;
            this.colBCD.VisibleIndex = 9;
            // 
            // colHSN
            // 
            this.colHSN.Caption = "HSN/SAC";
            this.colHSN.FieldName = "HSN";
            this.colHSN.Name = "colHSN";
            this.colHSN.OptionsColumn.AllowEdit = false;
            this.colHSN.OptionsColumn.AllowFocus = false;
            this.colHSN.OptionsColumn.ReadOnly = true;
            this.colHSN.Visible = true;
            this.colHSN.VisibleIndex = 10;
            // 
            // colTAX
            // 
            this.colTAX.Caption = "Tax Rate";
            this.colTAX.FieldName = "TaxRate";
            this.colTAX.Name = "colTAX";
            this.colTAX.OptionsColumn.AllowEdit = false;
            this.colTAX.OptionsColumn.AllowFocus = false;
            this.colTAX.OptionsColumn.ReadOnly = true;
            this.colTAX.Visible = true;
            this.colTAX.VisibleIndex = 11;
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
            this.imgCol.InsertGalleryImage("report_16x16.png", "office2013/reports/report_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/reports/report_16x16.png"), 3);
            this.imgCol.Images.SetKeyName(3, "report_16x16.png");
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.rcProducts);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(1072, 605);
            ((System.ComponentModel.ISupportInitialize)(this.rcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colCAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSCT;
        private DevExpress.XtraGrid.Columns.GridColumn colCMP;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colPKG;
        private DevExpress.XtraGrid.Columns.GridColumn colBVL;
        private DevExpress.XtraGrid.Columns.GridColumn colSVL;
        private DevExpress.XtraGrid.Columns.GridColumn colMFG;
        private DevExpress.XtraGrid.Columns.GridColumn colEXP;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn colBCD;
        private DevExpress.XtraGrid.Columns.GridColumn colHSN;
        private DevExpress.XtraGrid.Columns.GridColumn colTAX;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCAT;
        public DevExpress.XtraBars.Ribbon.RibbonControl rcProducts;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDel;
        private DevExpress.XtraBars.BarButtonItem bRptProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.Utils.ImageCollection imgCol;
    }
}
