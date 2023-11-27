using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    [SerializeField] private  GameObject targetObject;

    public void Toggle()
    {
        targetObject.SetActive(!targetObject.activeSelf);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toggle();
        }
    }
}
