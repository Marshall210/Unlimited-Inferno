using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Camera mainCamera;  // Ссылка на камеру

    private float backgroundWidth;  // Ширина заднего фона
    private float backgroundHeight;  // Высота заднего фона

    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        backgroundWidth = spriteRenderer.bounds.size.x;
        backgroundHeight = spriteRenderer.bounds.size.y;
    }

    void Update()
    {
        // Позиционирование заднего фона относительно камеры
        Vector3 cameraPosition = mainCamera.transform.position;
        transform.position = new Vector3(cameraPosition.x, cameraPosition.y, transform.position.z);

        // Повторение заднего фона по оси X
        float horizontalOffset = cameraPosition.x % backgroundWidth;
        transform.position = new Vector3(transform.position.x - horizontalOffset, transform.position.y, transform.position.z);

        // Повторение заднего фона по оси Y
        float verticalOffset = cameraPosition.y % backgroundHeight;
        transform.position = new Vector3(transform.position.x, transform.position.y - verticalOffset, transform.position.z);
    }
}
