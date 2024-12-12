namespace Calculator
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
            DisplayBox = new TextBox();
            button8 = new Button();
            OneBtn = new Button();
            FourBtn = new Button();
            SevenBtn = new Button();
            ResetBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            EightBtn = new Button();
            FiveBtn = new Button();
            TwoBtn = new Button();
            ZeroBtn = new Button();
            NineBtn = new Button();
            SixBtn = new Button();
            ThreeBtn = new Button();
            DotBtn = new Button();
            ProductBtn = new Button();
            MinusBtn = new Button();
            PlusBtn = new Button();
            EqualsBtn = new Button();
            SuspendLayout();
            // 
            // DisplayBox
            // 
            DisplayBox.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayBox.Location = new Point(125, 12);
            DisplayBox.Name = "DisplayBox";
            DisplayBox.Size = new Size(471, 61);
            DisplayBox.TabIndex = 0;
            DisplayBox.Text = "0";
            DisplayBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button8
            // 
            button8.Location = new Point(125, 443);
            button8.Name = "button8";
            button8.Size = new Size(94, 59);
            button8.TabIndex = 8;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // OneBtn
            // 
            OneBtn.ForeColor = Color.Black;
            OneBtn.Location = new Point(125, 350);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(94, 59);
            OneBtn.TabIndex = 9;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.ForeColor = Color.Black;
            FourBtn.Location = new Point(125, 263);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(94, 59);
            FourBtn.TabIndex = 10;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // SevenBtn
            // 
            SevenBtn.ForeColor = Color.Black;
            SevenBtn.Location = new Point(125, 174);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(94, 59);
            SevenBtn.TabIndex = 11;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.Black;
            ResetBtn.Location = new Point(125, 86);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(94, 59);
            ResetBtn.TabIndex = 12;
            ResetBtn.Text = "AC";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(255, 86);
            button2.Name = "button2";
            button2.Size = new Size(94, 59);
            button2.TabIndex = 13;
            button2.Text = "%";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(377, 86);
            button3.Name = "button3";
            button3.Size = new Size(94, 59);
            button3.TabIndex = 14;
            button3.Text = "BS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Black;
            button4.Location = new Point(502, 86);
            button4.Name = "button4";
            button4.Size = new Size(94, 59);
            button4.TabIndex = 15;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // EightBtn
            // 
            EightBtn.ForeColor = Color.Black;
            EightBtn.Location = new Point(255, 174);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(94, 59);
            EightBtn.TabIndex = 16;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.ForeColor = Color.Black;
            FiveBtn.Location = new Point(255, 263);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(94, 59);
            FiveBtn.TabIndex = 17;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.ForeColor = Color.Black;
            TwoBtn.Location = new Point(255, 350);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(94, 59);
            TwoBtn.TabIndex = 18;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.ForeColor = Color.Black;
            ZeroBtn.Location = new Point(255, 443);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(94, 59);
            ZeroBtn.TabIndex = 19;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.ForeColor = Color.Black;
            NineBtn.Location = new Point(377, 174);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(94, 59);
            NineBtn.TabIndex = 20;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.ForeColor = Color.Black;
            SixBtn.Location = new Point(377, 263);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(94, 59);
            SixBtn.TabIndex = 21;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.ForeColor = Color.Black;
            ThreeBtn.Location = new Point(377, 350);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(94, 59);
            ThreeBtn.TabIndex = 22;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.ForeColor = Color.Black;
            DotBtn.Location = new Point(377, 443);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(94, 59);
            DotBtn.TabIndex = 23;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // ProductBtn
            // 
            ProductBtn.ForeColor = Color.Black;
            ProductBtn.Location = new Point(502, 174);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(94, 59);
            ProductBtn.TabIndex = 24;
            ProductBtn.Text = "*";
            ProductBtn.UseVisualStyleBackColor = true;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.ForeColor = Color.Black;
            MinusBtn.Location = new Point(502, 263);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(94, 59);
            MinusBtn.TabIndex = 25;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.ForeColor = Color.Black;
            PlusBtn.Location = new Point(502, 350);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(94, 59);
            PlusBtn.TabIndex = 26;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // EqualsBtn
            // 
            EqualsBtn.ForeColor = Color.Black;
            EqualsBtn.Location = new Point(502, 443);
            EqualsBtn.Name = "EqualsBtn";
            EqualsBtn.Size = new Size(94, 59);
            EqualsBtn.TabIndex = 27;
            EqualsBtn.Text = "=";
            EqualsBtn.UseVisualStyleBackColor = true;
            EqualsBtn.Click += EqualsBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(766, 558);
            Controls.Add(EqualsBtn);
            Controls.Add(PlusBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ProductBtn);
            Controls.Add(DotBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ResetBtn);
            Controls.Add(SevenBtn);
            Controls.Add(FourBtn);
            Controls.Add(OneBtn);
            Controls.Add(button8);
            Controls.Add(DisplayBox);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DisplayBox;
        private Button button8;
        private Button OneBtn;
        private Button FourBtn;
        private Button SevenBtn;
        private Button ResetBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button EightBtn;
        private Button FiveBtn;
        private Button TwoBtn;
        private Button ZeroBtn;
        private Button NineBtn;
        private Button SixBtn;
        private Button ThreeBtn;
        private Button DotBtn;
        private Button ProductBtn;
        private Button MinusBtn;
        private Button PlusBtn;
        private Button EqualsBtn;
    }
}
