namespace FoodOrder.Winform.Pages
{
    partial class AddProductForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categorySelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(370, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Saqlash";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(184, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chiqish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mahsulot nomi";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(30, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(287, 43);
            this.name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mahsulot narxi";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(30, 162);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(287, 43);
            this.price.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(370, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mahsulot batafsil";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(370, 53);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(287, 266);
            this.description.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mahsulot kategoriyasi";
            // 
            // categorySelect
            // 
            this.categorySelect.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorySelect.FormattingEnabled = true;
            this.categorySelect.Location = new System.Drawing.Point(30, 274);
            this.categorySelect.Name = "categorySelect";
            this.categorySelect.Size = new System.Drawing.Size(287, 45);
            this.categorySelect.TabIndex = 17;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 446);
            this.Controls.Add(this.categorySelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox name;
        private Label label2;
        private TextBox price;
        private Label label3;
        private TextBox description;
        private Label label6;
        private ComboBox categorySelect;
    }
}