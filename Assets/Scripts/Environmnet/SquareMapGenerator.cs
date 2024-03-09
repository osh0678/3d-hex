using UnityEngine;
public class SquareMapGenerator : MonoBehaviour
{
    void Start()
    {
        // �޽� ����
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        // ���簢�� ���� ������ ����
        Vector3[] vertices = {
            new Vector3(-1, 0, 1),  // �»��
            new Vector3(1, 0, 1),   // ����
            new Vector3(-1, 0, -1), // ���ϴ�
            new Vector3(1, 0, -1)   // ���ϴ�
        };

        // �޽��� ������ ����(�� ���� �ﰢ������ ���簢�� ����)
        int[] triangles = {
            0, 2, 1, // ù ��° �ﰢ��
            2, 3, 1  // �� ��° �ﰢ��
        };

        // �޽ÿ� �������� �ﰢ�� �Ҵ�
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // �޽ÿ� �⺻ �ؽ�ó ������ ���� UV ����
        Vector2[] uv = {
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(0, 0),
            new Vector2(1, 0)
        };

        mesh.uv = uv;

        // �޽��� ��� ���� (�������� ����)
        mesh.RecalculateNormals();
    }
}
