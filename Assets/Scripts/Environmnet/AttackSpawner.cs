using System.Collections;
using System.Collections.Generic;
using UnityEditor.Purchasing;
using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    public GameObject attackPrefab;
    public Transform playerObject;
    public float spawnRate = 10f;
    public float spawnDistance = 50.0f;
    public float nextSpawnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + spawnRate;// 다음 생성 시간
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)//시간이 되면 공격 오브젝트 생성
        {
            Vector3 spawnPosition = playerObject.position + Random.onUnitSphere * spawnDistance;// 생성될 위치 = 플레이어 위치 + 랜덤한 방향 * 생성거리

            GameObject spawnObject = Instantiate(attackPrefab, spawnPosition, Quaternion.identity);// 공격 오브젝트 생성

            Vector3 direction = (playerObject.position - spawnPosition).normalized;// 플레이어를 향한 방향 계산

            spawnObject.AddComponent<AttackScript>().target = playerObject;// 공격 오브젝트에 스크립트 설정

            nextSpawnTime = Time.time + spawnRate;// 다음 생성 시간 설정
        }
    }
}
