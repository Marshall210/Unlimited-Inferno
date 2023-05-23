using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // ссылка на текстовое поле, отображающее счет
    public Text multiplierText; // ссылка на текстовое поле, отображающее множитель
    public float timeToIncreaseScore = 1f; // время через которое счет будет увеличиваться
    public float increaseAmount = 1f; // количество очков, добавляемых к счету при увеличении
    public float maxMultiplierDuration = 5f; // максимальная длительность множителя
    public int maxMultiplier = 3; // максимальный множитель

    private float scoreTimer = 0f; // таймер для увеличения счета
    private int currentScore = 0; // текущий счет
    private int currentMultiplier = 1; // текущий множитель
    private float multiplierTimer = 0f; // таймер для длительности множителя

    // Вызывается каждый кадр
    private void Update()
    {
        // Обновляем таймер увеличения счета
        scoreTimer += Time.deltaTime;
        if (scoreTimer >= timeToIncreaseScore)
        {
            IncreaseScore(increaseAmount);
            scoreTimer = 0f;
        }

        // Обновляем таймер длительности множителя
        if (currentMultiplier > 1)
        {
            multiplierTimer -= Time.deltaTime;
            if (multiplierTimer <= 0f)
            {
                currentMultiplier = 1;
                multiplierText.gameObject.SetActive(false);
            }
        }

        // Обновляем текстовые поля для отображения счета и множителя
        scoreText.text = "Score: " + currentScore.ToString();
        if (currentMultiplier > 1)
        {
            multiplierText.text = "x" + currentMultiplier.ToString();
        }
    }

    // Увеличивает счет на заданное количество очков
    public void IncreaseScore(float amount)
    {
        currentScore += Mathf.RoundToInt(amount * currentMultiplier);
    }

    // Увеличивает множитель на 1
    public void IncreaseMultiplier()
    {
        currentMultiplier++;
        currentMultiplier = Mathf.Clamp(currentMultiplier, 1, maxMultiplier);
        multiplierTimer = maxMultiplierDuration;
        multiplierText.gameObject.SetActive(true);
    }
}
