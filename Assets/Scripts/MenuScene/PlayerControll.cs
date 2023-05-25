using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость перемещения игрока

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
        rb.velocity = movement * moveSpeed;
    }
}





//using UnityEngine;

//public class MainCharacter : MonoBehaviour
//{
//    public float growthRate = 0.1f;  // Скорость увеличения размера при касании угля
//    public float shrinkRate = 0.1f;  // Скорость уменьшения размера при отсутствии касания угля
//    public float windForce = 10f;    // Сила ветра, которая сдувает главного персонажа

//    private float currentSize = 200f;  // Текущий размер главного персонажа

//    private void Start()
//    {
//        // Главный персонаж начинает с размером 1
//        transform.localScale = Vector3.one * currentSize;
//    }

//    private void Update()
//    {
//        // Перемещение главного персонажа
//        MoveCharacter();

//        // Изменение размера главного персонажа при касании угля или отсутствии касания
//        //if (CheckCoalCollision())
//        //{
//        //    IncreaseSize();
//        //}
//        //else
//        //{
//        //    DecreaseSize();
//        //}

//        //// Проверка сдувания главного персонажа ветром
//        //if (CheckWindCollision())
//        //{
//        //    BlowAway();
//        //}
//    }

//    private void MoveCharacter()
//    {
//        // Логика перемещения главного персонажа.
//        // Например, использование Input.GetAxis для управления перемещением.
//        float moveX = Input.GetAxis("Horizontal");
//        float moveY = Input.GetAxis("Vertical");
//        transform.Translate(new Vector3(moveX, moveY, 0f ) * Time.deltaTime);
//    }

//    private bool CheckCoalCollision()
//    {
//        // Логика определения касания главного персонажа с углем.
//        // Например, использование коллайдера и тега для угля.
//        // Вернуть true, если есть касание, иначе вернуть false.
//        // Пример:
//        // Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
//        // foreach (Collider collider in colliders)
//        // {
//        //     if (collider.CompareTag("Coal"))
//        //     {
//        //         return true;
//        //     }
//        // }
//        // return false;

//        return false;  // Заглушка
//    }

//    private void IncreaseSize()
//    {
//        currentSize += growthRate * Time.deltaTime;
//        transform.localScale = Vector3.one * currentSize;
//    }

//    private void DecreaseSize()
//    {
//        currentSize -= shrinkRate * Time.deltaTime;
//        currentSize = Mathf.Clamp(currentSize, 0.1f, 1f);  // Ограничение размера до минимального значения
//        transform.localScale = Vector3.one * currentSize;
//    }

//    private bool CheckWindCollision()
//    {
//        // Логика определения касания главного персонажа с ветром.
//        // Например, использование коллайдера и тега для ветра.
//        // Вернуть true, если есть касание, иначе вернуть false.
//        // Пример:
//        // Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
//        // foreach (Collider collider in colliders)
//        // {
//        //     if (collider.CompareTag("Wind"))
//        //     {
//        //         return true;
//        //     }
//        // }
//        // return false;

//        return false;  // Заглушка
//    }

//    private void BlowAway()
//    {
//        currentSize -= shrinkRate * Time.deltaTime;
//        currentSize = Mathf.Clamp(currentSize, 0.1f, 1f);  // Ограничение размера до минимального значения
//        transform.localScale = Vector3.one * currentSize;

//        // Применение силы ветра для сдувания
//        //Vector3 windDirection = /*Логика определения направления ветра*/;
//        //GetComponent<Rigidbody>().AddForce(windDirection * windForce);
//    }
//}

