using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab; // 발사할 프로젝타일의 프리팹
    public Transform firePoint; // 프로젝타일이 발사될 위치

    // Update is called once per frame
    void Update()
    {
        // 여기서는 예시로, 스페이스 바를 누를 때마다 총알을 발사하도록 설정
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 프로젝타일 프리팹의 인스턴스를 생성하고, firePoint의 위치와 회전으로 설정
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
