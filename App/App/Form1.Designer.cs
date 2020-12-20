
namespace App
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
            this.sizeLabel = new System.Windows.Forms.Label();
            this.inputSizeBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(13, 13);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(96, 15);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "Введите размер:";
            // 
            // inputSizeBox
            // 
            this.inputSizeBox.Location = new System.Drawing.Point(13, 32);
            this.inputSizeBox.Name = "inputSizeBox";
            this.inputSizeBox.Size = new System.Drawing.Size(100, 23);
            this.inputSizeBox.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(13, 95);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 15);
            this.infoLabel.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(119, 32);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(60, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(185, 31);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(69, 23);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Вывести";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(119, 62);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(135, 23);
            this.randomizeButton.TabIndex = 5;
            this.randomizeButton.Text = "Рандомизировать";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(260, 32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.inputSizeBox);
            this.Controls.Add(this.sizeLabel);
            this.Name = "Form1";
            this.Text = "Приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox inputSizeBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Button saveButton;
    }
}

