using UnityEngine;

public class NpcArea : MonoBehaviour
{
    public GameObject[] objectsToActivate; // 활성화할 오브젝트들의 배열
    public GameObject player; // 플레이어 오브젝트
    [SerializeField]
    [Range(0f, 100f)]
    private float activationRange;

    private bool isPlayerInside = false; // 플레이어가 범위 내에 있는지 여부를 나타내는 변수
    private bool talkButtonEnabled = false; // 대화 버튼이 활성화되었는지 여부를 나타내는 변수

    void Update()
    {
        // 플레이어와 NPC 사이의 거리 계산
        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

        // 플레이어가 활성화 범위 내에 있다면
        if (distanceToPlayer <= activationRange)
        {
            // 플레이어가 범위 내에 있는 상태로 변경
            isPlayerInside = true;

            // 대화 버튼이 아직 활성화되지 않았다면
            if (!talkButtonEnabled)
            {
                // 대화 버튼을 활성화
                foreach (GameObject obj in objectsToActivate)
                {
                    obj.SetActive(true);
                }
                talkButtonEnabled = true; // 대화 버튼이 활성화되었음을 표시
            }
        }
        else if (isPlayerInside)
        {
            // 플레이어가 범위를 벗어난 상태이고, 이전에 범위 내에 있었다면
            // 대화 버튼이 비활성화
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(false);
            }

            // 플레이어가 범위 내에 없는 상태로 변경
            isPlayerInside = false;

            // 대화 버튼 비활성화
            talkButtonEnabled = false;
        }
    }

    // 시각적으로 범위를 표시하기 위해 OnDrawGizmos 함수를 사용
    private void OnDrawGizmosSelected()
    {
        // 범위를 원으로 그리기 위한 코드
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, activationRange);
    }
}
