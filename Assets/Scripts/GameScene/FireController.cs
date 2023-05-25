using UnityEngine;

public class FireController : MonoBehaviour
{
    public float speed = 5f; // скорость движения огонька
    public float windStrength = 1f; // сила ветра
    public float maxWind = 5f; // максимальная сила ветра
    public float minWind = -5f; // минимальная сила ветра

    private Rigidbody2D _rb; // компонент физики огонька
    private int _score;

    void Start()
    {
        // получаем компонент Rigidbody2D объекта
        _rb = GetComponent<Rigidbody2D>();

        // инициализируем начальные параметры огонька
        //transform.localScale = new Vector3(0.5f, 0.5f, 1f); // задаем размер огонька
        transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)); // задаем случайное вращение огонька
    }

    void Update()
    {
        // перемещаем огонек в зависимости от введенных пользователем значений
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        _rb.AddForce(movement * speed);

        // меняем направление ветра и силу его воздействия
        windStrength += Random.Range(-0.1f, 0.1f);
        windStrength = Mathf.Clamp(windStrength, minWind, maxWind);

        // применяем силу ветра к огоньку
        Vector2 windForce = new Vector2(windStrength, 0);
        _rb.AddForce(windForce);
    }

}