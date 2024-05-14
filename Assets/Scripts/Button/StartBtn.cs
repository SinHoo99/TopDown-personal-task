using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField inputField;

    //시작할때 InputField에 있는 텍스트를 플레이어 이름으로 저장
    public void OnJoinButtonClicked()
    {
        string playerName = inputField.text;

        PlayerPrefs.SetString("PlayerName", playerName);
        SceneManager.LoadScene("MainScene");
    }
}
