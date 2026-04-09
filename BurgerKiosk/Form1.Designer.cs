namespace BurgerKiosk
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
            lblTitle = new Label();
            rdoHamBurger = new RadioButton();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            groupBox2 = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            listBox1 = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("한컴 솔잎 M", 19.8749981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.Location = new Point(27, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(466, 73);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Location = new Point(26, 90);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(131, 47);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rdoChickenBurger);
            groupBox1.Controls.Add(rdoBulgogiBurger);
            groupBox1.Controls.Add(rdoHamBurger);
            groupBox1.Font = new Font("한컴 백제 B", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox1.Location = new Point(44, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 450);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.치킨img;
            pictureBox3.Location = new Point(260, 331);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.불고기img;
            pictureBox2.Location = new Point(260, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.햄버거img;
            pictureBox1.Location = new Point(260, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Location = new Point(26, 348);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(171, 47);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨 버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Location = new Point(26, 213);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(198, 47);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기 버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkSauce);
            groupBox2.Controls.Add(chkCheese);
            groupBox2.Controls.Add(chkCola);
            groupBox2.Controls.Add(chkPotato);
            groupBox2.Font = new Font("한컴 백제 B", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox2.Location = new Point(491, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 347);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Location = new Point(15, 272);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(172, 47);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(15, 201);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(172, 47);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Location = new Point(15, 131);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(105, 47);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Location = new Point(15, 66);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(159, 47);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Font = new Font("한컴 백제 B", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox3.Location = new Point(745, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(349, 382);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 318);
            label2.Name = "label2";
            label2.Size = new Size(182, 43);
            label2.TabIndex = 1;
            label2.Text = "총 금액: 0원";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(331, 219);
            listBox1.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Salmon;
            btnOrder.Font = new Font("나눔고딕 ExtraBold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = SystemColors.ControlLightLight;
            btnOrder.Location = new Point(773, 538);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(166, 50);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.FromArgb(192, 255, 192);
            btnInit.Font = new Font("나눔고딕 ExtraBold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.ForeColor = SystemColors.ControlText;
            btnInit.Location = new Point(967, 538);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(127, 50);
            btnInit.TabIndex = 5;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 617);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RadioButton rdoHamBurger;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private CheckBox chkSauce;
        private ListBox listBox1;
        private Label label2;
        private Button btnOrder;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnInit;
    }
}
