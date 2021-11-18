
namespace CaloriesFromFatCalculator
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
            this.fatGramsLabel = new System.Windows.Forms.Label();
            this.fatGramsInput = new System.Windows.Forms.TextBox();
            this.carbGramsInput = new System.Windows.Forms.TextBox();
            this.carbGramLabel = new System.Windows.Forms.Label();
            this.calFromFatLabel = new System.Windows.Forms.Label();
            this.calFromFatOutput = new System.Windows.Forms.Label();
            this.calFromCarbOutput = new System.Windows.Forms.Label();
            this.calFromCarbLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatGramsLabel
            // 
            this.fatGramsLabel.AutoSize = true;
            this.fatGramsLabel.Location = new System.Drawing.Point(89, 101);
            this.fatGramsLabel.Name = "fatGramsLabel";
            this.fatGramsLabel.Size = new System.Drawing.Size(260, 32);
            this.fatGramsLabel.TabIndex = 0;
            this.fatGramsLabel.Text = "Enter Fat in Grams:";
            // 
            // fatGramsInput
            // 
            this.fatGramsInput.Location = new System.Drawing.Point(363, 95);
            this.fatGramsInput.Name = "fatGramsInput";
            this.fatGramsInput.Size = new System.Drawing.Size(160, 38);
            this.fatGramsInput.TabIndex = 1;
            // 
            // carbGramsInput
            // 
            this.carbGramsInput.Location = new System.Drawing.Point(363, 184);
            this.carbGramsInput.Name = "carbGramsInput";
            this.carbGramsInput.Size = new System.Drawing.Size(160, 38);
            this.carbGramsInput.TabIndex = 3;
            // 
            // carbGramLabel
            // 
            this.carbGramLabel.AutoSize = true;
            this.carbGramLabel.Location = new System.Drawing.Point(74, 190);
            this.carbGramLabel.Name = "carbGramLabel";
            this.carbGramLabel.Size = new System.Drawing.Size(280, 32);
            this.carbGramLabel.TabIndex = 2;
            this.carbGramLabel.Text = "Enter Carb in Grams:";
            // 
            // calFromFatLabel
            // 
            this.calFromFatLabel.AutoSize = true;
            this.calFromFatLabel.Location = new System.Drawing.Point(74, 274);
            this.calFromFatLabel.Name = "calFromFatLabel";
            this.calFromFatLabel.Size = new System.Drawing.Size(239, 32);
            this.calFromFatLabel.TabIndex = 4;
            this.calFromFatLabel.Text = "Calories from Fat:";
            // 
            // calFromFatOutput
            // 
            this.calFromFatOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calFromFatOutput.Location = new System.Drawing.Point(357, 274);
            this.calFromFatOutput.Name = "calFromFatOutput";
            this.calFromFatOutput.Size = new System.Drawing.Size(166, 32);
            this.calFromFatOutput.TabIndex = 5;
            // 
            // calFromCarbOutput
            // 
            this.calFromCarbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calFromCarbOutput.Location = new System.Drawing.Point(357, 359);
            this.calFromCarbOutput.Name = "calFromCarbOutput";
            this.calFromCarbOutput.Size = new System.Drawing.Size(166, 32);
            this.calFromCarbOutput.TabIndex = 7;
            // 
            // calFromCarbLabel
            // 
            this.calFromCarbLabel.AutoSize = true;
            this.calFromCarbLabel.Location = new System.Drawing.Point(74, 359);
            this.calFromCarbLabel.Name = "calFromCarbLabel";
            this.calFromCarbLabel.Size = new System.Drawing.Size(273, 32);
            this.calFromCarbLabel.TabIndex = 6;
            this.calFromCarbLabel.Text = "Calories from Carbs:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(80, 453);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(161, 65);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(357, 453);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 65);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 622);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.calFromCarbOutput);
            this.Controls.Add(this.calFromCarbLabel);
            this.Controls.Add(this.calFromFatOutput);
            this.Controls.Add(this.calFromFatLabel);
            this.Controls.Add(this.carbGramsInput);
            this.Controls.Add(this.carbGramLabel);
            this.Controls.Add(this.fatGramsInput);
            this.Controls.Add(this.fatGramsLabel);
            this.Name = "Form1";
            this.Text = "Calories From Fat and Carbs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatGramsLabel;
        private System.Windows.Forms.TextBox fatGramsInput;
        private System.Windows.Forms.TextBox carbGramsInput;
        private System.Windows.Forms.Label carbGramLabel;
        private System.Windows.Forms.Label calFromFatLabel;
        private System.Windows.Forms.Label calFromFatOutput;
        private System.Windows.Forms.Label calFromCarbOutput;
        private System.Windows.Forms.Label calFromCarbLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
    }
}

