namespace FInalProglang
{
    partial class BmiCalculator
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBoxHeight = new TextBox();
            label5 = new Label();
            TextBoxWeight = new TextBox();
            label6 = new Label();
            CalculateBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 29);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Food Recommendation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(288, 57);
            label2.Name = "label2";
            label2.Size = new Size(231, 29);
            label2.TabIndex = 10;
            label2.Text = " Calulate your BMI.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(99, 130);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 11;
            label3.Text = "Enter your Height:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(99, 203);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 12;
            label4.Text = "Enter your Weight:";
            // 
            // TextBoxHeight
            // 
            TextBoxHeight.Location = new Point(282, 135);
            TextBoxHeight.Name = "TextBoxHeight";
            TextBoxHeight.Size = new Size(240, 23);
            TextBoxHeight.TabIndex = 13;
            TextBoxHeight.TextChanged += TextBoxHeight_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(549, 135);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 14;
            label5.Text = "Centimeters";
            // 
            // TextBoxWeight
            // 
            TextBoxWeight.Location = new Point(282, 203);
            TextBoxWeight.Name = "TextBoxWeight";
            TextBoxWeight.Size = new Size(240, 23);
            TextBoxWeight.TabIndex = 15;
            TextBoxWeight.TextChanged += TextBoxWeight_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(549, 198);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 16;
            label6.Text = "Kilograms";
            // 
            // CalculateBtn
            // 
            CalculateBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateBtn.Location = new Point(537, 296);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(126, 59);
            CalculateBtn.TabIndex = 17;
            CalculateBtn.Text = "CALCULATE";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // BmiCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculateBtn);
            Controls.Add(label6);
            Controls.Add(TextBoxWeight);
            Controls.Add(label5);
            Controls.Add(TextBoxHeight);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BmiCalculator";
            Text = "BmiCalculator";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextBoxHeight;
        private Label label5;
        private TextBox TextBoxWeight;
        private Label label6;
        private Button CalculateBtn;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}