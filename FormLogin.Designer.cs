namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.haslo_textBox = new System.Windows.Forms.TextBox();
            this.zaloguj_button = new System.Windows.Forms.Button();
            this.role_comboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logowanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "rola";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(62, 41);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(178, 20);
            this.login_textBox.TabIndex = 4;
            this.login_textBox.TextChanged += new System.EventHandler(this.login_textBox_TextChanged);
            // 
            // haslo_textBox
            // 
            this.haslo_textBox.Location = new System.Drawing.Point(62, 67);
            this.haslo_textBox.Name = "haslo_textBox";
            this.haslo_textBox.PasswordChar = '#';
            this.haslo_textBox.Size = new System.Drawing.Size(178, 20);
            this.haslo_textBox.TabIndex = 5;
            this.haslo_textBox.TextChanged += new System.EventHandler(this.haslo_textBox_TextChanged);
            // 
            // zaloguj_button
            // 
            this.zaloguj_button.Location = new System.Drawing.Point(62, 121);
            this.zaloguj_button.Name = "zaloguj_button";
            this.zaloguj_button.Size = new System.Drawing.Size(178, 23);
            this.zaloguj_button.TabIndex = 8;
            this.zaloguj_button.Text = "Zaloguj";
            this.zaloguj_button.UseVisualStyleBackColor = true;
            this.zaloguj_button.Click += new System.EventHandler(this.zaloguj_button_Click);
            // 
            // role_comboBox
            // 
            this.role_comboBox.FormattingEnabled = true;
            this.role_comboBox.Location = new System.Drawing.Point(62, 96);
            this.role_comboBox.Name = "role_comboBox";
            this.role_comboBox.Size = new System.Drawing.Size(178, 21);
            this.role_comboBox.TabIndex = 9;
            this.role_comboBox.SelectedIndexChanged += new System.EventHandler(this.role_comboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.role_comboBox);
            this.Controls.Add(this.zaloguj_button);
            this.Controls.Add(this.haslo_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie Baza KOM-EX";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox haslo_textBox;
        private System.Windows.Forms.Button zaloguj_button;
        private System.Windows.Forms.ComboBox role_comboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

