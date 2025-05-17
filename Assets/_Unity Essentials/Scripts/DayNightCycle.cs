using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Тривалість повного дня у секундах")]
    public float dayDuration = 60f; 

    void Update()
    {
        // Обчислення кута обертання
        float rotationSpeed = 360f / dayDuration * Time.deltaTime;
        transform.Rotate(Vector3.right, rotationSpeed);
    }
}
