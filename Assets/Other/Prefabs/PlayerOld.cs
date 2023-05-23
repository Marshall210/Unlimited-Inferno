using UnityEngine;

public class PlayerOld : MonoBehaviour
{
    public float Force; // Add force amount
    public Rigidbody2D PlayerObject; // Player Object
    //public Health PlayerHealth; // Link to Health component

    private void Update()
    {
        // Check keyboard keys
        
        if (Input.GetKey(KeyCode.Space))
        {
            AddForceToPlayer(new Vector2(0, Force)); // Move to up
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            AddForceToPlayer(new Vector2(-Force, 0)); // Move to left
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            AddForceToPlayer(new Vector2(Force, 0)); // Move to right
        }
    }
    
    private void AddForceToPlayer(Vector2 force)
    {
        //// Check health availability
        //if (PlayerHealth.HealthCount <= 0)
        //    return;
        
        //PlayerObject.AddForce(force); // Add force to player
        //PlayerHealth.DecreaseHealth(); // Reduce health
    }
}
