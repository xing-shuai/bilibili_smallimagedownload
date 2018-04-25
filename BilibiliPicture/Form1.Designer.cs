namespace BilibiliPicture
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bro_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.checkpic_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pause_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalcount_label = new System.Windows.Forms.Label();
            this.currentdownloadcount_label = new System.Windows.Forms.Label();
            this.open_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(12, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(425, 171);
            this.textBox1.TabIndex = 0;
            // 
            // bro_button
            // 
            this.bro_button.Location = new System.Drawing.Point(46, 12);
            this.bro_button.Name = "bro_button";
            this.bro_button.Size = new System.Drawing.Size(75, 23);
            this.bro_button.TabIndex = 1;
            this.bro_button.Text = "下载位置";
            this.bro_button.UseVisualStyleBackColor = true;
            this.bro_button.Click += new System.EventHandler(this.bro_button_Click);
            // 
            // start_button
            // 
            this.start_button.Enabled = false;
            this.start_button.Location = new System.Drawing.Point(46, 41);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "开始下载";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(46, 99);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 3;
            this.stop_button.Text = "终止下载";
            this.stop_button.UseVisualStyleBackColor = true;
            // 
            // checkpic_button
            // 
            this.checkpic_button.Enabled = false;
            this.checkpic_button.Location = new System.Drawing.Point(46, 128);
            this.checkpic_button.Name = "checkpic_button";
            this.checkpic_button.Size = new System.Drawing.Size(75, 23);
            this.checkpic_button.TabIndex = 4;
            this.checkpic_button.Text = "浏览图片";
            this.checkpic_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(171, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pause_button
            // 
            this.pause_button.Enabled = false;
            this.pause_button.Location = new System.Drawing.Point(46, 70);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(75, 23);
            this.pause_button.TabIndex = 6;
            this.pause_button.Text = "暂停下载";
            this.pause_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "当前文件夹下图片数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "本次下载下图片数:";
            // 
            // totalcount_label
            // 
            this.totalcount_label.AutoSize = true;
            this.totalcount_label.Location = new System.Drawing.Point(392, 41);
            this.totalcount_label.Name = "totalcount_label";
            this.totalcount_label.Size = new System.Drawing.Size(23, 12);
            this.totalcount_label.TabIndex = 10;
            this.totalcount_label.Text = "100";
            // 
            // currentdownloadcount_label
            // 
            this.currentdownloadcount_label.AutoSize = true;
            this.currentdownloadcount_label.Location = new System.Drawing.Point(392, 97);
            this.currentdownloadcount_label.Name = "currentdownloadcount_label";
            this.currentdownloadcount_label.Size = new System.Drawing.Size(11, 12);
            this.currentdownloadcount_label.TabIndex = 11;
            this.currentdownloadcount_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 340);
            this.Controls.Add(this.currentdownloadcount_label);
            this.Controls.Add(this.totalcount_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkpic_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.bro_button);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 379);
            this.MinimumSize = new System.Drawing.Size(465, 379);
            this.Name = "Form1";
            this.Text = "bilibili";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bro_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button checkpic_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalcount_label;
        private System.Windows.Forms.Label currentdownloadcount_label;
        private System.Windows.Forms.FolderBrowserDialog open_folderBrowserDialog;
    }
}

