using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteChange : MonoBehaviour
{
    public Sprite knightSprite; // ��� ��������Ʈ
    public Sprite mageSprite;   // ������ ��������Ʈ

    private SpriteRenderer spriteRenderer; // �÷��̾��� ��������Ʈ ������
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // ��������Ʈ ������ ������Ʈ ��������
    }

    public void SpriteChange(PlayerCharSet.PlayerCharacter character)
    {
        switch (character) // ���⼭ playerCharacter�� ����
        {
            case PlayerCharSet.PlayerCharacter.KNIGHT:
                spriteRenderer.sprite = knightSprite; // ��� ��������Ʈ ����
                break;
            case PlayerCharSet.PlayerCharacter.MAGE:
                spriteRenderer.sprite = mageSprite; // ������ ��������Ʈ ����
                break;
            default:
                break;
        }
    }
}
