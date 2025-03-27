using UnityEngine;
using UnityEngine.UI;

public class chongzhi : MonoBehaviour
{
    public GameObject targetObject;  
    public Button resetButton;       

    
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Vector3 originalScale;

    void Start()
    {
    
        originalPosition = targetObject.transform.position;
        originalRotation = targetObject.transform.rotation;
        originalScale = targetObject.transform.localScale;

        
        resetButton.onClick.AddListener(ResetToInitial);
    }

    
    void ResetToInitial()
    {
        if (targetObject != null)
        {
            targetObject.transform.position = originalPosition;
            targetObject.transform.rotation = originalRotation;
            targetObject.transform.localScale = originalScale;
        }
        else
        {
            Debug.LogWarning("未指定目标物体！");
        }
    }
}