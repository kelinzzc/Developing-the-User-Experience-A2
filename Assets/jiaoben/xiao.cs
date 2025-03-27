using UnityEngine;
using UnityEngine.UI;

public class xiao : MonoBehaviour
{
    public GameObject targetObject; 
    public float shrinkFactor = 0.5f; 
    public Button shrinkButton;      

    void Start()
    {
        shrinkButton.onClick.AddListener(ShrinkObject);
    }

    void ShrinkObject()
    {
        if (targetObject != null)
        {
            // 直接缩小物体
            targetObject.transform.localScale *= shrinkFactor;
        }
        else
        {
            Debug.LogWarning("未指定目标物体！");
        }
    }
}