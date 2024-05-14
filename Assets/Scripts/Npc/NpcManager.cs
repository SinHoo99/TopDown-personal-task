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
        // 게임 시작 시 PlayerPrefs에서 플레이어 이름을 가져와서 NPC 목록을 업데이트.
        UpdateUI();
    }

    // 플레이어 이름을 업데이트하는 함수
    public void UpdatePlayerName(string newName)
    {
        // 플레이어 이름을 받아와서 NPC 목록을 업데이트
        UpdateUI(newName);
    }

    // UI를 업데이트하는 함수
    private void UpdateUI(string playerName = "")
    {
        // PlayerPrefs에서 플레이어 이름을 가져오기
        string player = PlayerPrefs.GetString("PlayerName");

        // 플레이어 이름이 없을 경우 기본값을 사용
        if (playerName == "")
        {
            playerName = player;
        }

        // NPC 목록을 문자열로 변환
        string npcText = "참석인원:\n";
        npcText += "- " + playerName + "\n";
        npcText += "- NPC\n";

        // NPC 목록을 UI Text로 업데이트
        npcListText.text = npcText;
    }
}
