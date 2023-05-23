using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    public Sprite[] sprites; // Массив спрайтов для анимации
    public float frameRate = 0.2f; // Частота смены спрайтов

    private SpriteRenderer spriteRenderer;
    private int currentIndex = 0;
    private float timer = 0f;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= frameRate)
        {
            timer = 0f;

            currentIndex++;
            if (currentIndex >= sprites.Length)
            {
                currentIndex = 0;
            }

            spriteRenderer.sprite = sprites[currentIndex];
        }
    }
}
