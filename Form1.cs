namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        // 폼 처음 실행 시 초기화
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeControls();
            lblMessage.Text = "";  // 폼 로드 시 라벨 비우기
        }

        // 라디오 버튼, 체크박스, 주문 내역, 총 금액 초기화 메서드
        private void InitializeControls()
        {
            // 1. 메뉴 선택 라디오 버튼 초기화 (GroupBox 안 모든 RadioButton)
            // Prevent automatic checking by temporarily disabling AutoCheck
            foreach (Control ctrl in groupBoxMenu.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.AutoCheck = false;
                }
            }
            foreach (Control ctrl in groupBoxMenu.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
            foreach (Control ctrl in groupBoxMenu.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.AutoCheck = true;
                }
            }

            // 2. 옵션 선택 체크박스 초기화 (GroupBox 안 모든 CheckBox)
            foreach (Control ctrl in groupBoxOption.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }

            // 3. 주문 내역 초기화
            lstOrder.Items.Clear();

            // 4. 총 금액 초기화
            lblTotal.Text = $"총 금액: {0:N0}원";
            lblMessage.Text = "";

            // 숨김: 에러 메시지
            lblError.Visible = false;
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
            lstOrder.Items.Clear();

            // 4. 총 금액 초기화
            lblTotal.Text = $"총 금액: {0:N0}원";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;

            // 이전 주문 초기화
            lstOrder.Items.Clear();

            // 초기 메시지 지우기
            lblMessage.Text = "";

            // 메뉴가 선택되어 있는지 확인
            bool menuSelected = rdoHamBurger.Checked || rdoBulgogiBurger.Checked || rdoChickenBurger.Checked;
            if (!menuSelected)
            {
                lblMessage.Text = "버거를 선택하세요!";
                return;
            }

            //버거 선택 (RadioButton)
            if (rdoHamBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                totalCost += 3000;
            }

            //추가 옵션 (CheckBox)
            if (chkPotato.Checked)
            {
                lstOrder.Items.Add("감자튀김 2,000원");
                totalCost += 2000;
            }
            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 1,500원");
                totalCost += 1500;
            }
            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 추가 500원");
                totalCost += 500;
            }
            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 추가 300원");
                totalCost += 300;
            }


            //총 금액 출력 (3자리마다 쉼표)
            lblTotal.Text = $"총 금액: {totalCost:N0}원";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
