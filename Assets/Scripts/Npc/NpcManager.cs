using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcManager : MonoBehaviour
{
    public Text npcListText;
    public GameObject scanObject;

    private void Start()
    {
        // ���� ���� �� PlayerPrefs���� �÷��̾� �̸��� �����ͼ� NPC ����� ������Ʈ.
        UpdateUI();
    }

    // �÷��̾� �̸��� ������Ʈ�ϴ� �Լ�
    public void UpdatePlayerName(string newName)
    {
        // �÷��̾� �̸��� �޾ƿͼ� NPC ����� ������Ʈ
        UpdateUI(newName);
    }

    // UI�� ������Ʈ�ϴ� �Լ�
    private void UpdateUI(string playerName = "")
    {
        // PlayerPrefs���� �÷��̾� �̸��� ��������
        string player = PlayerPrefs.GetString("PlayerName");

        // �÷��̾� �̸��� ���� ��� �⺻���� ���
        if (playerName == "")
        {
            playerName = player;
        }

        // NPC ����� ���ڿ��� ��ȯ
        string npcText = "�����ο�:\n";
        npcText += "- " + playerName + "\n";
        npcText += "- NPC\n";

        // NPC ����� UI Text�� ������Ʈ
        npcListText.text = npcText;
    }
}
