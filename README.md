ATM System
1.필수구현요소
 -1. ATM 화면 구성
   - Title
    - 이름
    - 잔액 - 기본 50,000만원
    - 현금 - 기본 100,000만원
    - 입금 버튼 → 2. 입금 기능으로 이동
    - 출금 버튼 → 3. 출금 기능으로 이동
 -2 입금 기능
    - 입금 화면 UI 구성
    - 버튼을 누르면 해당 금액 만큼 현금에서 잔액으로 이동
    - 직접 입력을 이용하면 입력한 금액만큼 입금
    - 뒤로가기 버튼을 누르면 1번 화면으로 이동
     - 잔액이 부족하면 팝업 띄우기
     - 잔액 부족
     - 확인 누르면 팝업 닫기
 -3 출금 기능
     - 출금 화면 UI 구성
     - 버튼을 누르면 해당 금액 만큼 잔액에서 현금으로 이동    
     - 직접 입력을 이용하면 입력한 금액만큼 출금
     - 뒤로가기 버튼을 누르면 1번 화면으로 이동
     - 잔액이 부족하면 팝업 띄우기
     - 잔액 부족
     - 확인 누르면 팝업 닫기
---------------------------
2.선택구현요소
    -통화 단위 적용
    -금액 입력시 숫자만 입력
