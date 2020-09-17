namespace yoketoruvs20
{
    partial class よけとる2020
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titlelabel = new System.Windows.Forms.Label();
            this.startbutton1 = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.timelabel4 = new System.Windows.Forms.Label();
            this.hosilabel5 = new System.Windows.Forms.Label();
            this.gmaeOverlabel = new System.Windows.Forms.Label();
            this.clearlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titlebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titlelabel.Location = new System.Drawing.Point(197, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(430, 80);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "よけとる2020";
            this.titlelabel.Click += new System.EventHandler(this.title_Click);
            // 
            // startbutton1
            // 
            this.startbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.startbutton1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startbutton1.ForeColor = System.Drawing.Color.Purple;
            this.startbutton1.Location = new System.Drawing.Point(294, 247);
            this.startbutton1.Name = "startbutton1";
            this.startbutton1.Size = new System.Drawing.Size(241, 119);
            this.startbutton1.TabIndex = 1;
            this.startbutton1.Text = "スタート!!";
            this.startbutton1.UseVisualStyleBackColor = false;
            this.startbutton1.Click += new System.EventHandler(this.startbutton1_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyrightLabel.Location = new System.Drawing.Point(299, 421);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(200, 20);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright © 2020 藤次";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hiLabel.Location = new System.Drawing.Point(276, 30);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(259, 40);
            this.hiLabel.TabIndex = 3;
            this.hiLabel.Text = "HighScore 100";
            // 
            // timelabel4
            // 
            this.timelabel4.AutoSize = true;
            this.timelabel4.Font = new System.Drawing.Font("MS UI Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timelabel4.Location = new System.Drawing.Point(39, 30);
            this.timelabel4.Name = "timelabel4";
            this.timelabel4.Size = new System.Drawing.Size(135, 31);
            this.timelabel4.TabIndex = 4;
            this.timelabel4.Text = "Time 100";
            // 
            // hosilabel5
            // 
            this.hosilabel5.AutoSize = true;
            this.hosilabel5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hosilabel5.Location = new System.Drawing.Point(673, 29);
            this.hosilabel5.Name = "hosilabel5";
            this.hosilabel5.Size = new System.Drawing.Size(95, 33);
            this.hosilabel5.TabIndex = 5;
            this.hosilabel5.Text = "★：10";
            // 
            // gmaeOverlabel
            // 
            this.gmaeOverlabel.AutoSize = true;
            this.gmaeOverlabel.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gmaeOverlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gmaeOverlabel.Location = new System.Drawing.Point(239, 20);
            this.gmaeOverlabel.Name = "gmaeOverlabel";
            this.gmaeOverlabel.Size = new System.Drawing.Size(326, 67);
            this.gmaeOverlabel.TabIndex = 6;
            this.gmaeOverlabel.Text = "GameOver";
            // 
            // clearlabel
            // 
            this.clearlabel.AutoSize = true;
            this.clearlabel.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.clearlabel.Location = new System.Drawing.Point(269, 9);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(276, 80);
            this.clearlabel.TabIndex = 7;
            this.clearlabel.Text = "CLEAR";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titlebutton
            // 
            this.titlebutton.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlebutton.Location = new System.Drawing.Point(303, 137);
            this.titlebutton.Name = "titlebutton";
            this.titlebutton.Size = new System.Drawing.Size(225, 104);
            this.titlebutton.TabIndex = 9;
            this.titlebutton.Text = "タイトルへ";
            this.titlebutton.UseVisualStyleBackColor = true;
            // 
            // よけとる2020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlebutton);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.gmaeOverlabel);
            this.Controls.Add(this.hosilabel5);
            this.Controls.Add(this.timelabel4);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startbutton1);
            this.Controls.Add(this.titlelabel);
            this.Name = "よけとる2020";
            this.Text = "よけとる2020";
            this.Load += new System.EventHandler(this.よけとる2020_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button startbutton1;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label timelabel4;
        private System.Windows.Forms.Label hosilabel5;
        private System.Windows.Forms.Label gmaeOverlabel;
        private System.Windows.Forms.Label clearlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button titlebutton;
    }
}

