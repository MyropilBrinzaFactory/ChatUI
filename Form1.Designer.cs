namespace ChatUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ipLocalBox = new System.Windows.Forms.TextBox();
            this.localPortBox = new System.Windows.Forms.TextBox();
            this.targetPortBox = new System.Windows.Forms.TextBox();
            this.messagesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Введи свой ник";
            this.nameTextBox.Size = new System.Drawing.Size(137, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(198, 431);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PlaceholderText = "Введи сообщение...";
            this.messageTextBox.Size = new System.Drawing.Size(334, 23);
            this.messageTextBox.TabIndex = 2;
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(303, 460);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(132, 40);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(628, 12);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.PlaceholderText = "Введите IP адрес";
            this.ipTextBox.Size = new System.Drawing.Size(160, 23);
            this.ipTextBox.TabIndex = 6;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(548, 111);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(115, 23);
            this.connectionButton.TabIndex = 7;
            this.connectionButton.Text = "Подключиться";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(628, 430);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить чат";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ipLocalBox
            // 
            this.ipLocalBox.Location = new System.Drawing.Point(427, 12);
            this.ipLocalBox.Name = "ipLocalBox";
            this.ipLocalBox.PlaceholderText = "Введи свой IP";
            this.ipLocalBox.Size = new System.Drawing.Size(150, 23);
            this.ipLocalBox.TabIndex = 9;
            // 
            // localPortBox
            // 
            this.localPortBox.Location = new System.Drawing.Point(427, 59);
            this.localPortBox.Name = "localPortBox";
            this.localPortBox.PlaceholderText = "Введи свой порт";
            this.localPortBox.Size = new System.Drawing.Size(150, 23);
            this.localPortBox.TabIndex = 10;
            // 
            // targetPortBox
            // 
            this.targetPortBox.Location = new System.Drawing.Point(628, 59);
            this.targetPortBox.Name = "targetPortBox";
            this.targetPortBox.PlaceholderText = "Введи порт подключения";
            this.targetPortBox.Size = new System.Drawing.Size(160, 23);
            this.targetPortBox.TabIndex = 11;
            // 
            // messagesBox
            // 
            this.messagesBox.FormattingEnabled = true;
            this.messagesBox.ItemHeight = 15;
            this.messagesBox.Location = new System.Drawing.Point(41, 153);
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.Size = new System.Drawing.Size(722, 259);
            this.messagesBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 527);
            this.Controls.Add(this.messagesBox);
            this.Controls.Add(this.targetPortBox);
            this.Controls.Add(this.localPortBox);
            this.Controls.Add(this.ipLocalBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "ChatUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private TextBox messageTextBox;
        private Button sendButton;
        private TextBox ipTextBox;
        private Button connectionButton;
        private Button clearButton;
        private TextBox ipLocalBox;
        private TextBox localPortBox;
        private TextBox targetPortBox;
        private ListBox messagesBox;
    }
}