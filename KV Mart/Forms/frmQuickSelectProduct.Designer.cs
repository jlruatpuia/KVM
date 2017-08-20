namespace KVM.Forms
{
    partial class frmQuickSelectProduct
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
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSVL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 0);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(491, 149);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPID,
            this.colCMP,
            this.colPNM,
            this.colHSN,
            this.colSVL});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grv_KeyDown);
            this.grv.DoubleClick += new System.EventHandler(this.grv_DoubleClick);
            // 
            // colPID
            // 
            this.colPID.FieldName = "ID";
            this.colPID.Name = "colPID";
            this.colPID.OptionsColumn.AllowEdit = false;
            this.colPID.OptionsColumn.AllowFocus = false;
            this.colPID.OptionsColumn.ReadOnly = true;
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
            this.colCMP.VisibleIndex = 0;
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
            this.colPNM.VisibleIndex = 1;
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
            this.colHSN.VisibleIndex = 2;
            // 
            // colSVL
            // 
            this.colSVL.Caption = "Rate";
            this.colSVL.FieldName = "SellingValue";
            this.colSVL.Name = "colSVL";
            this.colSVL.OptionsColumn.AllowEdit = false;
            this.colSVL.OptionsColumn.AllowFocus = false;
            this.colSVL.OptionsColumn.ReadOnly = true;
            this.colSVL.Visible = true;
            this.colSVL.VisibleIndex = 3;
            // 
            // frmQuickSelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 149);
            this.Controls.Add(this.grd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuickSelectProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Product";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colCMP;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colHSN;
        private DevExpress.XtraGrid.Columns.GridColumn colSVL;
    }
}