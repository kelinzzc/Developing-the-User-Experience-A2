using UnityEngine;

public class xiaocao : MonoBehaviour
{
    public int grassCount = 100;    // 生成数量
    public float areaSize = 10f;    // 生成区域范围
    public float minScale = 0.8f;   // 最小缩放
    public float maxScale = 1.2f;   // 最大缩放

    public Material grassMaterial; // 草的材质（需透明支持）

    void Start()
    {
        GenerateGrass();
    }

    void GenerateGrass()
    {
        for (int i = 0; i < grassCount; i++)
        {
            // 随机位置（XZ平面）
            Vector3 position = new Vector3(
                Random.Range(-areaSize, areaSize),
                0,
                Random.Range(-areaSize, areaSize)
            );

            // 创建草叶物体
            GameObject grass = new GameObject("Grass");
            grass.transform.parent = transform;
            grass.transform.position = position;
            grass.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            grass.transform.localScale = Vector3.one * Random.Range(minScale, maxScale);

            // 添加 Mesh 组件
            MeshFilter meshFilter = grass.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = grass.AddComponent<MeshRenderer>();
            Mesh mesh = new Mesh();

            // 定义顶点（两个交叉的四边形）
            Vector3[] vertices = new Vector3[8]
            {
                // 第一个四边形
                new Vector3(-0.1f, 0, 0), // 0
                new Vector3(0.1f, 0, 0),  // 1
                new Vector3(0.1f, 1, 0),  // 2
                new Vector3(-0.1f, 1, 0), // 3

                // 第二个四边形（旋转90度）
                new Vector3(0, 0, -0.1f), // 4
                new Vector3(0, 0, 0.1f),  // 5
                new Vector3(0, 1, 0.1f),  // 6
                new Vector3(0, 1, -0.1f)  // 7
            };

            // 定义顶点（共 5 个顶点：4个边缘顶点 + 1个中心顶点）
Vector3[] vertices1 = new Vector3[5]
{
    // 中心顶点（索引0）
    new Vector3(0, 0, 0),

    // 第一个四边形的边缘顶点（X方向）
    new Vector3(-0.1f, 1, 0), // 索引1
    new Vector3(0.1f, 1, 0),  // 索引2

    // 第二个四边形的边缘顶点（Z方向）
    new Vector3(0, 1, -0.1f), // 索引3
    new Vector3(0, 1, 0.1f)   // 索引4
};

// 定义三角形（基于共享中心顶点）
int[] triangles = new int[12]
{
    // 第一个四边形（X方向）
    0, 1, 2, // 底部到顶部三角形
    0, 2, 1, // 反向三角形形成四边形（可选）

    // 第二个四边形（Z方向）
    0, 3, 4,
    0, 4, 3
};

            // 应用数据
            mesh.vertices = vertices;
            mesh.triangles = triangles;
            mesh.RecalculateNormals();
            meshFilter.mesh = mesh;

            // 设置材质
            meshRenderer.material = grassMaterial;
        }
    }
}