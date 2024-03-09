using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // 카메라가 바라볼 대상 (플레이어)
    public float distance = 100.0f; // 플레이어로부터 카메라의 거리
    public float xSpeed = 250.0f; // 수평 회전 속도
    public float ySpeed = 120.0f; // 수직 회전 속도
    public float yMinLimit = -180f; // 수직 회전의 최소 각도
    public float yMaxLimit = 180f; // 수직 회전의 최대 각도

    private float x = 0.0f;
    private float y = 0.0f;

    void Start()
    {
        var angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    void LateUpdate()
    {
        if (target && Input.GetMouseButton(0)) // 마우스 왼쪽 버튼을 누르고 있는 동안에만 실행
        {
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            y = ClampAngle(y, yMinLimit, yMaxLimit);

            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
