using UnityEngine;
using UnityEngine.UI;

public class xiangzuo : MonoBehaviour
{
    public GameObject targetObject;  
    public float moveDistance = 10f;
    public Button moveButton;        

    void Start()
    {
        moveButton.onClick.AddListener(MoveLeft);
    }

    void MoveLeft()
    {
        if (targetObject != null)
        {
            
            targetObject.transform.Translate(Vector3.left * moveDistance, Space.World);
        }
        else
        {
            Debug.LogWarning("未指定目标物体！");
        }
    }
}
