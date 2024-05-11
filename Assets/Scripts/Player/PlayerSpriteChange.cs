using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteChange : MonoBehaviour
{
    public Sprite knightSprite; // 기사 스프라이트
    public Sprite mageSprite;   // 마법사 스프라이트

    private SpriteRenderer spriteRenderer; // 플레이어의 스프라이트 렌더러
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // 스프라이트 렌더러 컴포넌트 가져오기
    }

    public void SpriteChange(PlayerCharSet.PlayerCharacter character)
    {
        switch (character) // 여기서 playerCharacter에 접근
        {
            case PlayerCharSet.PlayerCharacter.KNIGHT:
                spriteRenderer.sprite = knightSprite; // 기사 스프라이트 설정
                break;
            case PlayerCharSet.PlayerCharacter.MAGE:
                spriteRenderer.sprite = mageSprite; // 마법사 스프라이트 설정
                break;
            default:
                break;
        }
    }
}
