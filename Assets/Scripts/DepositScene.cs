using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositScene : MainScene
{


    public GameObject DepositPopup;
    public InputField depositAmountInput;
    private string userName = "Rtan";

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }





    public void ConfirmDeposit()
    {
        string inputText = depositAmountInput.text;

        // 입력값이 비어 있는지 확인
        if (!string.IsNullOrEmpty(inputText))
        {
            // 입력값이 숫자인지 확인
            if (int.TryParse(inputText, out int amount))
            {
                if (cash > 0)
                {
                    // 유효한 숫자로 변환되면 입금 처리
                    if (cash >= amount)
                    {
                        cash -= amount;
                        balance += amount;
                        UpdateUI();

                    }
                    else
                    {
                        DepositPopup.SetActive(true);
                    }
                }
                else
                {
                    DepositPopup.SetActive(true);
                }
            }
            else
            {
                DepositPopup.SetActive(true);
            }
        }
        else
        {
            DepositPopup.SetActive(true);
        }
    }

    public void Deposit10000(int amount)
    {
        if (cash >= amount)
        {
            balance += amount;
            cash -= amount;
            UpdateUI();
        }
        else
        {
            DepositPopup.SetActive(true);
        }
    }

    public void Deposit50000(int amount)
    {
        if (cash >= amount)
        {
            balance += amount;
            cash -= amount;
            UpdateUI();
        }
        else
        {
            DepositPopup.SetActive(true);
        }
    }
    public void Deposit100000(int amount)
    {
        if (cash >= amount)
        {
            balance += amount;
            cash -= amount;
            UpdateUI();
        }
        else
        {
            DepositPopup.SetActive(true);
        }
    }

    public void CancelDeposit()
    {
        DepositPopup.SetActive(false);
    }

    void UpdateUI()
    {

        balanceText.text = "잔액: " + balance.ToString("C0");
        cashText.text = "현금: " + cash.ToString("C0");
    }
}
