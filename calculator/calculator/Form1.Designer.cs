﻿namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.firstValue = new System.Windows.Forms.TextBox();
            this.secondValue = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.PowerTwoArguments = new System.Windows.Forms.Button();
            this.PowerOfDivision = new System.Windows.Forms.Button();
            this.logTwoArguments = new System.Windows.Forms.Button();
            this.MIN = new System.Windows.Forms.Button();
            this.MAX = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Geometric = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.LogOfExp = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.TwoPowerValues = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.Log2 = new System.Windows.Forms.Button();
            this.DivisionByArgument = new System.Windows.Forms.Button();
            this.Absolute = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Cursor = System.Windows.Forms.Cursors.Default;
            this.Plus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Plus.Location = new System.Drawing.Point(218, 84);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(24, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(246, 84);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(25, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(277, 84);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(22, 23);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(218, 113);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(24, 23);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Label1_Click);
            // 
            // firstValue
            // 
            this.firstValue.Location = new System.Drawing.Point(24, 44);
            this.firstValue.Multiline = true;
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(129, 36);
            this.firstValue.TabIndex = 4;
            // 
            // secondValue
            // 
            this.secondValue.Location = new System.Drawing.Point(174, 44);
            this.secondValue.Multiline = true;
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(127, 36);
            this.secondValue.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(354, 44);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(83, 36);
            this.Result.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(327, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Первое значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Второе значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результат";
            // 
            // SquareRoot
            // 
            this.SquareRoot.Location = new System.Drawing.Point(27, 86);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(27, 21);
            this.SquareRoot.TabIndex = 11;
            this.SquareRoot.Text = "√";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Power
            // 
            this.Power.BackgroundImage = global::calculator.Properties.Resources._57519890e6de315516bbf632;
            this.Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Power.ForeColor = System.Drawing.SystemColors.Control;
            this.Power.Location = new System.Drawing.Point(35, 120);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(137, 91);
            this.Power.TabIndex = 12;
            this.Power.Text = "x^2";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Label2_Click);
            // 
            // PowerTwoArguments
            // 
            this.PowerTwoArguments.Location = new System.Drawing.Point(248, 113);
            this.PowerTwoArguments.Name = "PowerTwoArguments";
            this.PowerTwoArguments.Size = new System.Drawing.Size(53, 23);
            this.PowerTwoArguments.TabIndex = 13;
            this.PowerTwoArguments.Text = "x^y";
            this.PowerTwoArguments.UseVisualStyleBackColor = true;
            this.PowerTwoArguments.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PowerOfDivision
            // 
            this.PowerOfDivision.Location = new System.Drawing.Point(218, 142);
            this.PowerOfDivision.Name = "PowerOfDivision";
            this.PowerOfDivision.Size = new System.Drawing.Size(53, 23);
            this.PowerOfDivision.TabIndex = 14;
            this.PowerOfDivision.Text = "x^(1/y)";
            this.PowerOfDivision.UseVisualStyleBackColor = true;
            this.PowerOfDivision.Click += new System.EventHandler(this.Label1_Click);
            // 
            // logTwoArguments
            // 
            this.logTwoArguments.Location = new System.Drawing.Point(218, 171);
            this.logTwoArguments.Name = "logTwoArguments";
            this.logTwoArguments.Size = new System.Drawing.Size(53, 23);
            this.logTwoArguments.TabIndex = 15;
            this.logTwoArguments.Text = "LOGx(y)";
            this.logTwoArguments.UseVisualStyleBackColor = true;
            this.logTwoArguments.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MIN
            // 
            this.MIN.Location = new System.Drawing.Point(277, 142);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(53, 23);
            this.MIN.TabIndex = 16;
            this.MIN.Text = "Min";
            this.MIN.UseVisualStyleBackColor = true;
            this.MIN.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MAX
            // 
            this.MAX.Location = new System.Drawing.Point(277, 171);
            this.MAX.Name = "MAX";
            this.MAX.Size = new System.Drawing.Size(53, 23);
            this.MAX.TabIndex = 17;
            this.MAX.Text = "Max";
            this.MAX.UseVisualStyleBackColor = true;
            this.MAX.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(305, 84);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(61, 23);
            this.Average.TabIndex = 18;
            this.Average.Text = "Ср.ариф";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Geometric
            // 
            this.Geometric.Location = new System.Drawing.Point(307, 113);
            this.Geometric.Name = "Geometric";
            this.Geometric.Size = new System.Drawing.Size(61, 23);
            this.Geometric.TabIndex = 19;
            this.Geometric.Text = "Ср.геом";
            this.Geometric.UseVisualStyleBackColor = true;
            this.Geometric.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(336, 142);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(61, 23);
            this.Division.TabIndex = 20;
            this.Division.Text = "Div";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Modulo
            // 
            this.Modulo.Location = new System.Drawing.Point(336, 171);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(61, 23);
            this.Modulo.TabIndex = 21;
            this.Modulo.Text = "Mod";
            this.Modulo.UseVisualStyleBackColor = true;
            this.Modulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(60, 89);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(53, 23);
            this.Sinus.TabIndex = 22;
            this.Sinus.Text = "Sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(119, 89);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(53, 23);
            this.Cosinus.TabIndex = 23;
            this.Cosinus.Text = "Cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.Label2_Click);
            // 
            // LogOfExp
            // 
            this.LogOfExp.Location = new System.Drawing.Point(26, 219);
            this.LogOfExp.Name = "LogOfExp";
            this.LogOfExp.Size = new System.Drawing.Size(53, 23);
            this.LogOfExp.TabIndex = 24;
            this.LogOfExp.Text = "Ln";
            this.LogOfExp.UseVisualStyleBackColor = true;
            this.LogOfExp.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Exponent
            // 
            this.Exponent.Location = new System.Drawing.Point(85, 219);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(39, 21);
            this.Exponent.TabIndex = 25;
            this.Exponent.Text = "e^x";
            this.Exponent.UseVisualStyleBackColor = true;
            this.Exponent.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Tangent
            // 
            this.Tangent.Location = new System.Drawing.Point(130, 217);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(53, 23);
            this.Tangent.TabIndex = 26;
            this.Tangent.Text = "Tan";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.Label2_Click);
            // 
            // TwoPowerValues
            // 
            this.TwoPowerValues.Location = new System.Drawing.Point(133, 277);
            this.TwoPowerValues.Name = "TwoPowerValues";
            this.TwoPowerValues.Size = new System.Drawing.Size(53, 23);
            this.TwoPowerValues.TabIndex = 27;
            this.TwoPowerValues.Text = "2^x";
            this.TwoPowerValues.UseVisualStyleBackColor = true;
            this.TwoPowerValues.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(26, 248);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(53, 23);
            this.Log10.TabIndex = 28;
            this.Log10.Text = "Log10";
            this.Log10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Log2
            // 
            this.Log2.Location = new System.Drawing.Point(26, 277);
            this.Log2.Name = "Log2";
            this.Log2.Size = new System.Drawing.Size(53, 23);
            this.Log2.TabIndex = 29;
            this.Log2.Text = "Log2";
            this.Log2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Log2.UseVisualStyleBackColor = true;
            this.Log2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // DivisionByArgument
            // 
            this.DivisionByArgument.Location = new System.Drawing.Point(85, 249);
            this.DivisionByArgument.Name = "DivisionByArgument";
            this.DivisionByArgument.Size = new System.Drawing.Size(39, 21);
            this.DivisionByArgument.TabIndex = 30;
            this.DivisionByArgument.Text = "1/x";
            this.DivisionByArgument.UseVisualStyleBackColor = true;
            this.DivisionByArgument.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Absolute
            // 
            this.Absolute.Location = new System.Drawing.Point(85, 279);
            this.Absolute.Name = "Absolute";
            this.Absolute.Size = new System.Drawing.Size(39, 21);
            this.Absolute.TabIndex = 31;
            this.Absolute.Text = "|x|";
            this.Absolute.UseVisualStyleBackColor = true;
            this.Absolute.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(133, 249);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(39, 21);
            this.Negative.TabIndex = 32;
            this.Negative.Text = "-x";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(571, 361);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Absolute);
            this.Controls.Add(this.DivisionByArgument);
            this.Controls.Add(this.Log2);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.TwoPowerValues);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.LogOfExp);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Geometric);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.MAX);
            this.Controls.Add(this.MIN);
            this.Controls.Add(this.logTwoArguments);
            this.Controls.Add(this.PowerOfDivision);
            this.Controls.Add(this.PowerTwoArguments);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.firstValue);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox firstValue;
        private System.Windows.Forms.TextBox secondValue;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button PowerTwoArguments;
        private System.Windows.Forms.Button PowerOfDivision;
        private System.Windows.Forms.Button logTwoArguments;
        private System.Windows.Forms.Button MIN;
        private System.Windows.Forms.Button MAX;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Geometric;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Modulo;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button LogOfExp;
        private System.Windows.Forms.Button Exponent;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button TwoPowerValues;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Log2;
        private System.Windows.Forms.Button DivisionByArgument;
        private System.Windows.Forms.Button Absolute;
        private System.Windows.Forms.Button Negative;
    }
}