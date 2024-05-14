using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField inputField;

    //�����Ҷ� InputField�� �ִ� �ؽ�Ʈ�� �÷��̾� �̸����� ����
    public void OnJoinButtonClicked()
    {
        string playerName = inputField.text;

        PlayerPrefs.SetString("PlayerName", playerName);
        SceneManager.LoadScene("MainScene");
    }
}
