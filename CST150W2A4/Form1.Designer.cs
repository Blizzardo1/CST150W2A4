
namespace CST150W2A4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.secondsTxt = new System.Windows.Forms.TextBox();
            this.timeBtn = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondsTxt
            // 
            this.secondsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondsTxt.Location = new System.Drawing.Point(69, 13);
            this.secondsTxt.Name = "secondsTxt";
            this.secondsTxt.Size = new System.Drawing.Size(622, 23);
            this.secondsTxt.TabIndex = 0;
            // 
            // timeBtn
            // 
            this.timeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBtn.Location = new System.Drawing.Point(697, 12);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(75, 23);
            this.timeBtn.TabIndex = 1;
            this.timeBtn.Text = "Show Time";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // flp
            // 
            this.flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp.Location = new System.Drawing.Point(12, 42);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(760, 307);
            this.flp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seconds";
            // 
            // Form1
            // 
            this.AcceptButton = this.timeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.secondsTxt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(540, 250);
            this.Name = "Form1";
            this.Text = "Tine Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondsTxt;
        private System.Windows.Forms.Button timeBtn;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Label label1;
    }
}

