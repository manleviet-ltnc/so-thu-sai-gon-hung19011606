namespace SOTHUXIGON
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstthumoi = new System.Windows.Forms.ListBox();
            this.lstdanhsachmoi = new System.Windows.Forms.ListBox();
            this.btnchon = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thú mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách thú";
            // 
            // lstthumoi
            // 
            this.lstthumoi.AllowDrop = true;
            this.lstthumoi.FormattingEnabled = true;
            this.lstthumoi.ItemHeight = 16;
            this.lstthumoi.Items.AddRange(new object[] {
            "chó",
            "mèo",
            "khỉ",
            "sư tử",
            "báo",
            "trăn"});
            this.lstthumoi.Location = new System.Drawing.Point(29, 57);
            this.lstthumoi.Name = "lstthumoi";
            this.lstthumoi.Size = new System.Drawing.Size(196, 196);
            this.lstthumoi.TabIndex = 2;
            this.toolTip1.SetToolTip(this.lstthumoi, "ấn chuột và kéo sang danh sách thú để tạo sở thú");
            this.lstthumoi.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstdanhsachmoi_DragDrop);
            this.lstthumoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstthumoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lstdanhsachmoi
            // 
            this.lstdanhsachmoi.AllowDrop = true;
            this.lstdanhsachmoi.FormattingEnabled = true;
            this.lstdanhsachmoi.ItemHeight = 16;
            this.lstdanhsachmoi.Location = new System.Drawing.Point(476, 57);
            this.lstdanhsachmoi.Name = "lstdanhsachmoi";
            this.lstdanhsachmoi.Size = new System.Drawing.Size(197, 196);
            this.lstdanhsachmoi.TabIndex = 3;
            this.lstdanhsachmoi.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstdanhsachmoi_DragDrop);
            this.lstdanhsachmoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstdanhsachmoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // btnchon
            // 
            this.btnchon.Location = new System.Drawing.Point(318, 118);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(75, 23);
            this.btnchon.TabIndex = 4;
            this.btnchon.Text = "chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "ấn chuột và kéo sang danh sách thú để tạo sở thú";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 299);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.lstdanhsachmoi);
            this.Controls.Add(this.lstthumoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "So Thu Xi Gon";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstdanhsachmoi_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstthumoi;
        private System.Windows.Forms.ListBox lstdanhsachmoi;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

