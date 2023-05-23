using UnityEngine;

public class Coal : MonoBehaviour
{
    public GameObject Prefab;
    public float minSize = 50f;             // Минимальный размер угля
    public float maxSize = 150f;             // Максимальный размер угля
    public float spawnRadius = 2000f;          // Радиус появления угля от главного персонажа
    public float shrinkRate = 0.1f;          // Скорость уменьшения размера угля при соприкосновении с главным персонажем
    public float lifeTime = 5f; // время жизни огоньков
    public float spawnTime = 1.5f; // время между созданием огоньков


    private float currentSize;               // Текущий размер угля
    private Transform mainCharacterTransform; // Ссылка на трансформ главного персонажа
    private float timer;

    private void Start()
    {
        mainCharacterTransform = FindObjectOfType<PlayerController>().transform;
        currentSize = Random.Range(minSize, maxSize);
        transform.localScale = Vector3.one * currentSize;

        // Расположение угля в пределах радиуса от главного персонажа
        Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
        randomPosition.z = 0f; // Убедитесь, что уголь появляется на той же высоте, что и главный персонаж
        transform.position = mainCharacterTransform.position + randomPosition;
    }

    private void Update()
    {
        timer = Time.deltaTime;
        if (timer > spawnTime)
            Spawner();
        

        // Проверка соприкосновения с главным персонажем
        if (CheckMainCharacterCollision())
        {
            DecreaseSize();
        }
    }

    private bool CheckMainCharacterCollision()
    {
        // Логика определения соприкосновения угля с главным персонажем.
        // Например, использование коллайдера и тега для главного персонажа.
        // Вернуть true, если есть соприкосновение, иначе вернуть false.
        // Пример:
        // Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        // foreach (Collider collider in colliders)
        // {
        //     if (collider.CompareTag("MainCharacter"))
        //     {
        //         return true;
        //     }
        // }
        // return false;

        return false;  // Заглушка
    }

    private void DecreaseSize()
    {
        currentSize -= shrinkRate * Time.deltaTime;
        currentSize = Mathf.Clamp(currentSize, 0f, maxSize);  // Ограничение размера до максимального значения
        transform.localScale = Vector3.one * currentSize;

        if (currentSize <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void Spawner()
    {
        timer = 0f;

        // создаем огонек в случайной точке в радиусе спавна

        Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
        spawnPos.z = 0f; // Устанавливаем Z-координату равной 0
        GameObject fire = Instantiate(Prefab, spawnPos, Quaternion.identity);

        // устанавливаем время жизни огонька
        Destroy(fire, lifeTime + Random.Range(-1f, 1f));
    }
}
