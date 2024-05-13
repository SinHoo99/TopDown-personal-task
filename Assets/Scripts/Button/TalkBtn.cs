using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBtn : MonoBehaviour
{
    public GameObject Talk;
    public GameObject Info;

    public void ShowInfoBtn()
    {
        Info.SetActive(true);
        Talk.SetActive(false);
    }

    public void ExitInfoBtn()
    {
        Info.SetActive(false);
    }

}
