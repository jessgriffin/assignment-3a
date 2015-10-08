namespace assignment_3a
{
    partial class frmPizza
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
            this.lblLargepizza = new System.Windows.Forms.Label();
            this.lblXLpizza = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblToppings = new System.Windows.Forms.Label();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLargepizza
            // 
            this.lblLargepizza.AutoSize = true;
            this.lblLargepizza.Location = new System.Drawing.Point(13, 13);
            this.lblLargepizza.Name = "lblLargepizza";
            this.lblLargepizza.Size = new System.Drawing.Size(80, 13);
            this.lblLargepizza.TabIndex = 0;
            this.lblLargepizza.Text = "Large Pizza = 1";
            // 
            // lblXLpizza
            // 
            this.lblXLpizza.AutoSize = true;
            this.lblXLpizza.Location = new System.Drawing.Point(16, 41);
            this.lblXLpizza.Name = "lblXLpizza";
            this.lblXLpizza.Size = new System.Drawing.Size(107, 13);
            this.lblXLpizza.TabIndex = 1;
            this.lblXLpizza.Text = "Extra Large Pizza = 2";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(167, 34);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(80, 20);
            this.nudSize.TabIndex = 2;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(19, 100);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(239, 13);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "Select how many toppings you would like (Max 4)";
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(113, 130);
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(58, 20);
            this.nudToppings.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(88, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(16, 158);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(67, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "SUBTOTAL:";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Location = new System.Drawing.Point(19, 185);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(32, 13);
            this.lblHST.TabIndex = 7;
            this.lblHST.Text = "HST:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(187, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL:";
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblXLpizza);
            this.Controls.Add(this.lblLargepizza);
            this.Name = "frmPizza";
            this.Text = "Pizza Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargepizza;
        private System.Windows.Forms.Label lblXLpizza;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotal;
    }
}

