using UnityEngine;

public class NpcArea : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Ȱ��ȭ�� ������Ʈ���� �迭
    public GameObject player; // �÷��̾� ������Ʈ
    [SerializeField]
    [Range(0f, 100f)]
    private float activationRange;

    private bool isPlayerInside = false; // �÷��̾ ���� ���� �ִ��� ���θ� ��Ÿ���� ����
    private bool talkButtonEnabled = false; // ��ȭ ��ư�� Ȱ��ȭ�Ǿ����� ���θ� ��Ÿ���� ����

    void Update()
    {
        // �÷��̾�� NPC ������ �Ÿ� ���
        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

        // �÷��̾ Ȱ��ȭ ���� ���� �ִٸ�
        if (distanceToPlayer <= activationRange)
        {
            // �÷��̾ ���� ���� �ִ� ���·� ����
            isPlayerInside = true;

            // ��ȭ ��ư�� ���� Ȱ��ȭ���� �ʾҴٸ�
            if (!talkButtonEnabled)
            {
                // ��ȭ ��ư�� Ȱ��ȭ
                foreach (GameObject obj in objectsToActivate)
                {
                    obj.SetActive(true);
                }
                talkButtonEnabled = true; // ��ȭ ��ư�� Ȱ��ȭ�Ǿ����� ǥ��
            }
        }
        else if (isPlayerInside)
        {
            // �÷��̾ ������ ��� �����̰�, ������ ���� ���� �־��ٸ�
            // ��ȭ ��ư�� ��Ȱ��ȭ
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(false);
            }

            // �÷��̾ ���� ���� ���� ���·� ����
            isPlayerInside = false;

            // ��ȭ ��ư ��Ȱ��ȭ
            talkButtonEnabled = false;
        }
    }

    // �ð������� ������ ǥ���ϱ� ���� OnDrawGizmos �Լ��� ���
    private void OnDrawGizmosSelected()
    {
        // ������ ������ �׸��� ���� �ڵ�
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, activationRange);
    }
}
