namespace S.C.M
{
    partial class Update
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
            this.txtPresidant = new System.Windows.Forms.TextBox();
            this.txtVicePresident = new System.Windows.Forms.TextBox();
            this.txtSecretary = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtClubname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "          Update Club \r\nRepresentatives Positions\r\n";
            // 
            // txtPresidant
            // 
            this.txtPresidant.BackColor = System.Drawing.Color.LightGray;
            this.txtPresidant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPresidant.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresidant.Location = new System.Drawing.Point(80, 322);
            this.txtPresidant.Name = "txtPresidant";
            this.txtPresidant.Size = new System.Drawing.Size(183, 21);
            this.txtPresidant.TabIndex = 4;
            this.txtPresidant.Text = "New President ID";
            this.txtPresidant.Click += new System.EventHandler(this.txtPresidant_Click);
            // 
            // txtVicePresident
            // 
            this.txtVicePresident.BackColor = System.Drawing.Color.LightGray;
            this.txtVicePresident.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVicePresident.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVicePresident.Location = new System.Drawing.Point(378, 322);
            this.txtVicePresident.Name = "txtVicePresident";
            this.txtVicePresident.Size = new System.Drawing.Size(279, 21);
            this.txtVicePresident.TabIndex = 5;
            this.txtVicePresident.Text = "New Vice President id ";
            this.txtVicePresident.Click += new System.EventHandler(this.txtVicePresident_Click);
            this.txtVicePresident.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVicePresident_KeyPress);
            // 
            // txtSecretary
            // 
            this.txtSecretary.BackColor = System.Drawing.Color.LightGray;
            this.txtSecretary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretary.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretary.Location = new System.Drawing.Point(80, 436);
            this.txtSecretary.Name = "txtSecretary";
            this.txtSecretary.Size = new System.Drawing.Size(179, 21);
            this.txtSecretary.TabIndex = 6;
            this.txtSecretary.Text = "New secretary id ";
            this.txtSecretary.Click += new System.EventHandler(this.txtSecretary_Click);
            this.txtSecretary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecretary_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.btnUpdate.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(378, 427);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 41);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.btnClear.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(541, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 41);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtClubname
            // 
            this.txtClubname.BackColor = System.Drawing.Color.LightGray;
            this.txtClubname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubname.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubname.Location = new System.Drawing.Point(216, 222);
            this.txtClubname.Name = "txtClubname";
            this.txtClubname.Size = new System.Drawing.Size(194, 21);
            this.txtClubname.TabIndex = 10;
            this.txtClubname.Text = "Clubname";
            this.txtClubname.Click += new System.EventHandler(this.txtClubname_Click);
            this.txtClubname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClubname_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 3);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(378, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 3);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(80, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 3);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(216, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 3);
            this.panel4.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 82);
            this.label2.TabIndex = 24;
            this.label2.Text = "X\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtClubname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSecretary);
            this.Controls.Add(this.txtVicePresident);
            this.Controls.Add(this.txtPresidant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPresidant;
        private System.Windows.Forms.TextBox txtVicePresident;
        private System.Windows.Forms.TextBox txtSecretary;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtClubname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}