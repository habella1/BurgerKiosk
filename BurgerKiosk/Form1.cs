namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // 1. RadioButton 초기화 (버거 선택 해제)
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // 2. CheckBox 초기화 (옵션 선택 해제)
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 3. 주문 내역 초기화
            listBox1.Items.Clear();

            // 4. 총 금액 초기화
            label2.Text = "총 금액: 0원";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;

            // 이전 주문 초기화
            listBox1.Items.Clear();

            //버거 선택 (RadioButton)
            if (rdoHamBurger.Checked)
            {
                listBox1.Items.Add("햄버거");
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                listBox1.Items.Add("불고기버거");
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                listBox1.Items.Add("치킨버거");
                totalCost += 3000;
            }
            else
            {
                MessageBox.Show("버거를 선택하세요!");
                return;
            }

            //추가 옵션 (CheckBox)
            if (chkPotato.Checked)
            {
                listBox1.Items.Add("감자튀김");
                totalCost += 2000;
            }
            if (chkCola.Checked)
            {
                listBox1.Items.Add("콜라");
                totalCost += 1500;
            }
            if (chkCheese.Checked)
            {
                listBox1.Items.Add("치즈 추가");
                totalCost += 500;
            }
            if (chkSauce.Checked)
            {
                listBox1.Items.Add("소스 추가");
                totalCost += 300;
            }

            //총 금액 출력
            label2.Text = "총 금액: " + totalCost + "원";
        }
    }
}
