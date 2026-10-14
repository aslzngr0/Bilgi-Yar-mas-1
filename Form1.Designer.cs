namespace Bilgi_Yarışması_1
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
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSonraki = new Button();
            soruNo = new Label();
            dogru = new Label();
            yanlis = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(622, 276);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(12, 294);
            btnA.Name = "btnA";
            btnA.Size = new Size(308, 76);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(326, 294);
            btnB.Name = "btnB";
            btnB.Size = new Size(308, 76);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(12, 376);
            btnC.Name = "btnC";
            btnC.Size = new Size(308, 76);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(326, 376);
            btnD.Name = "btnD";
            btnD.Size = new Size(308, 76);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(640, 38);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(640, 71);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 6;
            label2.Text = "Doğru Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(640, 108);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 7;
            label3.Text = "Yanlış Sayısı:";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(640, 141);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(181, 37);
            btnSonraki.TabIndex = 8;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // soruNo
            // 
            soruNo.AutoSize = true;
            soruNo.Location = new Point(743, 38);
            soruNo.Name = "soruNo";
            soruNo.Size = new Size(17, 20);
            soruNo.TabIndex = 9;
            soruNo.Text = "0";
            // 
            // dogru
            // 
            dogru.AutoSize = true;
            dogru.Location = new Point(743, 71);
            dogru.Name = "dogru";
            dogru.Size = new Size(17, 20);
            dogru.TabIndex = 10;
            dogru.Text = "0";
            // 
            // yanlis
            // 
            yanlis.AutoSize = true;
            yanlis.Location = new Point(743, 108);
            yanlis.Name = "yanlis";
            yanlis.Size = new Size(17, 20);
            yanlis.TabIndex = 11;
            yanlis.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 455);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 12;
            label4.Text = "Yanlış Sayısı:";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 455);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 13;
            label5.Text = "Yanlış Sayısı:";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 455);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(yanlis);
            Controls.Add(dogru);
            Controls.Add(soruNo);
            Controls.Add(btnSonraki);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSonraki;
        private Label soruNo;
        private Label dogru;
        private Label yanlis;
        private Label label4;
        private Label label5;
    }
}
