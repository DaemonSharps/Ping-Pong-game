namespace PingPong_itProger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackGround = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameball = new System.Windows.Forms.PictureBox();
            this.gamepanel = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.BackColor = System.Drawing.SystemColors.Control;
            this.BackGround.Controls.Add(this.label4);
            this.BackGround.Controls.Add(this.label3);
            this.BackGround.Controls.Add(this.label2);
            this.BackGround.Controls.Add(this.label1);
            this.BackGround.Controls.Add(this.gameball);
            this.BackGround.Controls.Add(this.gamepanel);
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.ForeColor = System.Drawing.Color.Black;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(800, 450);
            this.BackGround.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(291, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "scores";
            // 
            // gameball
            // 
            this.gameball.BackColor = System.Drawing.SystemColors.Highlight;
            this.gameball.Location = new System.Drawing.Point(207, 411);
            this.gameball.Name = "gameball";
            this.gameball.Size = new System.Drawing.Size(20, 20);
            this.gameball.TabIndex = 1;
            this.gameball.TabStop = false;
            // 
            // gamepanel
            // 
            this.gamepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamepanel.Location = new System.Drawing.Point(150, 437);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(135, 10);
            this.gamepanel.TabIndex = 0;
            this.gamepanel.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Restsart: R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Escape: ecs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.BackGround.ResumeLayout(false);
            this.BackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGround;
        private System.Windows.Forms.PictureBox gamepanel;
        private System.Windows.Forms.PictureBox gameball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

