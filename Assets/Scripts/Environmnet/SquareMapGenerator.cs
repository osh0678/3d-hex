using UnityEngine;
public class SquareMapGenerator : MonoBehaviour
{
    void Start()
    {
        // 메시 생성
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        // 정사각형 맵의 꼭짓점 정의
        Vector3[] vertices = {
            new Vector3(-1, 0, 1),  // 좌상단
            new Vector3(1, 0, 1),   // 우상단
            new Vector3(-1, 0, -1), // 좌하단
            new Vector3(1, 0, -1)   // 우하단
        };

        // 메시의 꼭짓점 연결(두 개의 삼각형으로 정사각형 생성)
        int[] triangles = {
            0, 2, 1, // 첫 번째 삼각형
            2, 3, 1  // 두 번째 삼각형
        };

        // 메시에 꼭짓점과 삼각형 할당
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // 메시에 기본 텍스처 적용을 위한 UV 매핑
        Vector2[] uv = {
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(0, 0),
            new Vector2(1, 0)
        };

        mesh.uv = uv;

        // 메시의 노멀 재계산 (라이팅을 위해)
        mesh.RecalculateNormals();
    }
}
