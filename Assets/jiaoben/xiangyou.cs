using UnityEngine;
using UnityEngine.UI;

public class xiangyou : MonoBehaviour
{
    public GameObject targetObject; 
    public float moveDistance = 10f; 
    public Button moveButton;        

    void Start()
    {
        moveButton.onClick.AddListener(MoveRight);
    }

    void MoveRight()
    {
        if (targetObject != null)
        {
            
            targetObject.transform.Translate(Vector3.right * moveDistance, Space.World);
        }
        else
        {
            Debug.LogWarning("未指定目标物体！");
        }
    }
}