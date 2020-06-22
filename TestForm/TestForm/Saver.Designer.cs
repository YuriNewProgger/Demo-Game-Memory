namespace TestForm
{
    partial class Saver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saver));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerPlazma = new System.Windows.Forms.Timer(this.components);
            this.timer_NameGame = new System.Windows.Forms.Timer(this.components);
            this.button_PlayGame = new System.Windows.Forms.Button();
            this.pictureBox_NameGame = new System.Windows.Forms.PictureBox();
            this.pictureBox_ForLoading1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_ForLoading = new System.Windows.Forms.PictureBox();
            this.button_ExitGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NameGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForLoading1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timerPlazma
            // 
            this.timerPlazma.Interval = 33;
            this.timerPlazma.Tick += new System.EventHandler(this.TimerPlazma_Tick);
            // 
            // timer_NameGame
            // 
            this.timer_NameGame.Interval = 33;
            this.timer_NameGame.Tick += new System.EventHandler(this.Timer_NameGame_Tick);
            // 
            // button_PlayGame
            // 
            this.button_PlayGame.BackColor = System.Drawing.Color.Orange;
            this.button_PlayGame.Image = global::TestForm.Properties.Resources.PlayGame;
            this.button_PlayGame.Location = new System.Drawing.Point(145, 0);
            this.button_PlayGame.Name = "button_PlayGame";
            this.button_PlayGame.Size = new System.Drawing.Size(115, 50);
            this.button_PlayGame.TabIndex = 2;
            this.button_PlayGame.UseVisualStyleBackColor = false;
            this.button_PlayGame.Click += new System.EventHandler(this.Button_PlayGame_Click);
            // 
            // pictureBox_NameGame
            // 
            this.pictureBox_NameGame.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_NameGame.Image")));
            this.pictureBox_NameGame.Location = new System.Drawing.Point(250, 0);
            this.pictureBox_NameGame.Name = "pictureBox_NameGame";
            this.pictureBox_NameGame.Size = new System.Drawing.Size(365, 95);
            this.pictureBox_NameGame.TabIndex = 1;
            this.pictureBox_NameGame.TabStop = false;
            // 
            // pictureBox_ForLoading1
            // 
            this.pictureBox_ForLoading1.Location = new System.Drawing.Point(70, 15);
            this.pictureBox_ForLoading1.Name = "pictureBox_ForLoading1";
            this.pictureBox_ForLoading1.Size = new System.Drawing.Size(75, 80);
            this.pictureBox_ForLoading1.TabIndex = 0;
            this.pictureBox_ForLoading1.TabStop = false;
            // 
            // pictureBox_ForLoading
            // 
            this.pictureBox_ForLoading.Location = new System.Drawing.Point(0, 15);
            this.pictureBox_ForLoading.Name = "pictureBox_ForLoading";
            this.pictureBox_ForLoading.Size = new System.Drawing.Size(75, 80);
            this.pictureBox_ForLoading.TabIndex = 0;
            this.pictureBox_ForLoading.TabStop = false;
            // 
            // button_ExitGame
            // 
            this.button_ExitGame.BackColor = System.Drawing.Color.Olive;
            this.button_ExitGame.Image = global::TestForm.Properties.Resources.ExitGame;
            this.button_ExitGame.Location = new System.Drawing.Point(160, 50);
            this.button_ExitGame.Name = "button_ExitGame";
            this.button_ExitGame.Size = new System.Drawing.Size(85, 45);
            this.button_ExitGame.TabIndex = 2;
            this.button_ExitGame.UseVisualStyleBackColor = false;
            this.button_ExitGame.Click += new System.EventHandler(this.Button_ExitGame_Click);
            // 
            // Saver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(617, 96);
            this.Controls.Add(this.button_ExitGame);
            this.Controls.Add(this.button_PlayGame);
            this.Controls.Add(this.pictureBox_NameGame);
            this.Controls.Add(this.pictureBox_ForLoading1);
            this.Controls.Add(this.pictureBox_ForLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Saver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NameGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForLoading1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_ForLoading;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox_ForLoading1;
        private System.Windows.Forms.Timer timerPlazma;
        private System.Windows.Forms.PictureBox pictureBox_NameGame;
        private System.Windows.Forms.Timer timer_NameGame;
        private System.Windows.Forms.Button button_PlayGame;
        private System.Windows.Forms.Button button_ExitGame;
    }
}

