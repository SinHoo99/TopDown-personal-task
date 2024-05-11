using UnityEngine;
using UnityEngine.UI;

public class PlayerNameSet : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {    
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}