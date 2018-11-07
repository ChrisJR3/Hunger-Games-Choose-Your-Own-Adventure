namespace Hunger_Games_Choose_Your_Own_Adventure
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.redLetterLabel = new System.Windows.Forms.Label();
            this.yellowLetterLabel = new System.Windows.Forms.Label();
            this.blueLetterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(-2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(658, 198);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(50, 328);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(282, 23);
            this.redLabel.TabIndex = 1;
            this.redLabel.Text = "Start?";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.blueLabel.Location = new System.Drawing.Point(50, 373);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(282, 23);
            this.blueLabel.TabIndex = 2;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.Color.Yellow;
            this.yellowLabel.Location = new System.Drawing.Point(50, 418);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(282, 23);
            this.yellowLabel.TabIndex = 5;
            this.yellowLabel.Visible = false;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(337, 253);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(369, 197);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 7;
            this.imageBox.TabStop = false;
            // 
            // redLetterLabel
            // 
            this.redLetterLabel.BackColor = System.Drawing.Color.Red;
            this.redLetterLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLetterLabel.ForeColor = System.Drawing.Color.White;
            this.redLetterLabel.Location = new System.Drawing.Point(-2, 328);
            this.redLetterLabel.Name = "redLetterLabel";
            this.redLetterLabel.Size = new System.Drawing.Size(31, 23);
            this.redLetterLabel.TabIndex = 8;
            this.redLetterLabel.Text = "M";
            this.redLetterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowLetterLabel
            // 
            this.yellowLetterLabel.BackColor = System.Drawing.Color.Olive;
            this.yellowLetterLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLetterLabel.ForeColor = System.Drawing.Color.White;
            this.yellowLetterLabel.Location = new System.Drawing.Point(-2, 418);
            this.yellowLetterLabel.Name = "yellowLetterLabel";
            this.yellowLetterLabel.Size = new System.Drawing.Size(31, 23);
            this.yellowLetterLabel.TabIndex = 9;
            this.yellowLetterLabel.Text = "N";
            this.yellowLetterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLetterLabel
            // 
            this.blueLetterLabel.BackColor = System.Drawing.Color.Teal;
            this.blueLetterLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLetterLabel.ForeColor = System.Drawing.Color.White;
            this.blueLetterLabel.Location = new System.Drawing.Point(-2, 373);
            this.blueLetterLabel.Name = "blueLetterLabel";
            this.blueLetterLabel.Size = new System.Drawing.Size(31, 23);
            this.blueLetterLabel.TabIndex = 10;
            this.blueLetterLabel.Text = "B";
            this.blueLetterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.blueLetterLabel);
            this.Controls.Add(this.yellowLetterLabel);
            this.Controls.Add(this.redLetterLabel);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hunger Games Choose Your Own Adventure";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label redLetterLabel;
        private System.Windows.Forms.Label yellowLetterLabel;
        private System.Windows.Forms.Label blueLetterLabel;
    }
}

