
namespace Tutorial_Symphony
{
    partial class FormBilling
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
            this.panelBilling = new System.Windows.Forms.Panel();
            this.dgprdctlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprdctlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBilling
            // 
            this.panelBilling.BackColor = System.Drawing.Color.SlateBlue;
            this.panelBilling.Controls.Add(this.label1);
            this.panelBilling.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBilling.Location = new System.Drawing.Point(0, 0);
            this.panelBilling.Name = "panelBilling";
            this.panelBilling.Size = new System.Drawing.Size(1080, 63);
            this.panelBilling.TabIndex = 1;
            this.panelBilling.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgprdctlist
            // 
            this.dgprdctlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprdctlist.Location = new System.Drawing.Point(12, 117);
            this.dgprdctlist.Name = "dgprdctlist";
            this.dgprdctlist.RowHeadersWidth = 51;
            this.dgprdctlist.RowTemplate.Height = 24;
            this.dgprdctlist.Size = new System.Drawing.Size(399, 325);
            this.dgprdctlist.TabIndex = 2;
            this.dgprdctlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprdctlist_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(136, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product List";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgprdctlist);
            this.Controls.Add(this.panelBilling);
            this.Name = "FormBilling";
            this.Text = "FormBilling";
            this.panelBilling.ResumeLayout(false);
            this.panelBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprdctlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBilling;
        private System.Windows.Forms.DataGridView dgprdctlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}