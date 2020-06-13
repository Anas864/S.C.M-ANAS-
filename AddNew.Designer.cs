namespace S.C.M
{
    partial class AddNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.cboClubType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClubDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPresidantID = new System.Windows.Forms.TextBox();
            this.txtVicePresidantID = new System.Windows.Forms.TextBox();
            this.txtSecretaryID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW Club";
            // 
            // txtClubName
            // 
            this.txtClubName.BackColor = System.Drawing.Color.LightGray;
            this.txtClubName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubName.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubName.Location = new System.Drawing.Point(78, 113);
            this.txtClubName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubName.MaxLength = 20;
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(216, 21);
            this.txtClubName.TabIndex = 2;
            this.txtClubName.Text = "Clubname";
            this.txtClubName.Click += new System.EventHandler(this.txtClubName_Click);
            this.txtClubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClubName_KeyPress);
            // 
            // cboClubType
            // 
            this.cboClubType.BackColor = System.Drawing.Color.DimGray;
            this.cboClubType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClubType.ForeColor = System.Drawing.Color.White;
            this.cboClubType.FormattingEnabled = true;
            this.cboClubType.Location = new System.Drawing.Point(465, 113);
            this.cboClubType.Margin = new System.Windows.Forms.Padding(4);
            this.cboClubType.Name = "cboClubType";
            this.cboClubType.Size = new System.Drawing.Size(164, 27);
            this.cboClubType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Club Type : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.label4.Location = new System.Drawing.Point(111, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Of Registration :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.label5.Location = new System.Drawing.Point(111, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Club Description : ";
            // 
            // txtClubDesc
            // 
            this.txtClubDesc.BackColor = System.Drawing.Color.LightGray;
            this.txtClubDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClubDesc.Location = new System.Drawing.Point(298, 230);
            this.txtClubDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubDesc.Multiline = true;
            this.txtClubDesc.Name = "txtClubDesc";
            this.txtClubDesc.Size = new System.Drawing.Size(305, 98);
            this.txtClubDesc.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-2, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 36);
            this.label9.TabIndex = 12;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtPresidantID
            // 
            this.txtPresidantID.BackColor = System.Drawing.Color.LightGray;
            this.txtPresidantID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPresidantID.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresidantID.Location = new System.Drawing.Point(78, 362);
            this.txtPresidantID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPresidantID.Name = "txtPresidantID";
            this.txtPresidantID.Size = new System.Drawing.Size(206, 21);
            this.txtPresidantID.TabIndex = 13;
            this.txtPresidantID.Text = "President ID";
            this.txtPresidantID.Click += new System.EventHandler(this.txtPresidantID_Click);
            this.txtPresidantID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPresidantID_KeyPress);
            // 
            // txtVicePresidantID
            // 
            this.txtVicePresidantID.BackColor = System.Drawing.Color.LightGray;
            this.txtVicePresidantID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVicePresidantID.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVicePresidantID.Location = new System.Drawing.Point(369, 362);
            this.txtVicePresidantID.Margin = new System.Windows.Forms.Padding(4);
            this.txtVicePresidantID.Name = "txtVicePresidantID";
            this.txtVicePresidantID.Size = new System.Drawing.Size(216, 21);
            this.txtVicePresidantID.TabIndex = 14;
            this.txtVicePresidantID.Text = "Vice Presidents ID";
            this.txtVicePresidantID.Click += new System.EventHandler(this.txtVicePresidantID_Click);
            this.txtVicePresidantID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVicePresidantID_KeyPress);
            // 
            // txtSecretaryID
            // 
            this.txtSecretaryID.BackColor = System.Drawing.Color.LightGray;
            this.txtSecretaryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretaryID.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretaryID.Location = new System.Drawing.Point(78, 433);
            this.txtSecretaryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecretaryID.Name = "txtSecretaryID";
            this.txtSecretaryID.Size = new System.Drawing.Size(216, 21);
            this.txtSecretaryID.TabIndex = 15;
            this.txtSecretaryID.Text = "Secretary ID";
            this.txtSecretaryID.Click += new System.EventHandler(this.txtSecretaryID_Click);
            this.txtSecretaryID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecretaryID_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(369, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(517, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(78, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 3);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(78, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 3);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(78, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 3);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(369, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 3);
            this.panel4.TabIndex = 21;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSecretaryID);
            this.Controls.Add(this.txtVicePresidantID);
            this.Controls.Add(this.txtPresidantID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClubDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboClubType);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.ComboBox cboClubType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClubDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPresidantID;
        private System.Windows.Forms.TextBox txtVicePresidantID;
        private System.Windows.Forms.TextBox txtSecretaryID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}