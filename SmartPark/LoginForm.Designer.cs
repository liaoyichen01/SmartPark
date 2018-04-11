namespace SmartPark
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(166, 38);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(170, 21);
            this.txUserName.TabIndex = 2;
            this.txUserName.TextChanged += new System.EventHandler(this.txUserName_TextChanged);
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(168, 88);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(168, 21);
            this.txPassword.TabIndex = 3;
            this.txPassword.TextChanged += new System.EventHandler(this.txPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(143, 153);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(247, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txInfo
            // 
            this.txInfo.ForeColor = System.Drawing.Color.Red;
            this.txInfo.Location = new System.Drawing.Point(166, 127);
            this.txInfo.Name = "txInfo";
            this.txInfo.Size = new System.Drawing.Size(170, 12);
            this.txInfo.TabIndex = 6;
            this.txInfo.Text = "label3";
            this.txInfo.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 222);
            this.Controls.Add(this.txInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "用户登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label txInfo;
    }
}