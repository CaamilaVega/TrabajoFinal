namespace TrabajoFinalIntegrador1
{
    partial class FormActualizar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(81, 133);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 20);
            this.textBox5.TabIndex = 4;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(132, 19);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 6;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(16, 52);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(16, 13);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "Id";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(16, 81);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(27, 13);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Title";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(16, 107);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(16, 133);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(49, 13);
            this.lbCategory.TabIndex = 8;
            this.lbCategory.Text = "Category";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(16, 159);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 8;
            this.lbDescription.Text = "Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDescription);
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.btActualizar);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(229, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 243);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FormActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormActualizar";
            this.Text = "FormActualizar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}