using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawScene : MainScene
{


    public GameObject WithdrawPopup;
    public InputField WithdrawAmountInput;
    private string userName = "Rtan";



    // UI 초기화 및 업데이트
    void Start()
    {
        UpdateUI();

    }


    public void ConfirmDeposit()
    {
        string inputText = WithdrawAmountInput.text;

        // 입력값이 비어 있는지 확인
        if (!string.IsNullOrEmpty(inputText))
        {
            // 입력값이 숫자인지 확인
            if (int.TryParse(inputText, out int amount))
            {
                if (amount > 0)
                {
                    // 유효한 숫자로 변환되면 입금 처리
                    if (cash >= amount)
                    {
                        balance -= amount;
                        cash += amount;
                        UpdateUI();

                    }
                    else
                    {
                        WithdrawPopup.SetActive(true);
                    }
                }
                else
                {
                    WithdrawPopup.SetActive(true);
                }
            }
            else
            {
                WithdrawPopup.SetActive(true);
            }
        }
        else
        {
            WithdrawPopup.SetActive(true);
        }
    }

    public void Withdraw10000(int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            cash += amount;
            UpdateUI();
        }
        else
        {
            WithdrawPopup.SetActive(true);
        }
    }

    public void Withdraw50000(int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            cash += amount;
            UpdateUI();
        }
        else
        {
            WithdrawPopup.SetActive(true);
        }
    }
    public void Withdraw100000(int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            cash += amount;
            UpdateUI();
        }
        else
        {
            WithdrawPopup.SetActive(true);
        }
    }

    public void CancelWithdraw()
    {
        WithdrawPopup.SetActive(false);
    }

    void UpdateUI()
    {

        balanceText.text = "잔액: " + balance.ToString("C0");
        cashText.text = "현금: " + cash.ToString("C0");
    }
}
