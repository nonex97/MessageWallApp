namespace MessageWall
{
    partial class Dashboard
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
            messageLabel = new Label();
            messageText = new TextBox();
            messageListBox = new ListBox();
            messageListBoxLabel = new Label();
            addMessage = new Button();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.ForeColor = SystemColors.ControlLightLight;
            messageLabel.Location = new Point(11, 15);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(108, 32);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Message";
            // 
            // messageText
            // 
            messageText.Location = new Point(125, 12);
            messageText.Name = "messageText";
            messageText.Size = new Size(274, 39);
            messageText.TabIndex = 1;
            // 
            // messageListBox
            // 
            messageListBox.FormattingEnabled = true;
            messageListBox.Location = new Point(12, 143);
            messageListBox.Name = "messageListBox";
            messageListBox.Size = new Size(387, 260);
            messageListBox.TabIndex = 3;
            // 
            // messageListBoxLabel
            // 
            messageListBoxLabel.AutoSize = true;
            messageListBoxLabel.ForeColor = SystemColors.ControlLightLight;
            messageListBoxLabel.Location = new Point(11, 108);
            messageListBoxLabel.Name = "messageListBoxLabel";
            messageListBoxLabel.Size = new Size(118, 32);
            messageListBoxLabel.TabIndex = 0;
            messageListBoxLabel.Text = "Messages";
            // 
            // addMessage
            // 
            addMessage.Location = new Point(405, 12);
            addMessage.Name = "addMessage";
            addMessage.Size = new Size(103, 39);
            addMessage.TabIndex = 2;
            addMessage.Text = "Add";
            addMessage.UseVisualStyleBackColor = true;
            addMessage.Click += AddMessage_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(519, 415);
            Controls.Add(addMessage);
            Controls.Add(messageListBox);
            Controls.Add(messageText);
            Controls.Add(messageListBoxLabel);
            Controls.Add(messageLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Label messageLabel;
        private TextBox messageText;
        private ListBox messageListBox;
        private Label messageListBoxLabel;
        private Button addMessage;
    }
}
