using UnityEngine;
using UnityEngine.UI;

public class PlayerNameSet : MonoBehaviour
{
    public Text playerNameText;
    public InputField inputField;
    [SerializeField] private Canvas SelectUICanvas;
    public Button confirmButton; // 확인 버튼을 가리키는 변수

    private void Start()
    {
        // 게임 시작 시 저장된 플레이어 이름 표시
        DisplayPlayerName();
        // 입력 필드의 내용이 변경될 때마다 호출되는 이벤트 리스너 설정
        inputField.onValueChanged.AddListener(OnNameFieldChanged);
        // 확인 버튼 클릭 시 호출되는 이벤트 리스너 설정
        confirmButton?.onClick.AddListener(OnChangeButtonClicked);     
    }

    // 이름 입력 필드에서 텍스트가 변경될 때 호출되는 함수
    private void OnNameFieldChanged(string newName)
    {
        // 유효한 이름이 아니면 버튼을 비활성화
        confirmButton.interactable = IsValidName(newName);
    }

    // 이름 변경 버튼을 눌렀을 때 호출되는 함수
    private void OnChangeButtonClicked()
    {
        string playerName = inputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        SelectUICanvas.gameObject?.SetActive(false);
        playerNameText.text = playerName; // 변경된 이름을 즉시 표시
    }

    // 이름 변경 버튼을 눌렀을 때 호출되는 함수
    public void ShowNameChangeBox()
    {
        PlayerPrefs.DeleteKey("PlayerName");
        SelectUICanvas.gameObject?.SetActive(true);
    }

    // 저장된 플레이어 이름을 표시하는 함수
    private void DisplayPlayerName()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
        inputField.text = playerName; // 입력 필드에도 반영
    }

    // 입력된 이름이 유효한지를 확인하는 함수
    private bool IsValidName(string name)
    {
        return name.Length >= 2 && name.Length <= 10;
    }

    // 이름 변경 버튼을 눌렀을 때 호출되는 함수
    public void ChangeName()
    {
        string playerName = inputField.text;

        // 입력된 이름의 길이가 2~10 사이인지 확인
        if (IsValidName(playerName))
        {
            // 플레이어 이름 설정 및 저장
            PlayerPrefs.SetString("PlayerName", playerName);
            // 변경된 이름 표시
            playerNameText.text = playerName;
        }
        else
        {
            // 유효하지 않은 이름에 대한 처리
            Debug.LogWarning("이름은 2~10 글자 사이여야 합니다.");
        }
    }
}