
namespace Project
{
    partial class FormSklad
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
            this.buttonRequests = new System.Windows.Forms.Button();
            this.listBoxRequests = new System.Windows.Forms.ListBox();
            this.comboBoxRequests = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRequests
            // 
            this.buttonRequests.Location = new System.Drawing.Point(12, 12);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(132, 51);
            this.buttonRequests.TabIndex = 0;
            this.buttonRequests.Text = "Requests";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // listBoxRequests
            // 
            this.listBoxRequests.FormattingEnabled = true;
            this.listBoxRequests.Location = new System.Drawing.Point(150, 12);
            this.listBoxRequests.Name = "listBoxRequests";
            this.listBoxRequests.Size = new System.Drawing.Size(268, 368);
            this.listBoxRequests.TabIndex = 1;
            // 
            // comboBoxRequests
            // 
            this.comboBoxRequests.FormattingEnabled = true;
            this.comboBoxRequests.Location = new System.Drawing.Point(444, 12);
            this.comboBoxRequests.Name = "comboBoxRequests";
            this.comboBoxRequests.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRequests.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(444, 48);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(121, 36);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // FormSklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.comboBoxRequests);
            this.Controls.Add(this.listBoxRequests);
            this.Controls.Add(this.buttonRequests);
            this.Name = "FormSklad";
            this.Text = "FormSklad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRequests;
        private System.Windows.Forms.ListBox listBoxRequests;
        private System.Windows.Forms.ComboBox comboBoxRequests;
        private System.Windows.Forms.Button buttonSend;
    }
}