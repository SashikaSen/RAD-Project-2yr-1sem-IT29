
namespace Tutorial_Symphony
{
    partial class FrmProducts
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
            this.label_prdct_id = new System.Windows.Forms.Label();
            this.text_prdct_id = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.lable_prdct_name = new System.Windows.Forms.Label();
            this.text_prdct_name = new System.Windows.Forms.TextBox();
            this.lbl_prdct_stock = new System.Windows.Forms.Label();
            this.text_prdct_stock = new System.Windows.Forms.TextBox();
            this.lbl_prdct_unitprice = new System.Windows.Forms.Label();
            this.text_prdct_unitprice = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(765, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_prdct_id
            // 
            this.label_prdct_id.AutoSize = true;
            this.label_prdct_id.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prdct_id.Location = new System.Drawing.Point(18, 89);
            this.label_prdct_id.Name = "label_prdct_id";
            this.label_prdct_id.Size = new System.Drawing.Size(87, 27);
            this.label_prdct_id.TabIndex = 2;
            this.label_prdct_id.Text = "Product ID";
            // 
            // text_prdct_id
            // 
            this.text_prdct_id.Location = new System.Drawing.Point(148, 89);
            this.text_prdct_id.Name = "text_prdct_id";
            this.text_prdct_id.Size = new System.Drawing.Size(237, 22);
            this.text_prdct_id.TabIndex = 3;
            this.text_prdct_id.TextChanged += new System.EventHandler(this.text_prdct_id_TextChanged);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.Snow;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_button.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Save_button.Location = new System.Drawing.Point(499, 257);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 30);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.Snow;
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Update.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Button_Update.Location = new System.Drawing.Point(580, 257);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(75, 30);
            this.Button_Update.TabIndex = 5;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.Snow;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Delete.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.ForeColor = System.Drawing.Color.Crimson;
            this.Button_Delete.Location = new System.Drawing.Point(661, 257);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 30);
            this.Button_Delete.TabIndex = 6;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // lable_prdct_name
            // 
            this.lable_prdct_name.AutoSize = true;
            this.lable_prdct_name.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_prdct_name.Location = new System.Drawing.Point(18, 127);
            this.lable_prdct_name.Name = "lable_prdct_name";
            this.lable_prdct_name.Size = new System.Drawing.Size(113, 27);
            this.lable_prdct_name.TabIndex = 7;
            this.lable_prdct_name.Text = "Product Name";
            this.lable_prdct_name.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_prdct_name
            // 
            this.text_prdct_name.Location = new System.Drawing.Point(148, 127);
            this.text_prdct_name.Name = "text_prdct_name";
            this.text_prdct_name.Size = new System.Drawing.Size(237, 22);
            this.text_prdct_name.TabIndex = 8;
            this.text_prdct_name.TextChanged += new System.EventHandler(this.text_prdct_name_TextChanged);
            // 
            // lbl_prdct_stock
            // 
            this.lbl_prdct_stock.AutoSize = true;
            this.lbl_prdct_stock.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prdct_stock.Location = new System.Drawing.Point(18, 164);
            this.lbl_prdct_stock.Name = "lbl_prdct_stock";
            this.lbl_prdct_stock.Size = new System.Drawing.Size(50, 27);
            this.lbl_prdct_stock.TabIndex = 9;
            this.lbl_prdct_stock.Text = "Stock";
            // 
            // text_prdct_stock
            // 
            this.text_prdct_stock.Location = new System.Drawing.Point(148, 169);
            this.text_prdct_stock.Name = "text_prdct_stock";
            this.text_prdct_stock.Size = new System.Drawing.Size(237, 22);
            this.text_prdct_stock.TabIndex = 10;
            // 
            // lbl_prdct_unitprice
            // 
            this.lbl_prdct_unitprice.AutoSize = true;
            this.lbl_prdct_unitprice.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prdct_unitprice.Location = new System.Drawing.Point(18, 206);
            this.lbl_prdct_unitprice.Name = "lbl_prdct_unitprice";
            this.lbl_prdct_unitprice.Size = new System.Drawing.Size(80, 27);
            this.lbl_prdct_unitprice.TabIndex = 11;
            this.lbl_prdct_unitprice.Text = "Unit Price";
            // 
            // text_prdct_unitprice
            // 
            this.text_prdct_unitprice.Location = new System.Drawing.Point(148, 211);
            this.text_prdct_unitprice.Name = "text_prdct_unitprice";
            this.text_prdct_unitprice.Size = new System.Drawing.Size(237, 22);
            this.text_prdct_unitprice.TabIndex = 12;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 299);
            this.Controls.Add(this.text_prdct_unitprice);
            this.Controls.Add(this.lbl_prdct_unitprice);
            this.Controls.Add(this.text_prdct_stock);
            this.Controls.Add(this.lbl_prdct_stock);
            this.Controls.Add(this.text_prdct_name);
            this.Controls.Add(this.lable_prdct_name);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.text_prdct_id);
            this.Controls.Add(this.label_prdct_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Manager";
            this.Load += new System.EventHandler(this.Form_Product_manager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_prdct_id;
        private System.Windows.Forms.TextBox text_prdct_id;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Label lable_prdct_name;
        private System.Windows.Forms.TextBox text_prdct_name;
        private System.Windows.Forms.Label lbl_prdct_stock;
        private System.Windows.Forms.TextBox text_prdct_stock;
        private System.Windows.Forms.Label lbl_prdct_unitprice;
        private System.Windows.Forms.TextBox text_prdct_unitprice;
    }
}