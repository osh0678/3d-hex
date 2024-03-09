using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f; // 프로젝타일의 속도
    public float lifeTime = 5f; // 프로젝타일의 수명 시간

    private void Start()
    {
        Destroy(gameObject, lifeTime); // lifeTime 후에 프로젝타일을 자동으로 파괴
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
