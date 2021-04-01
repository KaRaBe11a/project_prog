
namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMagazines = new System.Windows.Forms.Button();
            this.buttonSklad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMagazines
            // 
            this.buttonMagazines.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMagazines.Location = new System.Drawing.Point(12, 12);
            this.buttonMagazines.Name = "buttonMagazines";
            this.buttonMagazines.Size = new System.Drawing.Size(130, 60);
            this.buttonMagazines.TabIndex = 0;
            this.buttonMagazines.Text = "Magazines";
            this.buttonMagazines.UseVisualStyleBackColor = true;
            this.buttonMagazines.Click += new System.EventHandler(this.buttonMagazines_Click);
            // 
            // buttonSklad
            // 
            this.buttonSklad.Location = new System.Drawing.Point(12, 78);
            this.buttonSklad.Name = "buttonSklad";
            this.buttonSklad.Size = new System.Drawing.Size(130, 60);
            this.buttonSklad.TabIndex = 1;
            this.buttonSklad.Text = "Sklad";
            this.buttonSklad.UseVisualStyleBackColor = true;
            this.buttonSklad.Click += new System.EventHandler(this.buttonSklad_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 277);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSklad);
            this.Controls.Add(this.buttonMagazines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMagazines;
        private System.Windows.Forms.Button buttonSklad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

