namespace CSharpClient
{
    partial class LoginForm
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
            this.UsernameTEXT = new System.Windows.Forms.TextBox();
            this.UsernameSendBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME:";
            // 
            // UsernameTEXT
            // 
            this.UsernameTEXT.Location = new System.Drawing.Point(174, 76);
            this.UsernameTEXT.Name = "UsernameTEXT";
            this.UsernameTEXT.Size = new System.Drawing.Size(223, 27);
            this.UsernameTEXT.TabIndex = 1;
            // 
            // UsernameSendBTN
            // 
            this.UsernameSendBTN.Location = new System.Drawing.Point(140, 179);
            this.UsernameSendBTN.Name = "UsernameSendBTN";
            this.UsernameSendBTN.Size = new System.Drawing.Size(196, 29);
            this.UsernameSendBTN.TabIndex = 2;
            this.UsernameSendBTN.Text = "Confirm";
            this.UsernameSendBTN.UseVisualStyleBackColor = true;
            this.UsernameSendBTN.Click += new System.EventHandler(this.UsernameSendBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 276);
            this.Controls.Add(this.UsernameSendBTN);
            this.Controls.Add(this.UsernameTEXT);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox UsernameTEXT;
        private Button UsernameSendBTN;
    }
}