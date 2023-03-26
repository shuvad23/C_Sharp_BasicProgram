namespace windowsForm1
{
    partial class loginForm
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
            this.txtid = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(125, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(122, 36);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "User ID";
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(125, 121);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(155, 36);
            this.txtpass.TabIndex = 1;
            this.txtpass.Text = "Password";
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.Menu;
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.Location = new System.Drawing.Point(300, 63);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(432, 38);
            this.box1.TabIndex = 2;
            // 
            // box2
            // 
            this.box2.AcceptsTab = true;
            this.box2.BackColor = System.Drawing.SystemColors.Menu;
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2.Location = new System.Drawing.Point(300, 119);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(432, 38);
            this.box2.TabIndex = 3;
            this.box2.UseSystemPasswordChar = true;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(487, 204);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(132, 52);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(300, 204);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(130, 52);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtid);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label txtpass;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnlogin;
    }
}