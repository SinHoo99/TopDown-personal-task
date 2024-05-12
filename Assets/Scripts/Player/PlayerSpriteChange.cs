using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpriteChange : MonoBehaviour
{
    public Sprite knightSprite; // 기사 스프라이트
    public Sprite mageSprite;   // 마법사 스프라이트

    public Image playerImage; // 플레이어 이미지

    private void Awake()
    {
        // 초기 이미지 설정
        SetPlayerImage(PlayerCharSet.PlayerCharacter.KNIGHT);
    }

    // 플레이어 이미지 변경 메서드
    public void SetPlayerImage(PlayerCharSet.PlayerCharacter character)
    {
        switch (character)
        {
            case PlayerCharSet.PlayerCharacter.KNIGHT:
                playerImage.sprite = knightSprite; // 기사 스프라이트 설정
                break;
            case PlayerCharSet.PlayerCharacter.MAGE:
                playerImage.sprite = mageSprite; // 마법사 스프라이트 설정
                break;
            default:
                break;
        }
    }
}
