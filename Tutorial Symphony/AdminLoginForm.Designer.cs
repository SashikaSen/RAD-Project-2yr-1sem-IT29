
namespace Tutorial_Symphony
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_admn_username = new System.Windows.Forms.TextBox();
            this.text_admn_pwrd = new System.Windows.Forms.TextBox();
            this.Admin_lgn_btn = new System.Windows.Forms.Button();
            this.back_btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(247, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // text_admn_username
            // 
            this.text_admn_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_admn_username.Location = new System.Drawing.Point(349, 297);
            this.text_admn_username.Name = "text_admn_username";
            this.text_admn_username.Size = new System.Drawing.Size(168, 22);
            this.text_admn_username.TabIndex = 3;
            this.text_admn_username.TextChanged += new System.EventHandler(this.text_admn_username_TextChanged);
            // 
            // text_admn_pwrd
            // 
            this.text_admn_pwrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_admn_pwrd.Location = new System.Drawing.Point(349, 335);
            this.text_admn_pwrd.Name = "text_admn_pwrd";
            this.text_admn_pwrd.PasswordChar = '*';
            this.text_admn_pwrd.Size = new System.Drawing.Size(168, 22);
            this.text_admn_pwrd.TabIndex = 4;
            // 
            // Admin_lgn_btn
            // 
            this.Admin_lgn_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Admin_lgn_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_lgn_btn.Location = new System.Drawing.Point(612, 399);
            this.Admin_lgn_btn.Name = "Admin_lgn_btn";
            this.Admin_lgn_btn.Size = new System.Drawing.Size(151, 39);
            this.Admin_lgn_btn.TabIndex = 5;
            this.Admin_lgn_btn.Text = "Login";
            this.Admin_lgn_btn.UseVisualStyleBackColor = true;
            this.Admin_lgn_btn.Click += new System.EventHandler(this.Admin_lgn_btn_Click);
            // 
            // back_btn_admin
            // 
            this.back_btn_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back_btn_admin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.back_btn_admin.Location = new System.Drawing.Point(32, 399);
            this.back_btn_admin.Name = "back_btn_admin";
            this.back_btn_admin.Size = new System.Drawing.Size(108, 38);
            this.back_btn_admin.TabIndex = 6;
            this.back_btn_admin.Text = "Back";
            this.back_btn_admin.UseVisualStyleBackColor = true;
            this.back_btn_admin.Click += new System.EventHandler(this.back_btn_admin_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn_admin);
            this.Controls.Add(this.Admin_lgn_btn);
            this.Controls.Add(this.text_admn_pwrd);
            this.Controls.Add(this.text_admn_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLoginForm";
            this.Text = "Administrator login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_admn_username;
        private System.Windows.Forms.TextBox text_admn_pwrd;
        private System.Windows.Forms.Button Admin_lgn_btn;
        private System.Windows.Forms.Button back_btn_admin;
    }
}