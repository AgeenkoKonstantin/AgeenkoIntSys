namespace CSharpClient
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
            this.UsersLB = new System.Windows.Forms.ListBox();
            this.MessagesLB = new System.Windows.Forms.ListBox();
            this.MessageBOX = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersLB
            // 
            this.UsersLB.FormattingEnabled = true;
            this.UsersLB.ItemHeight = 20;
            this.UsersLB.Location = new System.Drawing.Point(16, 16);
            this.UsersLB.Name = "UsersLB";
            this.UsersLB.Size = new System.Drawing.Size(148, 384);
            this.UsersLB.TabIndex = 0;
            // 
            // MessagesLB
            // 
            this.MessagesLB.FormattingEnabled = true;
            this.MessagesLB.ItemHeight = 20;
            this.MessagesLB.Location = new System.Drawing.Point(180, 21);
            this.MessagesLB.Name = "MessagesLB";
            this.MessagesLB.Size = new System.Drawing.Size(575, 384);
            this.MessagesLB.TabIndex = 1;
            // 
            // MessageBOX
            // 
            this.MessageBOX.Location = new System.Drawing.Point(185, 413);
            this.MessageBOX.Name = "MessageBOX";
            this.MessageBOX.Size = new System.Drawing.Size(480, 27);
            this.MessageBOX.TabIndex = 2;
            // 
            // SendBTN
            // 
            this.SendBTN.Location = new System.Drawing.Point(671, 413);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(94, 29);
            this.SendBTN.TabIndex = 3;
            this.SendBTN.Text = "Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.MessageBOX);
            this.Controls.Add(this.MessagesLB);
            this.Controls.Add(this.UsersLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox UsersLB;
        private ListBox MessagesLB;
        private TextBox MessageBOX;
        private Button SendBTN;
    }
}