namespace Library_Mvp.veiws.formes
{
    partial class frm_Catogry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Catogry));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_first = new DevExpress.XtraEditors.SimpleButton();
            this.btn_next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_last = new DevExpress.XtraEditors.SimpleButton();
            this.btn_prev = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_removeall = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_data1 = new System.Windows.Forms.DataGridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الاماكن";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(53, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(161, 24);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المكان :";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_id.Location = new System.Drawing.Point(339, 41);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(139, 24);
            this.txt_id.TabIndex = 1;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(484, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم المكان :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_first);
            this.groupBox3.Controls.Add(this.btn_next);
            this.groupBox3.Controls.Add(this.btn_last);
            this.groupBox3.Controls.Add(this.btn_prev);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(231, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 83);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اسهم التنقل";
            // 
            // btn_first
            // 
            this.btn_first.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_first.Appearance.Options.UseBackColor = true;
            this.btn_first.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.ImageOptions.Image")));
            this.btn_first.Location = new System.Drawing.Point(10, 40);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(40, 23);
            this.btn_first.TabIndex = 8;
            // 
            // btn_next
            // 
            this.btn_next.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_next.Appearance.Options.UseBackColor = true;
            this.btn_next.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.ImageOptions.Image")));
            this.btn_next.Location = new System.Drawing.Point(102, 40);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(40, 23);
            this.btn_next.TabIndex = 7;
            // 
            // btn_last
            // 
            this.btn_last.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_last.Appearance.Options.UseBackColor = true;
            this.btn_last.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.ImageOptions.Image")));
            this.btn_last.Location = new System.Drawing.Point(148, 40);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(40, 23);
            this.btn_last.TabIndex = 5;
            // 
            // btn_prev
            // 
            this.btn_prev.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_prev.Appearance.Options.UseBackColor = true;
            this.btn_prev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.ImageOptions.Image")));
            this.btn_prev.Location = new System.Drawing.Point(56, 40);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(40, 23);
            this.btn_prev.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_removeall);
            this.groupBox2.Controls.Add(this.btn_new);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 97);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btn_save.Appearance.Font = new System.Drawing.Font("Droid Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseBackColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Appearance.Options.UseTextOptions = true;
            this.btn_save.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(247, 40);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(86, 33);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "حفظ";
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Appearance.Options.UseTextOptions = true;
            this.btn_delete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(339, 40);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delete.Size = new System.Drawing.Size(86, 33);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "حذف";
            // 
            // btn_add
            // 
            this.btn_add.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Droid Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseTextOptions = true;
            this.btn_add.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(155, 40);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add.Size = new System.Drawing.Size(86, 33);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "اضافة";
            // 
            // btn_removeall
            // 
            this.btn_removeall.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btn_removeall.Appearance.Font = new System.Drawing.Font("Droid Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeall.Appearance.Options.UseBackColor = true;
            this.btn_removeall.Appearance.Options.UseFont = true;
            this.btn_removeall.Appearance.Options.UseTextOptions = true;
            this.btn_removeall.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_removeall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeall.ImageOptions.Image")));
            this.btn_removeall.Location = new System.Drawing.Point(431, 40);
            this.btn_removeall.Name = "btn_removeall";
            this.btn_removeall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_removeall.Size = new System.Drawing.Size(109, 33);
            this.btn_removeall.TabIndex = 13;
            this.btn_removeall.Text = "حذف الكل";
            // 
            // btn_new
            // 
            this.btn_new.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btn_new.Appearance.Font = new System.Drawing.Font("Droid Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Appearance.Options.UseBackColor = true;
            this.btn_new.Appearance.Options.UseFont = true;
            this.btn_new.Appearance.Options.UseTextOptions = true;
            this.btn_new.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.Location = new System.Drawing.Point(63, 40);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(86, 33);
            this.btn_new.TabIndex = 11;
            this.btn_new.Text = "جديد";
            // 
            // dgv_data1
            // 
            this.dgv_data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data1.Location = new System.Drawing.Point(12, 326);
            this.dgv_data1.Name = "dgv_data1";
            this.dgv_data1.Size = new System.Drawing.Size(603, 173);
            this.dgv_data1.TabIndex = 10;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // frm_Catogry
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(613, 504);
            this.Controls.Add(this.dgv_data1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Doppio One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Catogry.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frm_Catogry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الارفف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btn_last;
        private DevExpress.XtraEditors.SimpleButton btn_first;
        private DevExpress.XtraEditors.SimpleButton btn_next;
        private DevExpress.XtraEditors.SimpleButton btn_prev;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_removeall;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private System.Windows.Forms.DataGridView dgv_data1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}