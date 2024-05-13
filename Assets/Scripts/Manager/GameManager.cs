using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Camera virtualCamera; // ���߾� ī�޶�
    public Text nameLabel; // �̸�ǥ�� Text ������Ʈ
    public Transform playerTransform; // �÷��̾��� Transform ������Ʈ

    void Awake()
    {
        if (Instance != null)
        {
            Instance = this;
        }
        
    }

    void FixedUpdate()
    {
        // �÷��̾��� ���� ��ǥ�� ��ũ�� ��ǥ�� ��ȯ
        Vector3 playerScreenPos = virtualCamera.WorldToScreenPoint(playerTransform.position);

        // �÷��̾� ��ġ�� �������� �ؽ�Ʈ ������Ʈ ��ġ ����
        nameLabel.rectTransform.position = playerScreenPos + Vector3.up * 105f; // �÷��̾� ���� �ø��� ��
    }

}
