using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void Withdraw()
    {
        SceneManager.LoadScene("WithdrawScene");
    }
    public void Deposit()
    {
        SceneManager.LoadScene("DepositScene");
    }
    public void BackMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
