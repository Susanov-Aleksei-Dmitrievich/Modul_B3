namespace UchetOborudovania
{
    partial class OknoAvtorizacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoAvtorizacia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxParol = new System.Windows.Forms.TextBox();
            this.checkBoxMaska = new System.Windows.Forms.CheckBox();
            this.buttonVhod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(358, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Окно.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(467, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Авторизация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Логин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(113, 227);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 23);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxParol
            // 
            this.textBoxParol.Location = new System.Drawing.Point(113, 302);
            this.textBoxParol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxParol.Name = "textBoxParol";
            this.textBoxParol.PasswordChar = '*';
            this.textBoxParol.Size = new System.Drawing.Size(154, 23);
            this.textBoxParol.TabIndex = 6;
            // 
            // checkBoxMaska
            // 
            this.checkBoxMaska.AutoSize = true;
            this.checkBoxMaska.Location = new System.Drawing.Point(296, 306);
            this.checkBoxMaska.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxMaska.Name = "checkBoxMaska";
            this.checkBoxMaska.Size = new System.Drawing.Size(179, 19);
            this.checkBoxMaska.TabIndex = 7;
            this.checkBoxMaska.Text = "Показать или скрыть пароль";
            this.checkBoxMaska.UseVisualStyleBackColor = true;
            this.checkBoxMaska.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonVhod
            // 
            this.buttonVhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonVhod.Location = new System.Drawing.Point(113, 350);
            this.buttonVhod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonVhod.Name = "buttonVhod";
            this.buttonVhod.Size = new System.Drawing.Size(155, 51);
            this.buttonVhod.TabIndex = 8;
            this.buttonVhod.Text = "Войти";
            this.buttonVhod.UseVisualStyleBackColor = false;
            this.buttonVhod.Click += new System.EventHandler(this.buttonVhod_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Войти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 275);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Войти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(700, 350);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 51);
            this.button4.TabIndex = 11;
            this.button4.Text = "Войти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UchetOborudovania.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(223, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OknoAvtorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonVhod);
            this.Controls.Add(this.checkBoxMaska);
            this.Controls.Add(this.textBoxParol);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OknoAvtorizacia";
            this.Text = "Окно. Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxParol;
        private System.Windows.Forms.CheckBox checkBoxMaska;
        private System.Windows.Forms.Button buttonVhod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

