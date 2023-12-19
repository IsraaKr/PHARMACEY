namespace PhamaceySystem.Inheratenz_Forms
{
    partial class F_Master_Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Master_Grid));
            this.lbl_tiltle = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barr_save = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barr_edit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_close = new DevExpress.XtraBars.BarButtonItem();
            this.bar_delete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barr_print = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar_3 = new DevExpress.XtraBars.BarStaticItem();
            this.bar_states = new DevExpress.XtraBars.BarStaticItem();
            this.bar_time = new DevExpress.XtraBars.BarStaticItem();
            this.bar_date = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.timer_states_bar = new System.Windows.Forms.Timer(this.components);
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tiltle
            // 
            this.lbl_tiltle.BackColor = System.Drawing.Color.Orange;
            this.lbl_tiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_tiltle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiltle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tiltle.Location = new System.Drawing.Point(0, 0);
            this.lbl_tiltle.Name = "lbl_tiltle";
            this.lbl_tiltle.Size = new System.Drawing.Size(639, 55);
            this.lbl_tiltle.TabIndex = 13;
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
            this.bar_delete,
            this.bar_3,
            this.bar_states,
            this.bar_close,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barr_edit,
            this.barr_print,
            this.bar_time,
            this.bar_date,
            this.barStaticItem3});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 22;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 18F);
            this.bar3.BarAppearance.Disabled.Options.UseFont = true;
            this.bar3.BarAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 18F);
            this.bar3.BarAppearance.Hovered.Options.UseFont = true;
            this.bar3.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Normal.Options.UseFont = true;
            this.bar3.BarAppearance.Pressed.BackColor = System.Drawing.Color.Orange;
            this.bar3.BarAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 18F);
            this.bar3.BarAppearance.Pressed.ForeColor = System.Drawing.Color.White;
            this.bar3.BarAppearance.Pressed.Options.UseBackColor = true;
            this.bar3.BarAppearance.Pressed.Options.UseFont = true;
            this.bar3.BarAppearance.Pressed.Options.UseForeColor = true;
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.FloatLocation = new System.Drawing.Point(354, 290);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barr_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barr_edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_close),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barr_print),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barr_save
            // 
            this.barr_save.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.barr_save.Caption = "إضافة";
            this.barr_save.Id = 0;
            this.barr_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barr_save.ImageOptions.Image")));
            this.barr_save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barr_save.ImageOptions.LargeImage")));
            this.barr_save.Name = "barr_save";
            this.barr_save.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barr_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barr_save_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barr_edit
            // 
            this.barr_edit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.barr_edit.Caption = "تعديل";
            this.barr_edit.Id = 17;
            this.barr_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barr_edit.ImageOptions.Image")));
            this.barr_edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barr_edit.ImageOptions.LargeImage")));
            this.barr_edit.Name = "barr_edit";
            this.barr_edit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barr_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barr_edit_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar_close
            // 
            this.bar_close.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bar_close.Id = 11;
            this.bar_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_close.ImageOptions.Image")));
            this.bar_close.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_close.ImageOptions.LargeImage")));
            this.bar_close.Name = "bar_close";
            this.bar_close.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.bar_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_close_ItemClick);
            // 
            // bar_delete
            // 
            this.bar_delete.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bar_delete.Caption = "حذف";
            this.bar_delete.Id = 3;
            this.bar_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_delete.ImageOptions.Image")));
            this.bar_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_delete.ImageOptions.LargeImage")));
            this.bar_delete.Name = "bar_delete";
            this.bar_delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_clear_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barr_print
            // 
            this.barr_print.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.barr_print.Caption = "طباعة و تصدير ";
            this.barr_print.Id = 18;
            this.barr_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barr_print.ImageOptions.Image")));
            this.barr_print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barr_print.ImageOptions.LargeImage")));
            this.barr_print.Name = "barr_print";
            this.barr_print.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barr_print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barr_print_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 16;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bar4
            // 
            this.bar4.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar4.BarAppearance.Normal.Options.UseFont = true;
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_3),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_states),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_date),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_time)});
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
            // bar_time
            // 
            this.bar_time.Caption = "..";
            this.bar_time.Id = 19;
            this.bar_time.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.ImageOptions.Image")));
            this.bar_time.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.ImageOptions.LargeImage")));
            this.bar_time.Name = "bar_time";
            this.bar_time.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar_date
            // 
            this.bar_date.Caption = "..";
            this.bar_date.Id = 20;
            this.bar_date.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.ImageOptions.Image")));
            this.bar_date.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.ImageOptions.LargeImage")));
            this.bar_date.Name = "bar_date";
            this.bar_date.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "..";
            this.barStaticItem3.Id = 21;
            this.barStaticItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem3.ImageOptions.Image")));
            this.barStaticItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem3.ImageOptions.LargeImage")));
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(639, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(639, 69);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 589);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(639, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 589);
            // 
            // timer_states_bar
            // 
            this.timer_states_bar.Interval = 10000;
            this.timer_states_bar.Tick += new System.EventHandler(this.timer_states_bar_Tick);
            // 
            // timer_date
            // 
            this.timer_date.Tick += new System.EventHandler(this.timer_date_Tick);
            // 
            // F_Master_Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 658);
            this.Controls.Add(this.lbl_tiltle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Master_Grid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Master_Grid";
            this.Load += new System.EventHandler(this.F_Master_Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_tiltle;
        private DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        public DevExpress.XtraBars.BarButtonItem bar_delete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.BarButtonItem barr_save;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bar_close;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarStaticItem bar_3;
        public DevExpress.XtraBars.BarStaticItem bar_states;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Timer timer_states_bar;
        private DevExpress.XtraBars.BarButtonItem barr_edit;
        private DevExpress.XtraBars.BarButtonItem barr_print;
        private DevExpress.XtraBars.BarStaticItem bar_time;
        private DevExpress.XtraBars.BarStaticItem bar_date;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private System.Windows.Forms.Timer timer_date;
    }
}