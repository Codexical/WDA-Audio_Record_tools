namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.INFO_button = new System.Windows.Forms.Button();
            this.CLOSE_button = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.HIDE_button = new System.Windows.Forms.Button();
            this.col_button = new System.Windows.Forms.Button();
            this.DEL_button = new System.Windows.Forms.Button();
            this.STOP_button = new System.Windows.Forms.Button();
            this.PLAY_button = new System.Windows.Forms.Button();
            this.REC_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 42;
            this.listBox1.Location = new System.Drawing.Point(53, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(763, 212);
            this.listBox1.TabIndex = 6;
            this.listBox1.Visible = false;
            // 
            // INFO_button
            // 
            this.INFO_button.FlatAppearance.BorderSize = 0;
            this.INFO_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INFO_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.INFO_button.Location = new System.Drawing.Point(384, -11);
            this.INFO_button.Name = "INFO_button";
            this.INFO_button.Size = new System.Drawing.Size(153, 42);
            this.INFO_button.TabIndex = 20;
            this.INFO_button.Text = "INFO";
            this.INFO_button.UseVisualStyleBackColor = true;
            this.INFO_button.Visible = false;
            this.INFO_button.Click += new System.EventHandler(this.INFO_button_Click);
            // 
            // CLOSE_button
            // 
            this.CLOSE_button.BackColor = System.Drawing.Color.Transparent;
            this.CLOSE_button.FlatAppearance.BorderSize = 0;
            this.CLOSE_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE_button.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE_button.ForeColor = System.Drawing.Color.Black;
            this.CLOSE_button.Location = new System.Drawing.Point(754, 0);
            this.CLOSE_button.Name = "CLOSE_button";
            this.CLOSE_button.Size = new System.Drawing.Size(91, 39);
            this.CLOSE_button.TabIndex = 8;
            this.CLOSE_button.Text = "關閉";
            this.CLOSE_button.UseVisualStyleBackColor = false;
            this.CLOSE_button.Click += new System.EventHandler(this.CLOSE_button_Click);
            this.CLOSE_button.MouseLeave += new System.EventHandler(this.CLOSE_button_MouseLeave);
            this.CLOSE_button.MouseHover += new System.EventHandler(this.CLOSE_button_MouseHover);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(3, 477);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 35);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "label2";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.Location = new System.Drawing.Point(-1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(846, 41);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "AudioRecord";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseUp);
            // 
            // HIDE_button
            // 
            this.HIDE_button.BackColor = System.Drawing.Color.Transparent;
            this.HIDE_button.FlatAppearance.BorderSize = 0;
            this.HIDE_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HIDE_button.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HIDE_button.ForeColor = System.Drawing.Color.Black;
            this.HIDE_button.Location = new System.Drawing.Point(657, 0);
            this.HIDE_button.Name = "HIDE_button";
            this.HIDE_button.Size = new System.Drawing.Size(91, 39);
            this.HIDE_button.TabIndex = 7;
            this.HIDE_button.Text = "縮小";
            this.HIDE_button.UseVisualStyleBackColor = false;
            this.HIDE_button.Click += new System.EventHandler(this.button1_Click);
            this.HIDE_button.MouseLeave += new System.EventHandler(this.HIDE_button_MouseLeave);
            this.HIDE_button.MouseHover += new System.EventHandler(this.HIDE_button_MouseHover);
            // 
            // col_button
            // 
            this.col_button.BackColor = System.Drawing.Color.Transparent;
            this.col_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_button.FlatAppearance.BorderSize = 0;
            this.col_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.col_button.Font = new System.Drawing.Font("微軟正黑體", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_button.Location = new System.Drawing.Point(724, 71);
            this.col_button.Name = "col_button";
            this.col_button.Size = new System.Drawing.Size(113, 77);
            this.col_button.TabIndex = 5;
            this.col_button.Text = "主題";
            this.col_button.UseVisualStyleBackColor = false;
            this.col_button.Click += new System.EventHandler(this.col_button_Click);
            this.col_button.MouseLeave += new System.EventHandler(this.col_button_MouseLeave);
            this.col_button.MouseHover += new System.EventHandler(this.col_button_MouseHover);
            // 
            // DEL_button
            // 
            this.DEL_button.BackColor = System.Drawing.Color.Transparent;
            this.DEL_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DEL_button.FlatAppearance.BorderSize = 0;
            this.DEL_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DEL_button.Font = new System.Drawing.Font("微軟正黑體", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEL_button.Location = new System.Drawing.Point(546, 71);
            this.DEL_button.Name = "DEL_button";
            this.DEL_button.Size = new System.Drawing.Size(174, 77);
            this.DEL_button.TabIndex = 4;
            this.DEL_button.Text = "刪除檔案";
            this.DEL_button.UseVisualStyleBackColor = false;
            this.DEL_button.Click += new System.EventHandler(this.DEL_button_Click);
            this.DEL_button.MouseLeave += new System.EventHandler(this.DEL_button_MouseLeave);
            this.DEL_button.MouseHover += new System.EventHandler(this.DEL_button_MouseHover);
            // 
            // STOP_button
            // 
            this.STOP_button.BackColor = System.Drawing.Color.Transparent;
            this.STOP_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.STOP_button.FlatAppearance.BorderSize = 0;
            this.STOP_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STOP_button.Font = new System.Drawing.Font("微軟正黑體", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOP_button.Location = new System.Drawing.Point(367, 71);
            this.STOP_button.Name = "STOP_button";
            this.STOP_button.Size = new System.Drawing.Size(174, 77);
            this.STOP_button.TabIndex = 3;
            this.STOP_button.Text = "停止播放";
            this.STOP_button.UseVisualStyleBackColor = false;
            this.STOP_button.Click += new System.EventHandler(this.STOP_button_Click);
            this.STOP_button.MouseLeave += new System.EventHandler(this.STOP_button_MouseLeave);
            this.STOP_button.MouseHover += new System.EventHandler(this.STOP_button_MouseHover);
            // 
            // PLAY_button
            // 
            this.PLAY_button.BackColor = System.Drawing.Color.Transparent;
            this.PLAY_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PLAY_button.FlatAppearance.BorderSize = 0;
            this.PLAY_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLAY_button.Font = new System.Drawing.Font("微軟正黑體", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY_button.Location = new System.Drawing.Point(188, 71);
            this.PLAY_button.Name = "PLAY_button";
            this.PLAY_button.Size = new System.Drawing.Size(174, 77);
            this.PLAY_button.TabIndex = 2;
            this.PLAY_button.Text = "開始播放";
            this.PLAY_button.UseVisualStyleBackColor = false;
            this.PLAY_button.Click += new System.EventHandler(this.PLAY_button_Click);
            this.PLAY_button.MouseLeave += new System.EventHandler(this.PLAY_button_MouseLeave);
            this.PLAY_button.MouseHover += new System.EventHandler(this.PLAY_button_MouseHover);
            // 
            // REC_button
            // 
            this.REC_button.BackColor = System.Drawing.Color.Transparent;
            this.REC_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.REC_button.FlatAppearance.BorderSize = 0;
            this.REC_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REC_button.Font = new System.Drawing.Font("微軟正黑體", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REC_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.REC_button.Location = new System.Drawing.Point(9, 71);
            this.REC_button.Name = "REC_button";
            this.REC_button.Size = new System.Drawing.Size(174, 77);
            this.REC_button.TabIndex = 1;
            this.REC_button.Text = "開始錄音";
            this.REC_button.UseVisualStyleBackColor = false;
            this.REC_button.Click += new System.EventHandler(this.REC_button_Click);
            this.REC_button.MouseLeave += new System.EventHandler(this.REC_button_MouseLeave);
            this.REC_button.MouseHover += new System.EventHandler(this.REC_button_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 122);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 514);
            this.Controls.Add(this.col_button);
            this.Controls.Add(this.HIDE_button);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.CLOSE_button);
            this.Controls.Add(this.DEL_button);
            this.Controls.Add(this.STOP_button);
            this.Controls.Add(this.PLAY_button);
            this.Controls.Add(this.REC_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.INFO_button);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AudioRecord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button REC_button;
        private System.Windows.Forms.Button PLAY_button;
        private System.Windows.Forms.Button STOP_button;
        private System.Windows.Forms.Button DEL_button;
        private System.Windows.Forms.Button INFO_button;
        private System.Windows.Forms.Button CLOSE_button;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button HIDE_button;
        private System.Windows.Forms.Button col_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

