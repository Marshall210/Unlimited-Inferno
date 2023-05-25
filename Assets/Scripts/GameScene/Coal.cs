using System;
using UnityEngine;

public class Coal : MonoBehaviour
{
    public ParticleSystem explosionParticle;// for big kaboom
    public int CoalScore = 10;//value each coal for _score and increase size
    private Score score; //call _score.cs method

    void Start()
    {
        // Найти компонент ScoreManager
        score = FindObjectOfType<Score>(); //GameObject.Find("Score").GetComponent<Score>();
    }
    //add _score and destroy if touch
    void OnCollisionEnter2D(Collision2D other)
        {
        if (other.gameObject.CompareTag("Player"))
            Console.WriteLine("playerConnecting");
            score.AddScore(CoalScore);//insert CoalScore when define it
            Destroy(this.gameObject);
            //Destroy(other.gameObject);
            //if (_player != null) //check if player still alive!!!!
            //Instantiate(explosionParticle, transform.position,explosionParticle.transform.rotation);//kaboom
        }
}
