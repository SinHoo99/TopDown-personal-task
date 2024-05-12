using UnityEngine;
using UnityEngine.UI;

public class PlayerNameSet : MonoBehaviour
{
    public Text playerNameText;
    public InputField inputField;
    [SerializeField] private Canvas SelectUICanvas;
    public Button confirmButton; // Ȯ�� ��ư�� ����Ű�� ����

    private void Start()
    {
        // ���� ���� �� ����� �÷��̾� �̸� ǥ��
        DisplayPlayerName();
        // �Է� �ʵ��� ������ ����� ������ ȣ��Ǵ� �̺�Ʈ ������ ����
        inputField.onValueChanged.AddListener(OnNameFieldChanged);
        // Ȯ�� ��ư Ŭ�� �� ȣ��Ǵ� �̺�Ʈ ������ ����
        confirmButton?.onClick.AddListener(OnChangeButtonClicked);     
    }

    // �̸� �Է� �ʵ忡�� �ؽ�Ʈ�� ����� �� ȣ��Ǵ� �Լ�
    private void OnNameFieldChanged(string newName)
    {
        // ��ȿ�� �̸��� �ƴϸ� ��ư�� ��Ȱ��ȭ
        confirmButton.interactable = IsValidName(newName);
    }

    // �̸� ���� ��ư�� ������ �� ȣ��Ǵ� �Լ�
    private void OnChangeButtonClicked()
    {
        string playerName = inputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        SelectUICanvas.gameObject?.SetActive(false);
        playerNameText.text = playerName; // ����� �̸��� ��� ǥ��
    }

    // �̸� ���� ��ư�� ������ �� ȣ��Ǵ� �Լ�
    public void ShowNameChangeBox()
    {
        PlayerPrefs.DeleteKey("PlayerName");
        SelectUICanvas.gameObject?.SetActive(true);
    }

    // ����� �÷��̾� �̸��� ǥ���ϴ� �Լ�
    private void DisplayPlayerName()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
        inputField.text = playerName; // �Է� �ʵ忡�� �ݿ�
    }

    // �Էµ� �̸��� ��ȿ������ Ȯ���ϴ� �Լ�
    private bool IsValidName(string name)
    {
        return name.Length >= 2 && name.Length <= 10;
    }

    // �̸� ���� ��ư�� ������ �� ȣ��Ǵ� �Լ�
    public void ChangeName()
    {
        string playerName = inputField.text;

        // �Էµ� �̸��� ���̰� 2~10 �������� Ȯ��
        if (IsValidName(playerName))
        {
            // �÷��̾� �̸� ���� �� ����
            PlayerPrefs.SetString("PlayerName", playerName);
            // ����� �̸� ǥ��
            playerNameText.text = playerName;
        }
        else
        {
            // ��ȿ���� ���� �̸��� ���� ó��
            Debug.LogWarning("�̸��� 2~10 ���� ���̿��� �մϴ�.");
        }
    }
}