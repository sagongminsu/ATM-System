using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawScene : MainScene
{


    public GameObject WithdrawPopup;
    public InputField WithdrawAmountInput;
    private string userName = "Rtan";



    // UI �ʱ�ȭ �� ������Ʈ
    void Start()
    {
        UpdateUI();

    }


    public void ConfirmDeposit()
    {
        string inputText = WithdrawAmountInput.text;

        // �Է°��� ��� �ִ��� Ȯ��
        if (!string.IsNullOrEmpty(inputText))
        {
            // �Է°��� �������� Ȯ��
            if (int.TryParse(inputText, out int amount))
            {
                if (amount > 0)
                {
                    // ��ȿ�� ���ڷ� ��ȯ�Ǹ� �Ա� ó��
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

        balanceText.text = "�ܾ�: " + balance.ToString("C0");
        cashText.text = "����: " + cash.ToString("C0");
    }
}
