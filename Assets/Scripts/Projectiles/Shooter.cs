using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab; // �߻��� ������Ÿ���� ������
    public Transform firePoint; // ������Ÿ���� �߻�� ��ġ

    // Update is called once per frame
    void Update()
    {
        // ���⼭�� ���÷�, �����̽� �ٸ� ���� ������ �Ѿ��� �߻��ϵ��� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // ������Ÿ�� �������� �ν��Ͻ��� �����ϰ�, firePoint�� ��ġ�� ȸ������ ����
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
