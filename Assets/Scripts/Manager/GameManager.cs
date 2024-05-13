using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Camera virtualCamera; // 버추얼 카메라
    public Text nameLabel; // 이름표의 Text 컴포넌트
    public Transform playerTransform; // 플레이어의 Transform 컴포넌트

    void Awake()
    {
        if (Instance != null)
        {
            Instance = this;
        }
        
    }

    void FixedUpdate()
    {
        // 플레이어의 월드 좌표를 스크린 좌표로 변환
        Vector3 playerScreenPos = virtualCamera.WorldToScreenPoint(playerTransform.position);

        // 플레이어 위치를 기준으로 텍스트 오브젝트 위치 조정
        nameLabel.rectTransform.position = playerScreenPos + Vector3.up * 105f; // 플레이어 위로 올리는 값
    }

}
