namespace PhamaceySystem
{
    partial class F_Master_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Master_ADD));
            this.timer_states_bar = new System.Windows.Forms.Timer(this.components);
            this.lbl_tiltle = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barr_save = new DevExpress.XtraBars.BarButtonItem();
            this.bar_edite = new DevExpress.XtraBars.BarButtonItem();
            this.bar_delete = new DevExpress.XtraBars.BarButtonItem();
            this.bar_clear = new DevExpress.XtraBars.BarButtonItem();
            this.barr_search = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar_3 = new DevExpress.XtraBars.BarStaticItem();
            this.bar_states = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_addd = new DevExpress.XtraEditors.TextEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txt_add = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_add1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bar_close = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_addd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_add1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_states_bar
            // 
            this.timer_states_bar.Interval = 10000;
            // 
            // lbl_tiltle
            // 
            this.lbl_tiltle.BackColor = System.Drawing.Color.OliveDrab;
            this.lbl_tiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_tiltle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiltle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tiltle.Location = new System.Drawing.Point(0, 24);
            this.lbl_tiltle.Name = "lbl_tiltle";
            this.lbl_tiltle.Size = new System.Drawing.Size(487, 55);
            this.lbl_tiltle.TabIndex = 6;
            this.lbl_tiltle.Text = "....";
            this.lbl_tiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barr_save,
            this.bar_edite,
            this.bar_delete,
            this.bar_clear,
            this.bar_3,
            this.bar_states,
            this.barr_search,
            this.bar_close});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Disabled.Options.UseFont = true;
            this.bar3.BarAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Hovered.Options.UseFont = true;
            this.bar3.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Normal.Options.UseFont = true;
            this.bar3.BarAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Pressed.Options.UseFont = true;
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barr_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_edite),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_clear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barr_search),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_close)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barr_save
            // 
            this.barr_save.Caption = "حفظ";
            this.barr_save.Id = 0;
            this.barr_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barr_save.ImageOptions.Image")));
            this.barr_save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barr_save.ImageOptions.LargeImage")));
            this.barr_save.Name = "barr_save";
            this.barr_save.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barr_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barr_save_ItemClick);
            // 
            // bar_edite
            // 
            this.bar_edite.Caption = "تعديل";
            this.bar_edite.Id = 1;
            this.bar_edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_edite.ImageOptions.Image")));
            this.bar_edite.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_edite.ImageOptions.LargeImage")));
            this.bar_edite.Name = "bar_edite";
            this.bar_edite.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_edite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_edite_ItemClick);
            // 
            // bar_delete
            // 
            this.bar_delete.Caption = "حذف";
            this.bar_delete.Id = 2;
            this.bar_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_delete.ImageOptions.Image")));
            this.bar_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_delete.ImageOptions.LargeImage")));
            this.bar_delete.Name = "bar_delete";
            this.bar_delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_delete_ItemClick);
            // 
            // bar_clear
            // 
            this.bar_clear.Caption = "مسح";
            this.bar_clear.Id = 3;
            this.bar_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_clear.ImageOptions.Image")));
            this.bar_clear.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_clear.ImageOptions.LargeImage")));
            this.bar_clear.Name = "bar_clear";
            this.bar_clear.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_clear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_clear_ItemClick);
            // 
            // barr_search
            // 
            this.barr_search.Caption = "بحث";
            this.barr_search.Id = 10;
            this.barr_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barr_search.ImageOptions.Image")));
            this.barr_search.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barr_search.ImageOptions.LargeImage")));
            this.barr_search.Name = "barr_search";
            this.barr_search.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barr_search.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barr_search_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_3),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_states)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // bar_3
            // 
            this.bar_3.Id = 9;
            this.bar_3.Name = "bar_3";
            // 
            // bar_states
            // 
            this.bar_states.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.bar_states.Caption = "...";
            this.bar_states.Id = 0;
            this.bar_states.Name = "bar_states";
            this.bar_states.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(487, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 359);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(487, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 335);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(487, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 335);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gc);
            this.dataLayoutControl1.Controls.Add(this.txt_addd);
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 79);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(487, 280);
            this.dataLayoutControl1.TabIndex = 11;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(17, 59);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(453, 162);
            this.gc.TabIndex = 12;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gv.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv.Appearance.HeaderPanel.Options.UseFont = true;
            this.gv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv.Appearance.Row.Options.UseTextOptions = true;
            this.gv.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv.GridControl = this.gc;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gv.OptionsSelection.MultiSelect = true;
            this.gv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv.OptionsView.EnableAppearanceEvenRow = true;
            this.gv.OptionsView.ShowAutoFilterRow = true;
            this.gv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_KeyDown);
            this.gv.DoubleClick += new System.EventHandler(this.gv_DoubleClick);
            // 
            // txt_addd
            // 
            this.txt_addd.Location = new System.Drawing.Point(25, 25);
            this.txt_addd.Margin = new System.Windows.Forms.Padding(5);
            this.txt_addd.MenuManager = this.barManager1;
            this.txt_addd.Name = "txt_addd";
            this.txt_addd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addd.Properties.Appearance.Options.UseFont = true;
            this.txt_addd.Properties.Padding = new System.Windows.Forms.Padding(-1);
            this.txt_addd.Size = new System.Drawing.Size(384, 22);
            this.txt_addd.StyleController = this.dataLayoutControl1;
            this.txt_addd.TabIndex = 4;
            this.txt_addd.EditValueChanged += new System.EventHandler(this.txt_addd_EditValueChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(25, 233);
            this.txt_id.Margin = new System.Windows.Forms.Padding(5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Properties.Padding = new System.Windows.Forms.Padding(-1);
            this.txt_id.Size = new System.Drawing.Size(384, 22);
            this.txt_id.StyleController = this.dataLayoutControl1;
            this.txt_id.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txt_add,
            this.layoutControlItem2,
            this.txt_add1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.Root.Size = new System.Drawing.Size(487, 280);
            this.Root.TextVisible = false;
            // 
            // txt_add
            // 
            this.txt_add.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add.AppearanceItemCaption.Options.UseFont = true;
            this.txt_add.Control = this.txt_addd;
            this.txt_add.Location = new System.Drawing.Point(0, 0);
            this.txt_add.Name = "txt_add";
            this.txt_add.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.txt_add.Size = new System.Drawing.Size(457, 42);
            this.txt_add.TextSize = new System.Drawing.Size(50, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gc;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(457, 166);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // txt_add1
            // 
            this.txt_add1.Control = this.txt_id;
            this.txt_add1.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.txt_add1.CustomizationFormText = "txt_add";
            this.txt_add1.Location = new System.Drawing.Point(0, 208);
            this.txt_add1.Name = "txt_add1";
            this.txt_add1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.txt_add1.Size = new System.Drawing.Size(457, 42);
            this.txt_add1.Text = "txt_add";
            this.txt_add1.TextSize = new System.Drawing.Size(50, 13);
            this.txt_add1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // bar_close
            // 
            this.bar_close.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bar_close.Id = 11;
            this.bar_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.bar_close.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.bar_close.Name = "bar_close";
            this.bar_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_close_ItemClick);
            // 
            // F_Master_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 381);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.lbl_tiltle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Master_ADD";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Master_ADD";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Master_ADD_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_addd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_add1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_states_bar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        public DevExpress.XtraBars.BarButtonItem barr_save;
        public DevExpress.XtraBars.BarButtonItem bar_edite;
        public DevExpress.XtraBars.BarButtonItem bar_delete;
        public DevExpress.XtraBars.BarButtonItem bar_clear;
        private DevExpress.XtraBars.BarButtonItem barr_search;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarStaticItem bar_3;
        public DevExpress.XtraBars.BarStaticItem bar_states;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlItem txt_add;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        public System.Windows.Forms.Label lbl_tiltle;
        public DevExpress.XtraGrid.GridControl gc;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        public DevExpress.XtraEditors.TextEdit txt_addd;
        public DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlItem txt_add1;
        public DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraBars.BarButtonItem bar_close;
    }
}