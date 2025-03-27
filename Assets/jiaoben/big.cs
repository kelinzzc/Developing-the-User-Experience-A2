using UnityEngine;
using UnityEngine.UI; 

public class big : MonoBehaviour
{
    public GameObject targetObject; 
    public float scaleFactor = 1.5f; 
    public Button scaleButton;      

    void Start()
    {
        
        scaleButton.onClick.AddListener(ScaleObject);
    }

    void ScaleObject()
    {
        if (targetObject != null)
        {
            
            targetObject.transform.localScale *= scaleFactor;
        }
        else
        {
            Debug.LogWarning("未指定目标物体！");
        }
    }
}