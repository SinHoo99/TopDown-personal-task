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
        // ���� ���� �� PlayerPrefs���� �÷��̾� �̸��� �����ͼ� NPC ����� ������Ʈ�մϴ�.
        UpdateUI();
    }

    // �÷��̾� �̸��� ������Ʈ�ϴ� �Լ�
    public void UpdatePlayerName(string newName)
    {
        // �÷��̾� �̸��� �޾ƿͼ� NPC ����� ������Ʈ�մϴ�.
        UpdateUI(newName);
    }

    // UI�� ������Ʈ�ϴ� �Լ�
    private void UpdateUI(string playerName = "")
    {
        // PlayerPrefs���� �÷��̾� �̸��� �����ɴϴ�.
        string player = PlayerPrefs.GetString("PlayerName");

        // �÷��̾� �̸��� ���� ��� �⺻���� ����մϴ�.
        if (playerName == "")
        {
            playerName = player;
        }

        // NPC ����� ���ڿ��� ��ȯ�մϴ�.
        string npcText = "NPC ���:\n";
        npcText += "- " + playerName + "\n";
        npcText += "- NPC\n";

        // NPC ����� UI Text�� ������Ʈ�մϴ�.
        npcListText.text = npcText;
    }
}
