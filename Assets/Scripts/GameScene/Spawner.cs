using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Spawner : MonoBehaviour
{

    //private GameObject PPrefab; // префаб огонька
    public GameObject Prefab; // префаб огонька
    public float spawnTime = 1.5f; // время между созданием огоньков
    public float lifeTime = 5f; // время жизни огоньков
    public float spawnRadius = 5f; // радиус спавна огоньков
    public Transform firePosition;// player location for spawner

    private float _timer; // таймер для создания огоньков


    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= spawnTime)
        {
            _timer = 0f;

            // Получение положения другого объекта
            Vector2 position = firePosition.position;

            // создаем огонек в случайной точке в радиусе спавна

            Vector2 spawnPos = firePosition.position + Random.insideUnitSphere * spawnRadius;
            //spawnPos.z = 0f; // Устанавливаем Z-координату равной 0
            GameObject fire = Instantiate(Prefab, spawnPos, Quaternion.identity);

            // устанавливаем время жизни огонька
            Destroy(fire, lifeTime + Random.Range(-1f, 1f));
        }
    }
}
