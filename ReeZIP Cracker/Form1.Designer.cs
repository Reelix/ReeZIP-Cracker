namespace ReeZIP_Cracker
{
    partial class Form1
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
            this.btnOpenZIP = new System.Windows.Forms.Button();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.ofdZIP = new System.Windows.Forms.OpenFileDialog();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnOpenDictionary = new System.Windows.Forms.Button();
            this.txtDictionary = new System.Windows.Forms.TextBox();
            this.ofdDictionary = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpenZIP
            // 
            this.btnOpenZIP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenZIP.Location = new System.Drawing.Point(32, 39);
            this.btnOpenZIP.Name = "btnOpenZIP";
            this.btnOpenZIP.Size = new System.Drawing.Size(117, 32);
            this.btnOpenZIP.TabIndex = 0;
            this.btnOpenZIP.Text = "Choose ZIP File";
            this.btnOpenZIP.UseVisualStyleBackColor = true;
            this.btnOpenZIP.Click += new System.EventHandler(this.btnOpenZIP_Click);
            // 
            // txtZIP
            // 
            this.txtZIP.BackColor = System.Drawing.Color.Black;
            this.txtZIP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZIP.ForeColor = System.Drawing.Color.Yellow;
            this.txtZIP.Location = new System.Drawing.Point(32, 81);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(471, 27);
            this.txtZIP.TabIndex = 1;
            // 
            // lbResults
            // 
            this.lbResults.BackColor = System.Drawing.Color.Black;
            this.lbResults.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.ForeColor = System.Drawing.Color.Yellow;
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(32, 233);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(471, 116);
            this.lbResults.TabIndex = 2;
            // 
            // ofdZIP
            // 
            this.ofdZIP.Filter = "ZIP Files|*.zip";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(32, 204);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Yellow;
            this.txtPassword.Location = new System.Drawing.Point(133, 378);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(370, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Click \"Go\" above";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Yellow;
            this.lblPassword.Location = new System.Drawing.Point(29, 385);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 18);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password: ";
            // 
            // btnOpenDictionary
            // 
            this.btnOpenDictionary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDictionary.Location = new System.Drawing.Point(32, 114);
            this.btnOpenDictionary.Name = "btnOpenDictionary";
            this.btnOpenDictionary.Size = new System.Drawing.Size(227, 32);
            this.btnOpenDictionary.TabIndex = 6;
            this.btnOpenDictionary.Text = "Choose Dictionary File";
            this.btnOpenDictionary.UseVisualStyleBackColor = true;
            this.btnOpenDictionary.Click += new System.EventHandler(this.btnOpenDictionary_Click);
            // 
            // txtDictionary
            // 
            this.txtDictionary.BackColor = System.Drawing.Color.Black;
            this.txtDictionary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDictionary.ForeColor = System.Drawing.Color.Yellow;
            this.txtDictionary.Location = new System.Drawing.Point(32, 152);
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.Size = new System.Drawing.Size(471, 27);
            this.txtDictionary.TabIndex = 7;
            // 
            // ofdDictionary
            // 
            this.ofdDictionary.Filter = "Dictionary List|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(530, 440);
            this.Controls.Add(this.txtDictionary);
            this.Controls.Add(this.btnOpenDictionary);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.txtZIP);
            this.Controls.Add(this.btnOpenZIP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Reelix\'s ZIP Cracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenZIP;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.OpenFileDialog ofdZIP;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnOpenDictionary;
        private System.Windows.Forms.TextBox txtDictionary;
        private System.Windows.Forms.OpenFileDialog ofdDictionary;
    }
}

