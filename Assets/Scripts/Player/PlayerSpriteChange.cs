using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpriteChange : MonoBehaviour
{
    public Sprite knightSprite; // ��� ��������Ʈ
    public Sprite mageSprite;   // ������ ��������Ʈ

    public Image playerImage; // �÷��̾� �̹���

    private void Awake()
    {
        // �ʱ� �̹��� ����
        SetPlayerImage(PlayerCharSet.PlayerCharacter.KNIGHT);
    }

    // �÷��̾� �̹��� ���� �޼���
    public void SetPlayerImage(PlayerCharSet.PlayerCharacter character)
    {
        switch (character)
        {
            case PlayerCharSet.PlayerCharacter.KNIGHT:
                playerImage.sprite = knightSprite; // ��� ��������Ʈ ����
                break;
            case PlayerCharSet.PlayerCharacter.MAGE:
                playerImage.sprite = mageSprite; // ������ ��������Ʈ ����
                break;
            default:
                break;
        }
    }
}
