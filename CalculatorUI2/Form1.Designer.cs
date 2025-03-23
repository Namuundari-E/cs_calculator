namespace CalculatorUI2
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
            btn0 = new Button();
            txtDisplay = new TextBox();
            btnBack = new Button();
            btnCE = new Button();
            btnPM = new Button();
            btnC = new Button();
            btnAdd = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDivide = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSubstract = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiply = new Button();
            btnResult = new Button();
            btnDot = new Button();
            listBox = new ListBox();
            btnMemoryClear = new Button();
            btnMemoryRecall = new Button();
            btnMemorySave = new Button();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 16F);
            btn0.Location = new Point(45, 377);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 42);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.Window;
            txtDisplay.Font = new Font("Microsoft Sans Serif", 30F);
            txtDisplay.Location = new Point(45, 30);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(316, 50);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 16F);
            btnBack.Location = new Point(45, 141);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(67, 42);
            btnBack.TabIndex = 1;
            btnBack.Text = "⌫";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Backspace_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Microsoft Sans Serif", 16F);
            btnCE.Location = new Point(126, 141);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(67, 42);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Microsoft Sans Serif", 16F);
            btnPM.Location = new Point(294, 141);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(67, 42);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Microsoft Sans Serif", 16F);
            btnC.Location = new Point(213, 141);
            btnC.Name = "btnC";
            btnC.Size = new Size(67, 42);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 16F);
            btnAdd.Location = new Point(294, 199);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 16F);
            btn9.Location = new Point(213, 199);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 42);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 16F);
            btn8.Location = new Point(126, 199);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 42);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 16F);
            btn7.Location = new Point(45, 199);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 42);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Microsoft Sans Serif", 16F);
            btnDivide.Location = new Point(294, 318);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(67, 42);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 16F);
            btn3.Location = new Point(213, 318);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 42);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 16F);
            btn2.Location = new Point(126, 318);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 42);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 16F);
            btn1.Location = new Point(45, 318);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 42);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Font = new Font("Microsoft Sans Serif", 16F);
            btnSubstract.Location = new Point(294, 260);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(67, 42);
            btnSubstract.TabIndex = 12;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnSubtract_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 16F);
            btn6.Location = new Point(213, 260);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 42);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 16F);
            btn5.Location = new Point(126, 260);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 42);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 16F);
            btn4.Location = new Point(45, 260);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 42);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Microsoft Sans Serif", 16F);
            btnMultiply.Location = new Point(294, 377);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(67, 42);
            btnMultiply.TabIndex = 20;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Microsoft Sans Serif", 16F);
            btnResult.Location = new Point(213, 377);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(67, 42);
            btnResult.TabIndex = 19;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Microsoft Sans Serif", 16F);
            btnDot.Location = new Point(126, 377);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(67, 42);
            btnDot.TabIndex = 18;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Number_Click;
            // 
            // listBox
            // 
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.Font = new Font("Segoe UI", 18F);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 22;
            listBox.Location = new Point(383, 30);
            listBox.Name = "listBox";
            listBox.Size = new Size(184, 378);
            listBox.TabIndex = 21;
            listBox.DrawItem += listBox_DrawItem;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Location = new Point(81, 97);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(75, 23);
            btnMemoryClear.TabIndex = 22;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMC_Click;
            // 
            // btnMemoryRecall
            // 
            btnMemoryRecall.Location = new Point(182, 97);
            btnMemoryRecall.Name = "btnMemoryRecall";
            btnMemoryRecall.Size = new Size(75, 23);
            btnMemoryRecall.TabIndex = 23;
            btnMemoryRecall.Text = "MR";
            btnMemoryRecall.UseVisualStyleBackColor = true;
            btnMemoryRecall.Click += btnMR_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Location = new Point(286, 97);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(75, 23);
            btnMemorySave.TabIndex = 24;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 450);
            Controls.Add(btnMemorySave);
            Controls.Add(btnMemoryRecall);
            Controls.Add(btnMemoryClear);
            Controls.Add(listBox);
            Controls.Add(btnMultiply);
            Controls.Add(btnResult);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnDivide);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSubstract);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPM);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBack);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemorySave;
        private Button btn0;
    }
}
