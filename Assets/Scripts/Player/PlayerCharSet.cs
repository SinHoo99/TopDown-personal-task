using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCharSet : MonoBehaviour
{
    public enum PlayerCharacter
    {
        KNIGHT,
        MAGE
    }

    [SerializeField] private GameObject PlayerChoiceCanvas;
    [SerializeField] private Canvas SelectUICanvas;

    public PlayerCharacter playerCharacter;

    public PlayerSpriteChange spriteChanger;


    public void ChooseKnight()
    {
        playerCharacter = PlayerCharacter.KNIGHT;
        SelectedJob();
    }

    public void ChooseMage()
    {
        playerCharacter = PlayerCharacter.MAGE;
        SelectedJob();
    }

    public void ShowSpriteChangeBox()
    {
        PlayerChoiceCanvas.gameObject.SetActive(true);   
        if(SelectUICanvas != null)
        {
            SelectUICanvas.gameObject.SetActive(false);
        }
    }

    private void SavePlayerJob()
    {
        string currentPlayerCharacter = playerCharacter.ToString(); // 열거형 값을 문자열로 변환하여 저장
        PlayerPrefs.SetString("PlayerJob", currentPlayerCharacter);
        PlayerPrefs.Save(); // 변경된 설정을 영구적으로 저장
    }
    private void SelectedJob()
    {
        PlayerChoiceCanvas.gameObject.SetActive(false);
        if (SelectUICanvas != null)
        {
            SelectUICanvas.gameObject.SetActive(true);
        }
        if (spriteChanger != null)
        {
            spriteChanger.SetPlayerImage(playerCharacter);
        }
        SavePlayerJob();
        Debug.Log(playerCharacter);
    }
}

