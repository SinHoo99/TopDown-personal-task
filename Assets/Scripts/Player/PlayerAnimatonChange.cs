using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatonChange : MonoBehaviour
{
    public Animator playerAnimator; // 플레이어의 애니메이터 컴포넌트

    public RuntimeAnimatorController knightAnimatorController; // 기사 애니메이터 컨트롤러
    public RuntimeAnimatorController mageAnimatorController;   // 마법사 애니메이터

    private void FixedUpdate()
    {
        // 캐릭터 직업에 따라 플레이어의 직업에 따라 애니메이션 설정
        SetPlayerAnimationFromPrefs();
    }

    public void SetPlayerAnimationFromPrefs()
    {
        // PlayerPrefs에서 플레이어 직업 정보 읽어오기
        string currentPlayerJob = PlayerPrefs.GetString("PlayerJob");

        // 플레이어 직업에 따라 애니메이션 설정
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
        // 플레이어 직업에 따라 애니메이션 설정
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
