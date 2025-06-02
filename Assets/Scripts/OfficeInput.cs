using UnityEngine;

public class OfficeInput : MonoBehaviour
{
    public float edgeThreshold = 100f;
    public float rotationSpeed = 50f;
    public float minYaw = -60f;
    public float maxYaw = 60f;

    private float currentYaw;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        currentYaw = transform.localEulerAngles.y;
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        float screenWidth = Screen.width;

        if (mousePos.x <= edgeThreshold)
        {
            currentYaw -= rotationSpeed * Time.deltaTime;
        }
        else if (mousePos.x >= screenWidth - edgeThreshold)
        {
            currentYaw += rotationSpeed * Time.deltaTime;
        }

        currentYaw = Mathf.Clamp(currentYaw, minYaw, maxYaw);
        transform.localEulerAngles = new Vector3(0f, currentYaw, 0f);
    }
}