using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    public Text Name;
    public Text balanceText;
    public Text cashText;


    public static int cash = 100000;
    public static int balance = 50000;
    private string userName = "Rtan";

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        userName = Name.text;
        balanceText.text = "�ܾ�: " + balance.ToString("C0");
        cashText.text = "����: " + cash.ToString("C0");
    }
}
