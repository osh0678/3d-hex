using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f; // ������Ÿ���� �ӵ�
    public float lifeTime = 5f; // ������Ÿ���� ���� �ð�

    private void Start()
    {
        Destroy(gameObject, lifeTime); // lifeTime �Ŀ� ������Ÿ���� �ڵ����� �ı�
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
