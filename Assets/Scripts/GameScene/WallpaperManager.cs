using UnityEngine;

public class WallpaperManager : MonoBehaviour
{
    public Sprite[] wallpapers; // Массив спрайтов обоев

    private void Start()
    {
        // Получаем компонент SpriteRenderer у объекта, на котором находится этот скрипт
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // Выбираем случайный индекс обоев
        int randomIndex = Random.Range(0, wallpapers.Length);

        // Получаем случайный спрайт из массива
        Sprite randomWallpaper = wallpapers[randomIndex];

        // Применяем случайный спрайт к фону
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = randomWallpaper;
        }
    }
}