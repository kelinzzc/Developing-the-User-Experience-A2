using UnityEngine;
using UnityEngine.UI;

public class zuo : MonoBehaviour
{
    public GameObject targetObject;   
    public float rotationAngle = 45f; 
    public Button rotateButton;       

    void Start()
    {
        rotateButton.onClick.AddListener(RotateLeft);
    }

    void RotateLeft()
    {
        if (targetObject != null)
        {
            // 绕 Y 轴向左旋转 45 度（本地坐标系）
            targetObject.transform.Rotate(0, rotationAngle, 0, Space.Self);
        }
        else
        {
            Debug.LogWarning("未指定目标物体！");
        }
    }
}