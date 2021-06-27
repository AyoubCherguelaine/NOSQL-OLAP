
namespace OLAPFinal
{
    partial class NOSQLOLQP
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
            this.CloseB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Revenue = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.Produits = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.CloseB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(1220, 3);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(26, 24);
            this.CloseB.TabIndex = 1;
            this.CloseB.Text = "x";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOSQL OLAP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.Revenue);
            this.panel2.Controls.Add(this.Customer);
            this.panel2.Controls.Add(this.Produits);
            this.panel2.Controls.Add(this.OrdersButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 545);
            this.panel2.TabIndex = 1;
            // 
            // Revenue
            // 
            this.Revenue.Location = new System.Drawing.Point(3, 228);
            this.Revenue.Name = "Revenue";
            this.Revenue.Size = new System.Drawing.Size(154, 50);
            this.Revenue.TabIndex = 5;
            this.Revenue.Text = "Revenue";
            this.Revenue.UseVisualStyleBackColor = true;
            this.Revenue.Click += new System.EventHandler(this.Revenue_Click);
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(3, 172);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(154, 50);
            this.Customer.TabIndex = 4;
            this.Customer.Text = "Customers";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // Produits
            // 
            this.Produits.Location = new System.Drawing.Point(3, 116);
            this.Produits.Name = "Produits";
            this.Produits.Size = new System.Drawing.Size(154, 50);
            this.Produits.TabIndex = 3;
            this.Produits.Text = "Produits";
            this.Produits.UseVisualStyleBackColor = true;
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(3, 60);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(154, 50);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(54, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cube";
            // 
            // NOSQLOLQP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NOSQLOLQP";
            this.Text = "NoSQl OLAP";
            this.Load += new System.EventHandler(this.NOSQLOLQP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.Button Revenue;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Produits;
       private System.Windows.Forms.Button OrdersButton;
    }
}

