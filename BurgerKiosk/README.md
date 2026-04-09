#6주차 과제: (C# 코딩) Buger Kiosk (키오스크 주문 화면)
-이름: 하다현 (24018097)

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자로부터 아이디와 패스워드를 입력받아 로그인 여부를 판단하는 프로그램
- 사용한 플랫폼: C#, .NET Windows Forms, Visual Studio, GitHub, Visual Code
- 사용한 컨트롤: RadioButton, CheckBox, GroupBox, Label, PictureBox, ListBox, Button
- 사용한 기술과 구현한 기능:
  - Visual Studio를 이용하여 UI 디자인
  - 메뉴 선택 기능: RadioButton을 활용한 단일 메뉴 선택
  - 옵션 선택 기능: CheckBox를 활용한 복수 선택 처리
  - 가격 계산 기능: 선택된 항목들의 가격을 합산
  - 이벤트 처리: 버튼 클릭 시 전체 로직 실행
  - 조건문 활용: 선택 여부에 따른 분기 처리
  - UI 업데이트: 사용자 입력에 따라 화면 즉시 반영
-핵심 키워드:
  -  컨트롤: CheckBox, RadioButton, Label, Button, GroupBox
  - 속성: Checked, Text, Enabled
  - 메서드: ToString(), Clear()
  - 이벤트: Click

---

## 실행 화면 (과제1)
![과제1 실행화면](img/screenshot-1.png)

- 과제 내용
  - 메뉴선택 GroupBox(햄버거, 불고기 버거, 치킨 버거 RadioButton+ PictureBox)만들기, 추가 옵션 GroupBox(옵션 4개 CheckBox) 만들기, 주문내역 GroupBox(listBox 1개, 총 금액 Label 1개) 만들기, "주문하기"와 "초기화" 버튼 만들기
    +) GroupBox는 [도구상자]-[모든 Windows Forms]에 있음.
	이미지는 PictureBox 누르고 Image에서 원하는 사진 넣으면 됨.
	** SizeMode는 StretchImage로 설정 바꾸기(내가 원하는 이미지에 맞게 늘어남)
    cf) Label("버거 주문 키오스크") -> lblTitle
	RadioButton-"햄버거" -> rdoChickenBurger
			  "불고기 버거" -> rdoBulgogiBurger
			  "치킨 버거" -> rdoChickenBurger
	CheckBox-"감자튀김" -> chkPotato
		     -"콜라" -> chkCola
		     -"치즈" -> chkCheese
		     -"소스" -> chkSauce
	Button-"주문하기" -> btnorder
		 -"초기화" -> btnInit
	GruopBox-"메뉴선택" -> groupBoxMenu
		     -"추가옵션" -> groupBoxOption
		     -"주문 내역" -> groupBoxOrder
	Label-"총 금액" -> lblTotal
	ListBox -> lstOrder
	
			
  - 기본 UI 화면을 적절히 배치
  - GroupBox로 적절하게 그룹으로 묶기
  - 주문 내역(ListBox)과 총 금액(Label) 표시
  - 다시 주문할 수 있도록 초기화 버튼 만들기(rdoHamBurger.Checked = false; 이런 식으로 다 false로 써주면 됨.)
  - 주문하기 버튼 만들기(**int totalCost = 0;로 변수 초기화하기)

- 구현 내용과 기능 설명
  - 메뉴 선택 영역을 구성하기 위해 GroupBox를 사용하였고, RadioButton을 이용하여 햄버거, 불고기 버거, 치킨 버거 중 하나만 선택할 수 있도록 구현하였다.
  - RadioButton의 특성을 이용하여 하나의 메뉴만 선택되도록 하였으며, 사용자가 직관적으로 메뉴를 고를 수 있도록 하였다.
  - 각 메뉴 옆에는 PictureBox를 배치하여 이미지가 함께 표시되도록 구성하였다. PictureBox의 Image 속성을 이용하여 이미지를 삽입하였으며, SizeMode를 StretchImage로 설정하여 이미지가 컨트롤 크기에 맞게 자연스럽게 표시되도록 하였다.
  - 추가 옵션 영역은 별도의 GroupBox로 구성하고 CheckBox를 이용하여 감자튀김, 콜라, 치즈, 소스 옵션을 선택할 수 있도록 구현하였다. CheckBox의 특성을 이용하여 여러 옵션을 동시에 선택할 수 있도록 하였다.
  - 추가 옵션 영역은 별도의 GroupBox로 구성하고 CheckBox를 이용하여 감자튀김, 콜라, 치즈, 소스 옵션을 선택할 수 있도록 구현하였다. CheckBox의 특성을 이용하여 여러 옵션을 동시에 선택할 수 있도록 하였다.
  - 주문하기 버튼 클릭 시 RadioButton과 CheckBox의 Checked 속성을 활용하여 사용자가 선택한 메뉴와 옵션을 판별하도록 구현하였다. 선택된 항목은 ListBox에 추가되며, 각 메뉴의 이름과 가격이 함께 출력되도록 하여 사용자가 주문 내용을 쉽게 확인할 수 있도록 하였다.
  - 초기화 버튼 클릭 시에는 모든 RadioButton과 CheckBox의 Checked 값을 false로 설정하여 선택 상태를 초기화하였고, ListBox의 Items.Clear()를 사용하여 주문 내역을 삭제하였다. 또한 Label의 텍스트를 "총 금액: 0원"으로 설정하여 초기 상태로 돌아가도록 구현하였다.

-사용한 기술과 구현한 기능:
  - RadioButton / CheckBox를 이용한 선택 처리
  - Checked 속성을 이용한 상태 확인
  - ListBox를 이용한 주문 내역 출력
  - Label을 이용한 결과 출력
  - Button 클릭 이벤트 처리

 ---

## 실행 화면 (과제2)
![과제2 실행화면](img/screenshot-2.png)

- 과제 내용
  - 입력창 자동 초기화
  - 포커스 이동
  - Enter 키 전송
  - 공백 입력 방지

- 구현 내용과 기능 설명
    - 로그인 실패 시 MessageBox를 사용하는 대신, 화면에 Label을 배치하여 오류 메시지를 표시하였다.
    - 평상시에는 Label을 숨겨두고(Visible = false), 로그인 실패 시에만 Visible을 true로 변경하여 메시지를 출력하였다.
    - 사용자 입장에서 어떤 부분이 잘못되었는지 직관적으로 확인할 수 있도록 UI를 개선하였다.

  - 사용한 기술과 구현한 기능
    - Label.Visible 속성을 이용한 메시지 제어
    - 조건문을 이용한 로그인 실패 처리
    - UI 기반 오류 피드백 구현

---

## 실행 화면 (과제3)
![과제3 실행화면](img/screenshot-3.png)

** 모두 btnSend_Click() 함수에서 작업하면 됨.

- 과제 내용
  - Enter 키를 이용한 로그인 기능 구현
  - 입력 흐름 개선 (아이디 → 비밀번호 → 로그인)
  - 사용자 편의 기능 추가
 
- 구현 내용과 기능 설명
  - 아이디 입력 후 Enter 키를 누르면 비밀번호 입력창으로 포커스가 이동하도록 구현하였다.
  - 비밀번호 입력 후 Enter 키를 누르면 로그인 버튼 클릭 이벤트가 실행되도록 하였다.
  - 버튼 클릭 없이 키보드만으로 로그인할 수 있도록 UX를 개선하였다.
  - 입력 내용을 한 번에 지우는 기능과 비밀번호를 표시/숨김 처리하는 기능을 추가하여 사용자 편의성을 높였다.

- 사용한 기술과 구현한 기능
  - KeyDown 이벤트를 이용한 Enter 키 처리
  - Focus()를 이용한 입력창 이동
  - PerformClick()을 이용한 버튼 이벤트 실행
  - UI/UX 개선 기능 구현

---

## 실행 화면 (과제4)
![과제4 실행화면](img/screenshot-4.png)

- 과제 내용
  - 아이디 및 패스워드 입력값 검증
  - 로그인 시도 횟수 제한 기능 구현

- 구현 내용과 기능 설명
  - 아이디에 사용할 수 없는 문자나 형식을 제한하고, 비밀번호에 필요한 조건을 설정하여 입력값을 검증하였다.
  - 로그인 실패 횟수를 카운트하여 일정 횟수 이상 실패 시 로그인 시도를 제한하였다.
  - 일정 시간이 지난 후 다시 로그인할 수 있도록 하여 보안성을 강화하였다.
  - 추가적으로 한 단계 더 확인 절차를 넣어 로그인 과정을 강화하였다.

- 사용한 기술과 구현한 기능
  - 문자열 검사 (Length, Contains 등 활용)
  - 조건문을 이용한 입력 검증
  - 변수로 로그인 시도 횟수 관리
  - Timer 또는 시간 비교를 이용한 재시도 제한

---

## +) 기능 설명

### 1단계 - 기본 UI 배치 및 기능 구현
  1. UI구성
    - RadioButton과 CheckBox 등을 적절히 배치
    - GroupBox로 적절하게 그룹으로 묶기

  2. GroupBox로 적절하게 그룹으로 묶기
    - RadioButton 한 그룹으로 묶고, CheckBox끼리 한 그룹으로 묶고, ListBox와 총 금액 표시하는 Label 하나로 묶기

  3. 주문하기 버튼과 초기화 버튼 기능 구현
    - ListBox에 주문 내역, Label에 총 금액 표시(총 금액: 0원)
    - 다시 주문할 수 있도록 초기화 버튼 구현

### 2단계 - 에러 표시 개선
  1. 화면 내 오류 표시
    - Label을 이용해 아이디 또는 패스워드가 잘못 입력됐을 때 에러 메시지를 화면에 표시
    - Visible 속성을 이용해 메시지 보이기와 숨기기 기능 구현
  2. UX 개선
    - 사용자에게 즉각적인 피드백 제공
    - 불필요한 MessageBox 사용 최소화

### 3단계 - UX 개선(사용자 편의성 향상)
  1. Enter 키를 누르면 로그인 되도록 포커스 흐름 정리
   - 아이디 입력 -> Enter 누르면 패스워드 입력 창으로 넘어가기
   - 패스워드 입력 -> Enter누르면 로그인 시작하기

  2. 추가 기능
    - 전체 입력 삭제 기능
    - 패스워드를 보여주는 기능(보기/숨기기 가능)
   

### 4단계 - 데이터 관리 및 심화 기능
  1. 아이디와 패스워드 입력 문자 확인
    - 아이디에 넣을 수 없는 글자 체크
    - 비밀번호에 넣을 수 없거나 꼭 들어가야 하는 문자 체크
  2. 로그인 시도 제한
    - 일정 회수가 지나면 정해진 시간 후에 재시도 가능하게
    -  한 단계 더 체크하기
    - 조금 더 복잡하고 

     
---

## 구현 시 어려웠던 점
- 