namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            // 폼에서 키 이벤트를 먼저 처리하도록 설정
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        // 폼이 화면에 보인 직후 처리: 초기 선택(라디오) 완전 해제 및 포커스 제거
        private void Form1_Shown(object? sender, EventArgs e)
        {
            // Ensure no radio button is checked after the form is shown
            foreach (Control ctrl in groupBoxMenu.Controls)
            {
                if (ctrl is RadioButton rb)
                    rb.Checked = false;
            }

            // Clear any active control after all default focus processing completes
            BeginInvoke(() =>
            {
                this.ActiveControl = null;
                // set focus to the form itself so no child control appears selected
                this.Focus();
            });
        }

        // 폼 처음 실행 시 초기화
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeControls();
            lblMessage.Text = "";  // 폼 로드 시 라벨 비우기

            // Ensure no control in the menu is focused at startup (show no selection)
            this.ActiveControl = null;
            this.Focus();
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
            // 그룹 박스 순서 (Tab 이동용)
            _groupBoxes = new List<GroupBox> { groupBoxMenu, groupBoxOption, groupBoxOrder };
            _currentGroupIndex = 0;

            // Ensure controls inside groups can receive focus via keyboard
            foreach (Control ctrl in groupBoxMenu.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.TabStop = true;
                    rb.Enabled = true;
                }
            }
            // Ensure no radio button is checked at startup
            foreach (Control ctrl in groupBoxMenu.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
            foreach (Control ctrl in groupBoxOption.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.TabStop = true;
                    cb.Enabled = true;
                }
            }
            lstOrder.TabStop = true;

            // Ensure buttons are enabled and focusable
            btnOrder.Enabled = true;
            btnInit.Enabled = true;
            btnOrder.TabStop = true;
            btnInit.TabStop = true;

            // Do not force focus to a RadioButton here so the initial state shows no menu selected.
        }

        // 키보드 내비게이션을 위한 필드
        private List<GroupBox> _groupBoxes;
        private int _currentGroupIndex = 0;

        // 폼 전체 KeyDown 처리
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            // Tab: 그룹 박스 간 포커스 이동
            if (e.KeyCode == Keys.Tab)
            {
                MoveToNextGroup(e.Shift);
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            // 방향키: 그룹 내부 아이템 포커스 이동 (위/아래/왼/오)
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                MoveFocusInGroup(e.KeyCode);
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            // Space: 현재 포커스 항목 선택/토글 (버튼은 제외)
            if (e.KeyCode == Keys.Space)
            {
                var ctl = this.ActiveControl;
                if (ctl is RadioButton rb)
                {
                    rb.Checked = true;
                }
                else if (ctl is CheckBox cb)
                {
                    cb.Checked = !cb.Checked;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            // Enter: 버튼 활성화
            if (e.KeyCode == Keys.Enter)
            {
                var ctl = this.ActiveControl;
                if (ctl is Button btn)
                {
                    btn.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    // If a button appears focused but ActiveControl is not set, check focus flags
                    if (btnOrder.Focused)
                    {
                        btnOrder.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                    else if (btnInit.Focused)
                    {
                        btnInit.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        private void MoveToNextGroup(bool shift)
        {
            if (_groupBoxes == null || _groupBoxes.Count == 0) return;
            // 다음 또는 이전 인덱스
            _currentGroupIndex = (_currentGroupIndex + (shift ? -1 : 1) + _groupBoxes.Count) % _groupBoxes.Count;
            var target = _groupBoxes[_currentGroupIndex];
            // 그룹 내부의 첫 포커스 가능한 컨트롤로 이동
            var first = GetFirstFocusableControl(target);
            first?.Focus();
        }

        private bool IsControlInGroup(Control? ctl, GroupBox group)
        {
            if (ctl == null) return false;
            var parent = ctl.Parent as Control;
            while (parent != null)
            {
                if (parent == group) return true;
                parent = parent.Parent as Control;
            }
            return false;
        }

        private Control? GetFirstFocusableControl(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // A control is focusable when it's visible, enabled and set to receive tab stops
                if (c.Visible && c.Enabled && c.TabStop)
                    return c;
            }
            return null;
        }

        private void MoveFocusInGroup(Keys key)
        {
            var ctl = this.ActiveControl;
            if (ctl == null) return;
            // 찾을 그룹
            var parent = ctl.Parent as Control;
            while (parent != null && !(parent is GroupBox))
                parent = parent.Parent as Control;
            if (parent == null) return;
            var group = (GroupBox)parent;
            // 대상 수집: 같은 타입(RadioButton 또는 CheckBox)만 이동
            List<Control> items = new List<Control>();
            foreach (Control c in group.Controls)
            {
                if (!c.Visible || !c.Enabled) continue;
                if (ctl is RadioButton && c is RadioButton) items.Add(c);
                if (ctl is CheckBox && c is CheckBox) items.Add(c);
                if (ctl is ListBox && c is ListBox) items.Add(c);
            }
            if (items.Count == 0) return;
            int idx = items.IndexOf(ctl);
            if (idx < 0) return;
            int next = idx;
            if (key == Keys.Up || key == Keys.Left)
                next = (idx - 1 + items.Count) % items.Count;
            else if (key == Keys.Down || key == Keys.Right)
                next = (idx + 1) % items.Count;
            items[next].Focus();
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
