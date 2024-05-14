using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBtn : MonoBehaviour
{
    public GameObject Talk; // 대화할거냐 묻는창
    public GameObject Info; // 실제 대화 창

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
