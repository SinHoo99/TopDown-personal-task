using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCharSet : MonoBehaviour
{
    //�÷��̾� ���� 
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
        string currentPlayerCharacter = playerCharacter.ToString(); // ������ ���� ���ڿ��� ��ȯ�Ͽ� ����
        PlayerPrefs.SetString("PlayerJob", currentPlayerCharacter);
        PlayerPrefs.Save(); // ����� ������ ���������� ����
    }

    //������ ������ ���� ��������Ʈ�� �������� �̹��� ����
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

