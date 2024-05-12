using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatonChange : MonoBehaviour
{
    public Animator playerAnimator; // �÷��̾��� �ִϸ����� ������Ʈ

    public RuntimeAnimatorController knightAnimatorController; // ��� �ִϸ����� ��Ʈ�ѷ�
    public RuntimeAnimatorController mageAnimatorController;   // ������ �ִϸ�����

    private void FixedUpdate()
    {
        // ĳ���� ������ ���� �÷��̾��� ������ ���� �ִϸ��̼� ����
        SetPlayerAnimationFromPrefs();
    }

    public void SetPlayerAnimationFromPrefs()
    {
        // PlayerPrefs���� �÷��̾� ���� ���� �о����
        string currentPlayerJob = PlayerPrefs.GetString("PlayerJob");

        // �÷��̾� ������ ���� �ִϸ��̼� ����
        if (currentPlayerJob == "KNIGHT")
        {
            SetPlayerAnimation(PlayerCharSet.PlayerCharacter.KNIGHT);
        }
        else if (currentPlayerJob == "MAGE")
        {
            SetPlayerAnimation(PlayerCharSet.PlayerCharacter.MAGE);
        }
    }

    public void SetPlayerAnimation(PlayerCharSet.PlayerCharacter character)
    {
        // �÷��̾� ������ ���� �ִϸ��̼� ����
        switch (character)
        {
            case PlayerCharSet.PlayerCharacter.KNIGHT:
                playerAnimator.runtimeAnimatorController = knightAnimatorController;
                break;
            case PlayerCharSet.PlayerCharacter.MAGE:
                playerAnimator.runtimeAnimatorController = mageAnimatorController;
                break;
            default:
                break;
        }
    }
}
