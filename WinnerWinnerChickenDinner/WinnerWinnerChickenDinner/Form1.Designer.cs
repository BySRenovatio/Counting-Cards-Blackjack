namespace WinnerWinnerChickenDinner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxCards = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.richTextBoxSuggestions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxCards
            // 
            this.richTextBoxCards.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxCards.Name = "richTextBoxCards";
            this.richTextBoxCards.ReadOnly = true;
            this.richTextBoxCards.Size = new System.Drawing.Size(150, 280);
            this.richTextBoxCards.TabIndex = 1;
            this.richTextBoxCards.Text = "";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(3, 289);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(406, 26);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInput_KeyDown);
            // 
            // richTextBoxSuggestions
            // 
            this.richTextBoxSuggestions.Location = new System.Drawing.Point(159, 3);
            this.richTextBoxSuggestions.Name = "richTextBoxSuggestions";
            this.richTextBoxSuggestions.ReadOnly = true;
            this.richTextBoxSuggestions.Size = new System.Drawing.Size(250, 280);
            this.richTextBoxSuggestions.TabIndex = 2;
            this.richTextBoxSuggestions.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 321);
            this.Controls.Add(this.richTextBoxSuggestions);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.richTextBoxCards);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Wins Wins Wins";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCards;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxSuggestions;
    }
}

