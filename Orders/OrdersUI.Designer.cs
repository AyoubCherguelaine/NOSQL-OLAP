
namespace OLAPFinal.Orders
{
    partial class OrdersUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Pivot = new System.Windows.Forms.Button();
            this.Dice = new System.Windows.Forms.Button();
            this.Slice = new System.Windows.Forms.Button();
            this.Drill_Down = new System.Windows.Forms.Button();
            this.Roll_UP = new System.Windows.Forms.Button();
            this.Axe1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListAxe1 = new System.Windows.Forms.ListBox();
            this.DataCube = new System.Windows.Forms.DataGridView();
            this.Chemin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCube)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 25);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Pivot);
            this.panel2.Controls.Add(this.Dice);
            this.panel2.Controls.Add(this.Slice);
            this.panel2.Controls.Add(this.Drill_Down);
            this.panel2.Controls.Add(this.Roll_UP);
            this.panel2.Location = new System.Drawing.Point(944, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 529);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opperations";
            // 
            // Pivot
            // 
            this.Pivot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Pivot.Location = new System.Drawing.Point(3, 282);
            this.Pivot.Name = "Pivot";
            this.Pivot.Size = new System.Drawing.Size(125, 47);
            this.Pivot.TabIndex = 4;
            this.Pivot.Text = "Pivot";
            this.Pivot.UseVisualStyleBackColor = true;
            // 
            // Dice
            // 
            this.Dice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Dice.Location = new System.Drawing.Point(3, 229);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(125, 47);
            this.Dice.TabIndex = 3;
            this.Dice.Text = "Dice";
            this.Dice.UseVisualStyleBackColor = true;
            this.Dice.Click += new System.EventHandler(this.Dice_Click);
            // 
            // Slice
            // 
            this.Slice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Slice.Location = new System.Drawing.Point(3, 176);
            this.Slice.Name = "Slice";
            this.Slice.Size = new System.Drawing.Size(125, 47);
            this.Slice.TabIndex = 2;
            this.Slice.Text = "Slice";
            this.Slice.UseVisualStyleBackColor = true;
            this.Slice.Click += new System.EventHandler(this.Slice_Click);
            // 
            // Drill_Down
            // 
            this.Drill_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Drill_Down.Location = new System.Drawing.Point(3, 123);
            this.Drill_Down.Name = "Drill_Down";
            this.Drill_Down.Size = new System.Drawing.Size(125, 47);
            this.Drill_Down.TabIndex = 1;
            this.Drill_Down.Text = "Drill Down";
            this.Drill_Down.UseVisualStyleBackColor = true;
            this.Drill_Down.Click += new System.EventHandler(this.Drill_Down_Click);
            // 
            // Roll_UP
            // 
            this.Roll_UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Roll_UP.Location = new System.Drawing.Point(3, 70);
            this.Roll_UP.Name = "Roll_UP";
            this.Roll_UP.Size = new System.Drawing.Size(125, 47);
            this.Roll_UP.TabIndex = 0;
            this.Roll_UP.Text = "Roll UP";
            this.Roll_UP.UseVisualStyleBackColor = true;
            this.Roll_UP.Click += new System.EventHandler(this.Roll_UP_Click);
            // 
            // Axe1
            // 
            this.Axe1.AutoSize = true;
            this.Axe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Axe1.Location = new System.Drawing.Point(35, 15);
            this.Axe1.Name = "Axe1";
            this.Axe1.Size = new System.Drawing.Size(46, 20);
            this.Axe1.TabIndex = 1;
            this.Axe1.Text = "Axe1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.panel3.Controls.Add(this.ListAxe1);
            this.panel3.Controls.Add(this.Axe1);
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 506);
            this.panel3.TabIndex = 2;
            // 
            // ListAxe1
            // 
            this.ListAxe1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListAxe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ListAxe1.FormattingEnabled = true;
            this.ListAxe1.ItemHeight = 20;
            this.ListAxe1.Location = new System.Drawing.Point(3, 47);
            this.ListAxe1.Name = "ListAxe1";
            this.ListAxe1.Size = new System.Drawing.Size(223, 440);
            this.ListAxe1.Sorted = true;
            this.ListAxe1.TabIndex = 0;
            this.ListAxe1.Click += new System.EventHandler(this.ListAxe1_Click);
            // 
            // DataCube
            // 
            this.DataCube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCube.Location = new System.Drawing.Point(238, 70);
            this.DataCube.Name = "DataCube";
            this.DataCube.Size = new System.Drawing.Size(700, 459);
            this.DataCube.TabIndex = 3;
            this.DataCube.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCube_CellContentClick);
            // 
            // Chemin
            // 
            this.Chemin.AutoSize = true;
            this.Chemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Chemin.Location = new System.Drawing.Point(235, 38);
            this.Chemin.Name = "Chemin";
            this.Chemin.Size = new System.Drawing.Size(55, 17);
            this.Chemin.TabIndex = 2;
            this.Chemin.Text = "Chemin";
            // 
            // OrdersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Chemin);
            this.Controls.Add(this.DataCube);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersUI";
            this.Size = new System.Drawing.Size(1075, 533);
            this.Load += new System.EventHandler(this.OrdersUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Axe1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox ListAxe1;
        private System.Windows.Forms.DataGridView DataCube;
        private System.Windows.Forms.Label Chemin;
        private System.Windows.Forms.Button Roll_UP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Pivot;
        private System.Windows.Forms.Button Dice;
        private System.Windows.Forms.Button Slice;
        private System.Windows.Forms.Button Drill_Down;
    }
}
