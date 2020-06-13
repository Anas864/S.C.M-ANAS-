namespace S.C.M
{
    partial class WeeklyUpdate
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
            this.cboActivityType = new System.Windows.Forms.ComboBox();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtWinners = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParticipants = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekly Activity Report";
            // 
            // txtClubName
            // 
            this.txtClubName.BackColor = System.Drawing.Color.LightGray;
            this.txtClubName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubName.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubName.Location = new System.Drawing.Point(75, 142);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(183, 21);
            this.txtClubName.TabIndex = 2;
            this.txtClubName.Text = "Club Name";
            this.txtClubName.Click += new System.EventHandler(this.txtClubName_Click);
            // 
            // cboActivityType
            // 
            this.cboActivityType.BackColor = System.Drawing.Color.DimGray;
            this.cboActivityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivityType.ForeColor = System.Drawing.Color.White;
            this.cboActivityType.FormattingEnabled = true;
            this.cboActivityType.Location = new System.Drawing.Point(461, 141);
            this.cboActivityType.Name = "cboActivityType";
            this.cboActivityType.Size = new System.Drawing.Size(192, 28);
            this.cboActivityType.TabIndex = 3;
            // 
            // txtActivityName
            // 
            this.txtActivityName.BackColor = System.Drawing.Color.LightGray;
            this.txtActivityName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivityName.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityName.Location = new System.Drawing.Point(75, 237);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(224, 21);
            this.txtActivityName.TabIndex = 6;
            this.txtActivityName.Text = "Activity NAME";
            this.txtActivityName.Click += new System.EventHandler(this.txtActivityName_Click);
            this.txtActivityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActivityName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightGray;
            this.txtDescription.Location = new System.Drawing.Point(450, 222);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 75);
            this.txtDescription.TabIndex = 8;
            // 
            // txtWinners
            // 
            this.txtWinners.BackColor = System.Drawing.Color.LightGray;
            this.txtWinners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWinners.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinners.Location = new System.Drawing.Point(75, 335);
            this.txtWinners.Name = "txtWinners";
            this.txtWinners.Size = new System.Drawing.Size(184, 21);
            this.txtWinners.TabIndex = 10;
            this.txtWinners.Text = "Winner name";
            this.txtWinners.Click += new System.EventHandler(this.txtWinners_Click);
            this.txtWinners.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWinners_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Activity Type :";
            // 
            // txtParticipants
            // 
            this.txtParticipants.BackColor = System.Drawing.Color.LightGray;
            this.txtParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParticipants.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipants.Location = new System.Drawing.Point(386, 329);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.Size = new System.Drawing.Size(168, 21);
            this.txtParticipants.TabIndex = 13;
            this.txtParticipants.Text = "Partiicipants ";
            this.txtParticipants.Click += new System.EventHandler(this.txtParticipants_Click);
            this.txtParticipants.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParticipants_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.btnSubmit.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(126, 438);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(272, 43);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.btnClear.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(404, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 43);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(75, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 3);
            this.panel4.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(75, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 3);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(75, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 3);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(386, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 3);
            this.panel3.TabIndex = 29;
            // 
            // WeeklyUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(682, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtParticipants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWinners);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActivityName);
            this.Controls.Add(this.cboActivityType);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyUpdate";
            this.Text = "WeeklyUpdate";
            this.Load += new System.EventHandler(this.WeeklyUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.ComboBox cboActivityType;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtWinners;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParticipants;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}