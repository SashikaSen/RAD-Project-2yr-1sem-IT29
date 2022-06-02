
namespace Tutorial_Symphony
{
    partial class StaffLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLoginForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_staff_username1 = new System.Windows.Forms.TextBox();
            this.text_staff_pwrd1 = new System.Windows.Forms.TextBox();
            this.staff_login_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(327, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Staff Login";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Staff Username";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // text_staff_username1
            // 
            this.text_staff_username1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_staff_username1.Location = new System.Drawing.Point(333, 275);
            this.text_staff_username1.Name = "text_staff_username1";
            this.text_staff_username1.Size = new System.Drawing.Size(244, 22);
            this.text_staff_username1.TabIndex = 3;
            // 
            // text_staff_pwrd1
            // 
            this.text_staff_pwrd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_staff_pwrd1.Location = new System.Drawing.Point(333, 318);
            this.text_staff_pwrd1.Name = "text_staff_pwrd1";
            this.text_staff_pwrd1.PasswordChar = '*';
            this.text_staff_pwrd1.Size = new System.Drawing.Size(244, 22);
            this.text_staff_pwrd1.TabIndex = 4;
            // 
            // staff_login_btn
            // 
            this.staff_login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.staff_login_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.staff_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staff_login_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.staff_login_btn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.staff_login_btn.Location = new System.Drawing.Point(650, 281);
            this.staff_login_btn.Name = "staff_login_btn";
            this.staff_login_btn.Size = new System.Drawing.Size(90, 37);
            this.staff_login_btn.TabIndex = 5;
            this.staff_login_btn.Text = "Login";
            this.staff_login_btn.UseVisualStyleBackColor = false;
            this.staff_login_btn.Click += new System.EventHandler(this.staff_login_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(33, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staff_login_btn);
            this.Controls.Add(this.text_staff_pwrd1);
            this.Controls.Add(this.text_staff_username1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StaffLoginForm";
            this.Text = "Staff Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_staff_username;
        private System.Windows.Forms.TextBox text_staff_pwrd;
        private System.Windows.Forms.Button Staff_lgn_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_staff_username1;
        private System.Windows.Forms.TextBox text_staff_pwrd1;
        private System.Windows.Forms.Button staff_login_btn;
        private System.Windows.Forms.Button button1;
    }
}