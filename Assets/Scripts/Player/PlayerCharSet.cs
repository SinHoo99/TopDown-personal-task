using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharSet : MonoBehaviour
{
    public enum PlayerCharacter
    {
        KNIGHT,
        MAGE
    }

    [SerializeField] private GameObject PlayerChoiceCanvas;
    [SerializeField] private Canvas JoinUICanvas;
    public PlayerCharacter playerCharacter;



    public void ChooseKnight()
    {
        playerCharacter = PlayerCharacter.KNIGHT;
        PlayerChoiceCanvas.gameObject.SetActive(false);
        JoinUICanvas.gameObject.SetActive(true);
        Debug.Log(playerCharacter);
    }

    public void ChooseMage()
    {
        playerCharacter = PlayerCharacter.MAGE;
        PlayerChoiceCanvas.gameObject.SetActive(false);
        JoinUICanvas.gameObject.SetActive(true);
        Debug.Log(playerCharacter);
    }

    public void ShowSpriteChangeBox()
    {
        PlayerChoiceCanvas.gameObject.SetActive(true);
        JoinUICanvas.gameObject.SetActive(false);
    }
}

