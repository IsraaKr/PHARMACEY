namespace PhamaceySystem.Forms.Store_Forms
{
    partial class F_Store_places
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
            this.txt_group = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_shuffel = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_shuffel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Size = new System.Drawing.Size(720, 611);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_shuffel);
            this.dataLayoutControl1.Controls.Add(this.txt_group);
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Size = new System.Drawing.Size(720, 611);
            this.dataLayoutControl1.Controls.SetChildIndex(this.txt_name, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.txt_id, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.txt_group, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.txt_shuffel, 0);
            // 
            // txt_id
            // 
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(617, 22);
            this.txt_id.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Size = new System.Drawing.Size(617, 22);
            this.txt_name.TabIndex = 0;
            // 
            // txt
            // 
            this.txt.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.AppearanceItemCaption.Options.UseFont = true;
            this.txt.Size = new System.Drawing.Size(690, 42);
            this.txt.TextSize = new System.Drawing.Size(41, 18);
            // 
            // lbl_tiltle
            // 
            this.lbl_tiltle.Size = new System.Drawing.Size(720, 56);
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(370, 117);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(272, 22);
            this.txt_group.StyleController = this.dataLayoutControl1;
            this.txt_group.TabIndex = 2;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_group;
            this.layoutControlItem1.Location = new System.Drawing.Point(345, 92);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(345, 42);
            this.layoutControlItem1.Text = "المجموعة";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 15);
            // 
            // txt_shuffel
            // 
            this.txt_shuffel.Location = new System.Drawing.Point(25, 117);
            this.txt_shuffel.Name = "txt_shuffel";
            this.txt_shuffel.Size = new System.Drawing.Size(272, 22);
            this.txt_shuffel.StyleController = this.dataLayoutControl1;
            this.txt_shuffel.TabIndex = 3;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_shuffel;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(345, 42);
            this.layoutControlItem2.Text = "الرف";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(41, 15);
            // 
            // F_Store_places
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Name = "F_Store_places";
            this.Text = "F_Store_places";
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_shuffel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txt_group;
        private DevExpress.XtraEditors.TextEdit txt_shuffel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}