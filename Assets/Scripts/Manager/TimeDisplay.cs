using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{

    private Text timeText;

    void Start()
    {
        // UI Text ��� ã��
        timeText = GetComponent<Text>();

        // �� �����Ӹ��� �ð� ������Ʈ
        InvokeRepeating("UpdateDisplayTime", 0f, 1f); // 1�ʸ��� ������Ʈ
    }

    void UpdateDisplayTime()
    {
        // ���� �ð� ��������
        string currentTime = System.DateTime.Now.ToString("HH:mm");

        // UI Text ������Ʈ
        timeText.text = currentTime;
    }
}
