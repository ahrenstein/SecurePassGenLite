namespace Secure_Password_Generator_Lite
{
    partial class frmMain
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
            this.lblFQDN = new System.Windows.Forms.Label();
            this.txtFQDN = new System.Windows.Forms.TextBox();
            this.lblSeed = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btnGenPass = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFQDN
            // 
            this.lblFQDN.AutoSize = true;
            this.lblFQDN.Location = new System.Drawing.Point(12, 24);
            this.lblFQDN.Name = "lblFQDN";
            this.lblFQDN.Size = new System.Drawing.Size(84, 13);
            this.lblFQDN.TabIndex = 0;
            this.lblFQDN.Text = "Machine FQDN:";
            // 
            // txtFQDN
            // 
            this.txtFQDN.Location = new System.Drawing.Point(102, 21);
            this.txtFQDN.Name = "txtFQDN";
            this.txtFQDN.Size = new System.Drawing.Size(281, 20);
            this.txtFQDN.TabIndex = 1;
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(12, 59);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(59, 13);
            this.lblSeed.TabIndex = 2;
            this.lblSeed.Text = "Seed Text:";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(102, 56);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.PasswordChar = '*';
            this.txtSeed.Size = new System.Drawing.Size(281, 20);
            this.txtSeed.TabIndex = 2;
            // 
            // btnGenPass
            // 
            this.btnGenPass.Location = new System.Drawing.Point(208, 140);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(119, 23);
            this.btnGenPass.TabIndex = 3;
            this.btnGenPass.Text = "Generate Password";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Click += new System.EventHandler(this.btnGenPass_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 193);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 190);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(281, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(447, 392);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 427);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnGenPass);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.txtFQDN);
            this.Controls.Add(this.lblFQDN);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 465);
            this.Name = "frmMain";
            this.Text = "Secure Password Generator Lite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFQDN;
        private System.Windows.Forms.TextBox txtFQDN;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuit;
    }
}

