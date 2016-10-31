namespace If_Formative_1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.signOutputLabel = new System.Windows.Forms.Label();
            this.divideOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Location = new System.Drawing.Point(36, 55);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(81, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Enter a Number";
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(124, 55);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(100, 20);
            this.inputTextbox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(136, 93);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // signOutputLabel
            // 
            this.signOutputLabel.AutoSize = true;
            this.signOutputLabel.Location = new System.Drawing.Point(39, 141);
            this.signOutputLabel.Name = "signOutputLabel";
            this.signOutputLabel.Size = new System.Drawing.Size(90, 13);
            this.signOutputLabel.TabIndex = 3;
            this.signOutputLabel.Text = "signOutputLabel1";
            // 
            // divideOutputLabel
            // 
            this.divideOutputLabel.AutoSize = true;
            this.divideOutputLabel.Location = new System.Drawing.Point(39, 175);
            this.divideOutputLabel.Name = "divideOutputLabel";
            this.divideOutputLabel.Size = new System.Drawing.Size(89, 13);
            this.divideOutputLabel.TabIndex = 4;
            this.divideOutputLabel.Text = "divideOutputlabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.divideOutputLabel);
            this.Controls.Add(this.signOutputLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label signOutputLabel;
        private System.Windows.Forms.Label divideOutputLabel;
    }
}

