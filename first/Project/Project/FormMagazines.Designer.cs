
namespace Project
{
    partial class FormMagazines
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
            this.comboBoxMagazines = new System.Windows.Forms.ComboBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonMakeRequest = new System.Windows.Forms.Button();
            this.comboBoxReceiveRequest = new System.Windows.Forms.ComboBox();
            this.buttonReceiveRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMagazines
            // 
            this.comboBoxMagazines.FormattingEnabled = true;
            this.comboBoxMagazines.Location = new System.Drawing.Point(27, 30);
            this.comboBoxMagazines.Name = "comboBoxMagazines";
            this.comboBoxMagazines.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMagazines.TabIndex = 0;
            this.comboBoxMagazines.SelectedIndexChanged += new System.EventHandler(this.comboBoxMagazines_SelectedIndexChanged);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(172, 30);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(188, 212);
            this.listBoxProducts.TabIndex = 1;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(407, 30);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducts.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(407, 57);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(121, 20);
            this.textBoxCount.TabIndex = 3;
            // 
            // buttonMakeRequest
            // 
            this.buttonMakeRequest.Location = new System.Drawing.Point(407, 84);
            this.buttonMakeRequest.Name = "buttonMakeRequest";
            this.buttonMakeRequest.Size = new System.Drawing.Size(121, 23);
            this.buttonMakeRequest.TabIndex = 4;
            this.buttonMakeRequest.Text = "MakeRequest";
            this.buttonMakeRequest.UseVisualStyleBackColor = true;
            this.buttonMakeRequest.Click += new System.EventHandler(this.buttonMakeRequest_Click);
            // 
            // comboBoxReceiveRequest
            // 
            this.comboBoxReceiveRequest.FormattingEnabled = true;
            this.comboBoxReceiveRequest.Location = new System.Drawing.Point(551, 30);
            this.comboBoxReceiveRequest.Name = "comboBoxReceiveRequest";
            this.comboBoxReceiveRequest.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReceiveRequest.TabIndex = 5;
            // 
            // buttonReceiveRequest
            // 
            this.buttonReceiveRequest.Location = new System.Drawing.Point(551, 57);
            this.buttonReceiveRequest.Name = "buttonReceiveRequest";
            this.buttonReceiveRequest.Size = new System.Drawing.Size(121, 23);
            this.buttonReceiveRequest.TabIndex = 7;
            this.buttonReceiveRequest.Text = "ReceiveRequest";
            this.buttonReceiveRequest.UseVisualStyleBackColor = true;
            this.buttonReceiveRequest.Click += new System.EventHandler(this.buttonReceiveRequest_Click);
            // 
            // FormMagazines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReceiveRequest);
            this.Controls.Add(this.comboBoxReceiveRequest);
            this.Controls.Add(this.buttonMakeRequest);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.comboBoxMagazines);
            this.Name = "FormMagazines";
            this.Text = "FormMagazines";
            this.Load += new System.EventHandler(this.FormMagazines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMagazines;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonMakeRequest;
        private System.Windows.Forms.ComboBox comboBoxReceiveRequest;
        private System.Windows.Forms.Button buttonReceiveRequest;
    }
}