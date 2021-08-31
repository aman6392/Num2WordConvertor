namespace CurrencyToWords
{
    partial class numToWords
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
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelCharDisp = new System.Windows.Forms.Label();
            this.labelLimitations = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelErrorText = new System.Windows.Forms.Label();
            this.textBoxCharDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(164, 81);
            this.textBoxNum.MaxLength = 14;
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(287, 20);
            this.textBoxNum.TabIndex = 1;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(12, 82);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(146, 16);
            this.labelNum.TabIndex = 1001;
            this.labelNum.Text = "Please enter a number:";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(164, 328);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(376, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeading
            // 
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(63, 9);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(369, 29);
            this.labelHeading.TabIndex = 1000;
            this.labelHeading.Text = "Hexagon Mining: Cheque Writing Program";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCharDisp
            // 
            this.labelCharDisp.AutoSize = true;
            this.labelCharDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharDisp.Location = new System.Drawing.Point(12, 147);
            this.labelCharDisp.Name = "labelCharDisp";
            this.labelCharDisp.Size = new System.Drawing.Size(124, 16);
            this.labelCharDisp.TabIndex = 1002;
            this.labelCharDisp.Text = "Converted Number:";
            this.labelCharDisp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelLimitations
            // 
            this.labelLimitations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLimitations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimitations.Location = new System.Drawing.Point(12, 394);
            this.labelLimitations.Name = "labelLimitations";
            this.labelLimitations.Size = new System.Drawing.Size(439, 93);
            this.labelLimitations.TabIndex = 1006;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(12, 257);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(55, 16);
            this.labelError.TabIndex = 1003;
            this.labelError.Text = "Error(s):";
            // 
            // labelErrorText
            // 
            this.labelErrorText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorText.Location = new System.Drawing.Point(161, 256);
            this.labelErrorText.Name = "labelErrorText";
            this.labelErrorText.Size = new System.Drawing.Size(290, 38);
            this.labelErrorText.TabIndex = 1005;
            // 
            // textBoxCharDisplay
            // 
            this.textBoxCharDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCharDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCharDisplay.Location = new System.Drawing.Point(161, 147);
            this.textBoxCharDisplay.Multiline = true;
            this.textBoxCharDisplay.Name = "textBoxCharDisplay";
            this.textBoxCharDisplay.ReadOnly = true;
            this.textBoxCharDisplay.Size = new System.Drawing.Size(287, 93);
            this.textBoxCharDisplay.TabIndex = 1004;
            // 
            // numToWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 499);
            this.Controls.Add(this.textBoxCharDisplay);
            this.Controls.Add(this.labelErrorText);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelLimitations);
            this.Controls.Add(this.labelCharDisp);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxNum);
            this.Name = "numToWords";
            this.Text = "Cheque Writing Program";
            this.Load += new System.EventHandler(this.numToWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelCharDisp;
        private System.Windows.Forms.Label labelLimitations;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorText;
        private System.Windows.Forms.TextBox textBoxCharDisplay;
    }
}

