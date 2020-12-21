
namespace loopEX
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.rTBAnswers = new System.Windows.Forms.RichTextBox();
            this.bCalculation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rTBAnswer2 = new System.Windows.Forms.RichTextBox();
            this.tBNumber = new System.Windows.Forms.TextBox();
            this.bMake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1)";
            // 
            // tBInput
            // 
            this.tBInput.Location = new System.Drawing.Point(84, 66);
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(35, 20);
            this.tBInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a number and press add, repeat till the button is inactive and then press c" +
    "alculate";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(148, 66);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add ";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // rTBAnswers
            // 
            this.rTBAnswers.Location = new System.Drawing.Point(244, 66);
            this.rTBAnswers.Name = "rTBAnswers";
            this.rTBAnswers.Size = new System.Drawing.Size(93, 70);
            this.rTBAnswers.TabIndex = 4;
            this.rTBAnswers.Text = "";
            // 
            // bCalculation
            // 
            this.bCalculation.Location = new System.Drawing.Point(148, 113);
            this.bCalculation.Name = "bCalculation";
            this.bCalculation.Size = new System.Drawing.Size(75, 23);
            this.bCalculation.TabIndex = 5;
            this.bCalculation.Text = "Calculate";
            this.bCalculation.UseVisualStyleBackColor = true;
            this.bCalculation.Click += new System.EventHandler(this.bCalculation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2)";
            // 
            // rTBAnswer2
            // 
            this.rTBAnswer2.Location = new System.Drawing.Point(244, 219);
            this.rTBAnswer2.Name = "rTBAnswer2";
            this.rTBAnswer2.Size = new System.Drawing.Size(254, 194);
            this.rTBAnswer2.TabIndex = 7;
            this.rTBAnswer2.Text = "";
            // 
            // tBNumber
            // 
            this.tBNumber.Location = new System.Drawing.Point(84, 222);
            this.tBNumber.Name = "tBNumber";
            this.tBNumber.Size = new System.Drawing.Size(35, 20);
            this.tBNumber.TabIndex = 8;
            // 
            // bMake
            // 
            this.bMake.Location = new System.Drawing.Point(148, 222);
            this.bMake.Name = "bMake";
            this.bMake.Size = new System.Drawing.Size(75, 23);
            this.bMake.TabIndex = 9;
            this.bMake.Text = "Add ";
            this.bMake.UseVisualStyleBackColor = true;
            this.bMake.Click += new System.EventHandler(this.bMake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMake);
            this.Controls.Add(this.tBNumber);
            this.Controls.Add(this.rTBAnswer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCalculation);
            this.Controls.Add(this.rTBAnswers);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.RichTextBox rTBAnswers;
        private System.Windows.Forms.Button bCalculation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTBAnswer2;
        private System.Windows.Forms.TextBox tBNumber;
        private System.Windows.Forms.Button bMake;
    }
}

