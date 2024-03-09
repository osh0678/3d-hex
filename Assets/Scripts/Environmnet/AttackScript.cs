using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public Transform target; // 공격 대상
    public float speed = 10f; // 공격 오브젝트의 속도
    public float lifetime = 10f; // 오브젝트의 생명주기(초 단위)

    private Vector3 direction; // 대상을 향한 방향
    // Start is called before the first frame update
    void Start()
    {
        if (target != null)
        {
            // 대상을 향한 방향 계산
            direction = (target.position - transform.position).normalized;
        }
        else
        {
            // 대상이 지정되지 않은 경우, 기본 방향을 사용
            direction = Vector3.forward;
        }

        Destroy(gameObject, lifetime); // lifetime 초 후 자동 제거
        
    }

    // Update is called once per frame
    void Update()
    {
        // 공격 오브젝트를 계산된 방향으로 이동시킴
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hitbox")) // Hitbox 태그를 가진 오브젝트와 충돌했을 때
        {
            // 여기에 플레이어에게 데미지를 주는 코드를 추가
            other.GetComponent<HitboxObject>().TakeDamage(1);

            Destroy(gameObject); // 데미지를 준 후 공격 오브젝트 제거
        }
        if (other.CompareTag("Player")) // 플레이어와 충돌했을 때
        {
            Destroy(gameObject); //공격 오브젝트 제거
        }
    }
}
