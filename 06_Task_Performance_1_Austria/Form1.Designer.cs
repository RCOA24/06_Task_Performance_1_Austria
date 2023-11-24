namespace _06_Task_Performance_1_Austria
{
    partial class FrmBasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.BT1 = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // CB1
            // 
            this.CB1.FormattingEnabled = true;
            this.CB1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CB1.Location = new System.Drawing.Point(102, 111);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(121, 21);
            this.CB1.TabIndex = 1;
            // 
            // BT1
            // 
            this.BT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT1.Location = new System.Drawing.Point(56, 346);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(221, 55);
            this.BT1.TabIndex = 2;
            this.BT1.Text = "Compute";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB1
            // 
            this.TB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB1.Location = new System.Drawing.Point(56, 71);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(221, 34);
            this.TB1.TabIndex = 3;
            this.TB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB2
            // 
            this.TB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.TB2.Location = new System.Drawing.Point(56, 138);
            this.TB2.Multiline = true;
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(221, 34);
            this.TB2.TabIndex = 4;
            this.TB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB3
            // 
            this.TB3.BackColor = System.Drawing.SystemColors.MenuText;
            this.TB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TB3.Location = new System.Drawing.Point(56, 192);
            this.TB3.Multiline = true;
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(221, 148);
            this.TB3.TabIndex = 5;
            this.TB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmBasicCalculator";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
    }
}

