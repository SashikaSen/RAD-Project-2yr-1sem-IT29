
namespace Tutorial_Symphony
{
    partial class Employeemgr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_emp_id = new System.Windows.Forms.TextBox();
            this.text_emp_name = new System.Windows.Forms.TextBox();
            this.text_emp_posi = new System.Windows.Forms.TextBox();
            this.btn_update_emp = new System.Windows.Forms.Button();
            this.btn_delete_emp = new System.Windows.Forms.Button();
            this.btn_save_emp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position";
            // 
            // text_emp_id
            // 
            this.text_emp_id.Location = new System.Drawing.Point(175, 115);
            this.text_emp_id.Name = "text_emp_id";
            this.text_emp_id.Size = new System.Drawing.Size(246, 22);
            this.text_emp_id.TabIndex = 6;
            // 
            // text_emp_name
            // 
            this.text_emp_name.Location = new System.Drawing.Point(175, 158);
            this.text_emp_name.Name = "text_emp_name";
            this.text_emp_name.Size = new System.Drawing.Size(246, 22);
            this.text_emp_name.TabIndex = 7;
            // 
            // text_emp_posi
            // 
            this.text_emp_posi.Location = new System.Drawing.Point(175, 208);
            this.text_emp_posi.Name = "text_emp_posi";
            this.text_emp_posi.Size = new System.Drawing.Size(246, 22);
            this.text_emp_posi.TabIndex = 8;
            // 
            // btn_update_emp
            // 
            this.btn_update_emp.BackColor = System.Drawing.Color.Snow;
            this.btn_update_emp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update_emp.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_emp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_update_emp.Location = new System.Drawing.Point(604, 392);
            this.btn_update_emp.Name = "btn_update_emp";
            this.btn_update_emp.Size = new System.Drawing.Size(75, 30);
            this.btn_update_emp.TabIndex = 9;
            this.btn_update_emp.Text = "Update";
            this.btn_update_emp.UseVisualStyleBackColor = false;
            this.btn_update_emp.Click += new System.EventHandler(this.btn_update_emp_Click);
            // 
            // btn_delete_emp
            // 
            this.btn_delete_emp.BackColor = System.Drawing.Color.Snow;
            this.btn_delete_emp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete_emp.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_emp.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete_emp.Location = new System.Drawing.Point(685, 392);
            this.btn_delete_emp.Name = "btn_delete_emp";
            this.btn_delete_emp.Size = new System.Drawing.Size(75, 30);
            this.btn_delete_emp.TabIndex = 10;
            this.btn_delete_emp.Text = "Delete";
            this.btn_delete_emp.UseVisualStyleBackColor = false;
            this.btn_delete_emp.Click += new System.EventHandler(this.btn_delete_emp_Click);
            // 
            // btn_save_emp
            // 
            this.btn_save_emp.BackColor = System.Drawing.Color.Snow;
            this.btn_save_emp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_emp.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_emp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_save_emp.Location = new System.Drawing.Point(523, 392);
            this.btn_save_emp.Name = "btn_save_emp";
            this.btn_save_emp.Size = new System.Drawing.Size(75, 30);
            this.btn_save_emp.TabIndex = 11;
            this.btn_save_emp.Text = "Save";
            this.btn_save_emp.UseVisualStyleBackColor = false;
            this.btn_save_emp.Click += new System.EventHandler(this.btn_save_emp_Click);
            // 
            // Employeemgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save_emp);
            this.Controls.Add(this.btn_delete_emp);
            this.Controls.Add(this.btn_update_emp);
            this.Controls.Add(this.text_emp_posi);
            this.Controls.Add(this.text_emp_name);
            this.Controls.Add(this.text_emp_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Employeemgr";
            this.Text = "Employeemgr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_emp_id;
        private System.Windows.Forms.TextBox text_emp_name;
        private System.Windows.Forms.TextBox text_emp_posi;
        private System.Windows.Forms.Button btn_update_emp;
        private System.Windows.Forms.Button btn_delete_emp;
        private System.Windows.Forms.Button btn_save_emp;
    }
}