namespace HappyCoding
{
    partial class Chat
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
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ConversationListBox = new System.Windows.Forms.ListBox();
            this.RecipientTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Someline Chat";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(478, 363);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(122, 52);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(29, 305);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(438, 106);
            this.MessageTextBox.TabIndex = 4;
            // 
            // ConversationListBox
            // 
            this.ConversationListBox.FormattingEnabled = true;
            this.ConversationListBox.Location = new System.Drawing.Point(29, 51);
            this.ConversationListBox.Name = "ConversationListBox";
            this.ConversationListBox.Size = new System.Drawing.Size(571, 238);
            this.ConversationListBox.TabIndex = 3;
            // 
            // RecipientTextBox
            // 
            this.RecipientTextBox.Location = new System.Drawing.Point(478, 326);
            this.RecipientTextBox.Name = "RecipientTextBox";
            this.RecipientTextBox.Size = new System.Drawing.Size(122, 20);
            this.RecipientTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Send to:";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecipientTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ConversationListBox);
            this.Controls.Add(this.label1);
            this.Name = "Chat";
            this.Text = "Someline Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.ListBox ConversationListBox;
        private System.Windows.Forms.TextBox RecipientTextBox;
        private System.Windows.Forms.Label label2;
    }
}

