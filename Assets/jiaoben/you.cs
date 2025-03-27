using UnityEngine;
using UnityEngine.UI;

public class you : MonoBehaviour
{
    public GameObject targetObject;   
    public float rotationAngle = -45f; 
    public Button rotateButton;       

    void Start()
    {
        rotateButton.onClick.AddListener(RotateRight);
    }

    void RotateRight()
    {
        if (targetObject != null)
        {
            
            targetObject.transform.Rotate(0, rotationAngle, 0, Space.Self);
        }
        else
        {
            Debug.LogWarning("未指定目标物体！");
        }
    }
}