
namespace _10122020dzGuessTheNumber
{
    partial class Form1
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
            this.label_Info = new System.Windows.Forms.Label();
            this.numericUpDown_InputNumber = new System.Windows.Forms.NumericUpDown();
            this.button_TryToGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InputNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info.Location = new System.Drawing.Point(228, 128);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(345, 31);
            this.label_Info.TabIndex = 0;
            this.label_Info.Text = "Введите число от 0 до 100";
            // 
            // numericUpDown_InputNumber
            // 
            this.numericUpDown_InputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_InputNumber.Location = new System.Drawing.Point(340, 206);
            this.numericUpDown_InputNumber.Name = "numericUpDown_InputNumber";
            this.numericUpDown_InputNumber.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown_InputNumber.TabIndex = 1;
            this.numericUpDown_InputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_TryToGuess
            // 
            this.button_TryToGuess.AutoSize = true;
            this.button_TryToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TryToGuess.Location = new System.Drawing.Point(223, 291);
            this.button_TryToGuess.Name = "button_TryToGuess";
            this.button_TryToGuess.Size = new System.Drawing.Size(355, 41);
            this.button_TryToGuess.TabIndex = 2;
            this.button_TryToGuess.Text = "Угадать загаданное число";
            this.button_TryToGuess.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_TryToGuess);
            this.Controls.Add(this.numericUpDown_InputNumber);
            this.Controls.Add(this.label_Info);
            this.Name = "Form1";
            this.Text = "Я угадаю задуманное Вами число !";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InputNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.NumericUpDown numericUpDown_InputNumber;
        private System.Windows.Forms.Button button_TryToGuess;
    }
}

