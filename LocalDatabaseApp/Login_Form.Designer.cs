namespace LocalDatabaseApp
{
    partial class Login_Form
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
            this.connect_button = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.signIn_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connect_button.Location = new System.Drawing.Point(193, 251);
            this.connect_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(95, 35);
            this.connect_button.TabIndex = 3;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            this.connect_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyUp);
            // 
            // username_text
            // 
            this.username_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_text.Location = new System.Drawing.Point(193, 99);
            this.username_text.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(223, 23);
            this.username_text.TabIndex = 1;
            this.username_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyUp);
            // 
            // password_text
            // 
            this.password_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_text.Location = new System.Drawing.Point(193, 160);
            this.password_text.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(223, 23);
            this.password_text.TabIndex = 2;
            this.password_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyUp);
            // 
            // username_label
            // 
            this.username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(66, 102);
            this.username_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(88, 17);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "UserName:";
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(66, 160);
            this.password_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(82, 17);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password:";
            // 
            // signIn_label
            // 
            this.signIn_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signIn_label.AutoSize = true;
            this.signIn_label.Location = new System.Drawing.Point(66, 34);
            this.signIn_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.signIn_label.Name = "signIn_label";
            this.signIn_label.Size = new System.Drawing.Size(58, 17);
            this.signIn_label.TabIndex = 2;
            this.signIn_label.Text = "Sign in";
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit_button.Location = new System.Drawing.Point(324, 251);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(92, 37);
            this.Exit_button.TabIndex = 4;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::LocalDatabaseApp.Properties.Resources.Log_in_BG;
            this.ClientSize = new System.Drawing.Size(521, 398);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.signIn_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.connect_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label signIn_label;
        private System.Windows.Forms.Button Exit_button;
    }
}

