namespace PhamaceySystem
{
    partial class F_Master_Inheretanz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Master_Inheretanz));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barr_save = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_edite = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_delete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_clear = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_print = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar_3 = new DevExpress.XtraBars.BarStaticItem();
            this.bar_states = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.timer_states_bar = new System.Windows.Forms.Timer(this.components);
            this.lbl_tiltle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
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
            this.bar_print,
            this.bar_states,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 14;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Disabled.Options.UseFont = true;
            this.bar3.BarAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Hovered.Options.UseFont = true;
            this.bar3.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Normal.Options.UseFont = true;
            this.bar3.BarAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.BarAppearance.Pressed.Options.UseFont = true;
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barr_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_edite),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_clear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bar_print, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barr_save
            // 
            this.barr_save.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.barr_save.Caption = "حفظ";
            this.barr_save.Id = 0;
            this.barr_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barr_save.ImageOptions.Image")));
            this.barr_save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barr_save.ImageOptions.LargeImage")));
            this.barr_save.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barr_save.ItemAppearance.Disabled.Options.UseFont = true;
            this.barr_save.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barr_save.ItemAppearance.Hovered.Options.UseFont = true;
            this.barr_save.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barr_save.ItemAppearance.Normal.Options.UseFont = true;
            this.barr_save.ItemAppearance.Pressed.BackColor = System.Drawing.Color.DarkSalmon;
            this.barr_save.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barr_save.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barr_save.ItemAppearance.Pressed.Options.UseFont = true;
            this.barr_save.Name = "barr_save";
            this.barr_save.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barr_save.Size = new System.Drawing.Size(75, 35);
            this.barr_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barr_save_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar_edite
            // 
            this.bar_edite.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bar_edite.Caption = "تعديل";
            this.bar_edite.Id = 1;
            this.bar_edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_edite.ImageOptions.Image")));
            this.bar_edite.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_edite.ImageOptions.LargeImage")));
            this.bar_edite.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_edite.ItemAppearance.Disabled.Options.UseFont = true;
            this.bar_edite.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_edite.ItemAppearance.Hovered.Options.UseFont = true;
            this.bar_edite.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_edite.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_edite.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_edite.ItemAppearance.Pressed.Options.UseFont = true;
            this.bar_edite.Name = "bar_edite";
            this.bar_edite.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_edite.Size = new System.Drawing.Size(75, 30);
            this.bar_edite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_edite_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bar_delete
            // 
            this.bar_delete.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bar_delete.Caption = "حذف";
            this.bar_delete.Id = 2;
            this.bar_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_delete.ImageOptions.Image")));
            this.bar_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_delete.ImageOptions.LargeImage")));
            this.bar_delete.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_delete.ItemAppearance.Disabled.Options.UseFont = true;
            this.bar_delete.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_delete.ItemAppearance.Hovered.Options.UseFont = true;
            this.bar_delete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_delete.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_delete.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_delete.ItemAppearance.Pressed.Options.UseFont = true;
            this.bar_delete.Name = "bar_delete";
            this.bar_delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_delete.Size = new System.Drawing.Size(75, 30);
            this.bar_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_delete_ItemClick_1);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bar_clear
            // 
            this.bar_clear.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bar_clear.Caption = "مسح";
            this.bar_clear.Id = 3;
            this.bar_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_clear.ImageOptions.Image")));
            this.bar_clear.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_clear.ImageOptions.LargeImage")));
            this.bar_clear.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_clear.ItemAppearance.Disabled.Options.UseFont = true;
            this.bar_clear.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_clear.ItemAppearance.Hovered.Options.UseFont = true;
            this.bar_clear.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_clear.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_clear.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_clear.ItemAppearance.Pressed.Options.UseFont = true;
            this.bar_clear.Name = "bar_clear";
            this.bar_clear.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bar_clear.Size = new System.Drawing.Size(75, 30);
            this.bar_clear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_clear_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bar_print
            // 
            this.bar_print.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bar_print.Caption = "طباعة";
            this.bar_print.Id = 7;
            this.bar_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_print.ImageOptions.Image")));
            this.bar_print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_print.ImageOptions.LargeImage")));
            this.bar_print.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_print.ItemAppearance.Disabled.Options.UseFont = true;
            this.bar_print.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_print.ItemAppearance.Hovered.Options.UseFont = true;
            this.bar_print.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_print.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_print.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bar_print.ItemAppearance.Pressed.Options.UseFont = true;
            this.bar_print.Name = "bar_print";
            this.bar_print.Size = new System.Drawing.Size(80, 30);
            this.bar_print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_print_ItemClick_1);
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
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 392);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 58);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 392);
            // 
            // timer_states_bar
            // 
            this.timer_states_bar.Interval = 10000;
            this.timer_states_bar.Tick += new System.EventHandler(this.timer_states_bar_Tick_1);
            // 
            // lbl_tiltle
            // 
            this.lbl_tiltle.BackColor = System.Drawing.Color.Orange;
            this.lbl_tiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_tiltle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiltle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tiltle.Location = new System.Drawing.Point(0, 0);
            this.lbl_tiltle.Name = "lbl_tiltle";
            this.lbl_tiltle.Size = new System.Drawing.Size(800, 58);
            this.lbl_tiltle.TabIndex = 5;
            this.lbl_tiltle.Text = "....";
            this.lbl_tiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Master_Inheretanz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_tiltle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Master_Inheretanz";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Master_Inheretanz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Master_Inheretanz_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Master_Inheretanz_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        public DevExpress.XtraBars.BarButtonItem barr_save;
        public DevExpress.XtraBars.BarButtonItem bar_edite;
        public DevExpress.XtraBars.BarButtonItem bar_delete;
        public DevExpress.XtraBars.BarButtonItem bar_clear;
        public DevExpress.XtraBars.BarButtonItem bar_print;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarStaticItem bar_3;
        public DevExpress.XtraBars.BarStaticItem bar_states;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Timer timer_states_bar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.Label lbl_tiltle;
    }
}