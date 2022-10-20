namespace tacsi
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OpenUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordFild = new System.Windows.Forms.TextBox();
            this.LoginFild = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Registrlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Registrlabel);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.OpenUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PasswordFild);
            this.panel1.Controls.Add(this.LoginFild);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 230);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(206, 168);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 34);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OpenUser
            // 
            this.OpenUser.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenUser.Location = new System.Drawing.Point(32, 168);
            this.OpenUser.Name = "OpenUser";
            this.OpenUser.Size = new System.Drawing.Size(130, 34);
            this.OpenUser.TabIndex = 5;
            this.OpenUser.Text = "Ок";
            this.OpenUser.UseVisualStyleBackColor = true;
            this.OpenUser.Click += new System.EventHandler(this.OpenUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // PasswordFild
            // 
            this.PasswordFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordFild.Location = new System.Drawing.Point(133, 117);
            this.PasswordFild.Multiline = true;
            this.PasswordFild.Name = "PasswordFild";
            this.PasswordFild.PasswordChar = '*';
            this.PasswordFild.Size = new System.Drawing.Size(203, 30);
            this.PasswordFild.TabIndex = 2;
            this.PasswordFild.TextChanged += new System.EventHandler(this.PasswordFild_TextChanged);
            // 
            // LoginFild
            // 
            this.LoginFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginFild.Location = new System.Drawing.Point(133, 80);
            this.LoginFild.Multiline = true;
            this.LoginFild.Name = "LoginFild";
            this.LoginFild.Size = new System.Drawing.Size(203, 30);
            this.LoginFild.TabIndex = 1;
            this.LoginFild.TextChanged += new System.EventHandler(this.LoginFild_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 56);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация пользователя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Registrlabel
            // 
            this.Registrlabel.AutoSize = true;
            this.Registrlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrlabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Registrlabel.Location = new System.Drawing.Point(96, 205);
            this.Registrlabel.Name = "Registrlabel";
            this.Registrlabel.Size = new System.Drawing.Size(171, 20);
            this.Registrlabel.TabIndex = 7;
            this.Registrlabel.Text = "Ещё нет аккаунта?";
            this.Registrlabel.Click += new System.EventHandler(this.Registrlabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 230);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordFild;
        private System.Windows.Forms.TextBox LoginFild;
        private System.Windows.Forms.Button OpenUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Registrlabel;
    }
}