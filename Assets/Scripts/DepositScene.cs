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

        // �Է°��� ��� �ִ��� Ȯ��
        if (!string.IsNullOrEmpty(inputText))
        {
            // �Է°��� �������� Ȯ��
            if (int.TryParse(inputText, out int amount))
            {
                if (cash > 0)
                {
                    // ��ȿ�� ���ڷ� ��ȯ�Ǹ� �Ա� ó��
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

        balanceText.text = "�ܾ�: " + balance.ToString("C0");
        cashText.text = "����: " + cash.ToString("C0");
    }
}
