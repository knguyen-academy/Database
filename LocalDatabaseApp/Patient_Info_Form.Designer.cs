namespace LocalDatabaseApp
{
    partial class PatientInfo_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.display_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.lname_text = new System.Windows.Forms.TextBox();
            this.retrieve_button = new System.Windows.Forms.Button();
            this.patientId_text = new System.Windows.Forms.TextBox();
            this.patientID_label = new System.Windows.Forms.Label();
            this.sQLiteTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delete_button = new System.Windows.Forms.Button();
            this.detail_button = new System.Windows.Forms.Button();
            this.DeleteAll_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(56, 303);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(813, 335);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // display_button
            // 
            this.display_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.display_button.Location = new System.Drawing.Point(710, 72);
            this.display_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(160, 35);
            this.display_button.TabIndex = 2;
            this.display_button.Text = "List All";
            this.display_button.UseVisualStyleBackColor = true;
            this.display_button.Click += new System.EventHandler(this.display_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insert_button.Location = new System.Drawing.Point(515, 183);
            this.insert_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(138, 35);
            this.insert_button.TabIndex = 3;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // fname_text
            // 
            this.fname_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fname_text.Location = new System.Drawing.Point(175, 128);
            this.fname_text.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(286, 23);
            this.fname_text.TabIndex = 4;
            // 
            // fname_label
            // 
            this.fname_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fname_label.AutoSize = true;
            this.fname_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fname_label.Location = new System.Drawing.Point(51, 139);
            this.fname_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(86, 17);
            this.fname_label.TabIndex = 5;
            this.fname_label.Text = "First Name";
            // 
            // lname_label
            // 
            this.lname_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname_label.AutoSize = true;
            this.lname_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lname_label.Location = new System.Drawing.Point(51, 194);
            this.lname_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(85, 17);
            this.lname_label.TabIndex = 6;
            this.lname_label.Text = "Last Name";
            // 
            // lname_text
            // 
            this.lname_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname_text.Location = new System.Drawing.Point(175, 183);
            this.lname_text.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lname_text.Name = "lname_text";
            this.lname_text.Size = new System.Drawing.Size(286, 23);
            this.lname_text.TabIndex = 7;
            // 
            // retrieve_button
            // 
            this.retrieve_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retrieve_button.Location = new System.Drawing.Point(515, 72);
            this.retrieve_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.retrieve_button.Name = "retrieve_button";
            this.retrieve_button.Size = new System.Drawing.Size(138, 35);
            this.retrieve_button.TabIndex = 8;
            this.retrieve_button.Text = "Retrieve";
            this.retrieve_button.UseVisualStyleBackColor = true;
            this.retrieve_button.Click += new System.EventHandler(this.retrieve_button_Click);
            // 
            // patientId_text
            // 
            this.patientId_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientId_text.Location = new System.Drawing.Point(175, 72);
            this.patientId_text.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.patientId_text.Name = "patientId_text";
            this.patientId_text.Size = new System.Drawing.Size(286, 23);
            this.patientId_text.TabIndex = 9;
            // 
            // patientID_label
            // 
            this.patientID_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientID_label.AutoSize = true;
            this.patientID_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.patientID_label.Location = new System.Drawing.Point(51, 83);
            this.patientID_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.patientID_label.Name = "patientID_label";
            this.patientID_label.Size = new System.Drawing.Size(77, 17);
            this.patientID_label.TabIndex = 10;
            this.patientID_label.Text = "Patient Id";
            // 
            // sQLiteTransactionBindingSource
            // 
            this.sQLiteTransactionBindingSource.DataSource = typeof(Finisar.SQLite.SQLiteTransaction);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_button.Location = new System.Drawing.Point(515, 128);
            this.delete_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(138, 35);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "Delete";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // detail_button
            // 
            this.detail_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detail_button.Location = new System.Drawing.Point(710, 186);
            this.detail_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.detail_button.Name = "detail_button";
            this.detail_button.Size = new System.Drawing.Size(160, 35);
            this.detail_button.TabIndex = 12;
            this.detail_button.Text = "More Detail...";
            this.detail_button.UseVisualStyleBackColor = true;
            this.detail_button.Click += new System.EventHandler(this.detail_button_Click);
            // 
            // DeleteAll_button
            // 
            this.DeleteAll_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteAll_button.Location = new System.Drawing.Point(710, 128);
            this.DeleteAll_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DeleteAll_button.Name = "DeleteAll_button";
            this.DeleteAll_button.Size = new System.Drawing.Size(160, 35);
            this.DeleteAll_button.TabIndex = 13;
            this.DeleteAll_button.Text = "Delete All";
            this.DeleteAll_button.UseVisualStyleBackColor = true;
            this.DeleteAll_button.Click += new System.EventHandler(this.DeleteAll_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit_button.Location = new System.Drawing.Point(710, 240);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(159, 34);
            this.Exit_button.TabIndex = 14;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // PatientInfo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::LocalDatabaseApp.Properties.Resources.Detail_BG3;
            this.ClientSize = new System.Drawing.Size(925, 658);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.DeleteAll_button);
            this.Controls.Add(this.detail_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.patientID_label);
            this.Controls.Add(this.patientId_text);
            this.Controls.Add(this.retrieve_button);
            this.Controls.Add(this.lname_text);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PatientInfo_Form";
            this.Text = "Patient_Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sQLiteTransactionBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.TextBox fname_text;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.TextBox lname_text;
        private System.Windows.Forms.Button retrieve_button;
        private System.Windows.Forms.TextBox patientId_text;
        private System.Windows.Forms.Label patientID_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button detail_button;
        private System.Windows.Forms.Button DeleteAll_button;
        private System.Windows.Forms.Button Exit_button;
    }
}