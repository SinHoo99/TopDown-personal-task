using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{

    private Text timeText;

    void Start()
    {
        // UI Text 요소 찾기
        timeText = GetComponent<Text>();

        // 매 프레임마다 시간 업데이트
        InvokeRepeating("UpdateDisplayTime", 0f, 1f); // 1초마다 업데이트
    }

    void UpdateDisplayTime()
    {
        // 현재 시간 가져오기
        string currentTime = System.DateTime.Now.ToString("HH:mm");

        // UI Text 업데이트
        timeText.text = currentTime;
    }
}
