using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcUIBtn : MonoBehaviour
{
    public GameObject NpcUI;


    public void ShowNpcUIBtn()
    {
        NpcUI.SetActive(true);
    }

    public void ExitNpcUIBtn()
    {
        NpcUI.SetActive(false);
    }
}
