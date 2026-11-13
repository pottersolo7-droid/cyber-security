using System.Drawing;
using System.Windows.Forms;

namespace CybersecurityBotGUI
{
    partial class ChatBotForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtAsciiArt = new TextBox();
            pnlChatContainer = new Panel();
            flowChat = new FlowLayoutPanel();
            txtUserInput = new TextBox();
            btnSend = new Button();
            btnViewTasks = new Button();
            btnQuiz = new Button();
            btnActivityLog = new Button();
            btnClearChat = new Button();
            pnlChatContainer.SuspendLayout();
            SuspendLayout();
            // 
            // txtAsciiArt
            // 
            txtAsciiArt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAsciiArt.BackColor = Color.Black;
            txtAsciiArt.Font = new Font("Consolas", 8F);
            txtAsciiArt.ForeColor = Color.Magenta;
            txtAsciiArt.Location = new Point(12, 12);
            txtAsciiArt.Margin = new Padding(4, 3, 4, 3);
            txtAsciiArt.Multiline = true;
            txtAsciiArt.Name = "txtAsciiArt";
            txtAsciiArt.ReadOnly = true;
            txtAsciiArt.Size = new Size(760, 183);
            txtAsciiArt.TabIndex = 7;
            // 
            // pnlChatContainer
            // 
            pnlChatContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChatContainer.AutoScroll = true;
            pnlChatContainer.BackColor = Color.FromArgb(240, 240, 240);
            pnlChatContainer.Controls.Add(flowChat);
            pnlChatContainer.Location = new Point(12, 201);
            pnlChatContainer.Margin = new Padding(4, 3, 4, 3);
            pnlChatContainer.Name = "pnlChatContainer";
            pnlChatContainer.Size = new Size(760, 108);
            pnlChatContainer.TabIndex = 6;
            // 
            // flowChat
            // 
            flowChat.AutoSize = true;
            flowChat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowChat.BackColor = Color.FromArgb(240, 240, 240);
            flowChat.FlowDirection = FlowDirection.TopDown;
            flowChat.Location = new Point(0, 0);
            flowChat.Margin = new Padding(4, 3, 4, 3);
            flowChat.Name = "flowChat";
            flowChat.Size = new Size(0, 0);
            flowChat.TabIndex = 0;
            flowChat.WrapContents = false;
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtUserInput.Font = new Font("Segoe UI", 10F);
            txtUserInput.Location = new Point(12, 320);
            txtUserInput.Margin = new Padding(4, 3, 4, 3);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(500, 25);
            txtUserInput.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSend.BackColor = Color.FromArgb(0, 132, 255);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(520, 318);
            btnSend.Margin = new Padding(4, 3, 4, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 30);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnViewTasks
            // 
            btnViewTasks.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewTasks.BackColor = Color.FromArgb(0, 132, 255);
            btnViewTasks.FlatStyle = FlatStyle.Flat;
            btnViewTasks.ForeColor = Color.White;
            btnViewTasks.Location = new Point(12, 355);
            btnViewTasks.Margin = new Padding(4, 3, 4, 3);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(140, 35);
            btnViewTasks.TabIndex = 3;
            btnViewTasks.Text = "View Tasks";
            btnViewTasks.UseVisualStyleBackColor = false;
            btnViewTasks.Click += btnViewTasks_Click;
            // 
            // btnQuiz
            // 
            btnQuiz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuiz.BackColor = Color.FromArgb(255, 165, 0);
            btnQuiz.FlatStyle = FlatStyle.Flat;
            btnQuiz.ForeColor = Color.White;
            btnQuiz.Location = new Point(160, 355);
            btnQuiz.Margin = new Padding(4, 3, 4, 3);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(140, 35);
            btnQuiz.TabIndex = 2;
            btnQuiz.Text = "Quiz Game";
            btnQuiz.UseVisualStyleBackColor = false;
            btnQuiz.Click += btnQuiz_Click;
            // 
            // btnActivityLog
            // 
            btnActivityLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActivityLog.BackColor = Color.FromArgb(128, 128, 255);
            btnActivityLog.FlatStyle = FlatStyle.Flat;
            btnActivityLog.ForeColor = Color.White;
            btnActivityLog.Location = new Point(308, 355);
            btnActivityLog.Margin = new Padding(4, 3, 4, 3);
            btnActivityLog.Name = "btnActivityLog";
            btnActivityLog.Size = new Size(140, 35);
            btnActivityLog.TabIndex = 1;
            btnActivityLog.Text = "Activity Log";
            btnActivityLog.UseVisualStyleBackColor = false;
            btnActivityLog.Click += btnActivityLog_Click;
            // 
            // btnClearChat
            // 
            btnClearChat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearChat.BackColor = Color.FromArgb(255, 80, 80);
            btnClearChat.FlatStyle = FlatStyle.Flat;
            btnClearChat.ForeColor = Color.White;
            btnClearChat.Location = new Point(456, 355);
            btnClearChat.Margin = new Padding(4, 3, 4, 3);
            btnClearChat.Name = "btnClearChat";
            btnClearChat.Size = new Size(140, 35);
            btnClearChat.TabIndex = 0;
            btnClearChat.Text = "Clear Chat";
            btnClearChat.UseVisualStyleBackColor = false;
            btnClearChat.Click += btnClearChat_Click;
            // 
            // ChatBotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(800, 410);
            Controls.Add(btnClearChat);
            Controls.Add(btnActivityLog);
            Controls.Add(btnQuiz);
            Controls.Add(btnViewTasks);
            Controls.Add(btnSend);
            Controls.Add(txtUserInput);
            Controls.Add(pnlChatContainer);
            Controls.Add(txtAsciiArt);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChatBotForm";
            Text = "Cybersecurity Awareness Bot";
            pnlChatContainer.ResumeLayout(false);
            pnlChatContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtAsciiArt;
        private Panel pnlChatContainer;
        private FlowLayoutPanel flowChat;
        private TextBox txtUserInput;
        private Button btnSend;
        private Button btnViewTasks;
        private Button btnQuiz;
        private Button btnActivityLog;
        private Button btnClearChat;
    }
}