using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    // CHECK isRight for the right bound, UNCHECK for the left bound
    [Tooltip("Check for right bound, Uncheck for left bound.")]
    [SerializeField]
    bool isRight;
    
    // The object tag that triggers the collider
    [SerializeField]
    string triggerTag;

    Bounds bounds;

    private void Start()
    {
        // Check the background bounds
        bounds = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>().bounds;
        
        // Put the 
        transform.position = isRight ?
                             new Vector3(bounds.max.x, transform.position.y, transform.position.z) :
                             new Vector3(bounds.min.x, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggerTag)
        {   
            // Get the old player position and renderer;
            Vector3 playerPosition = other.transform.position;
            SpriteRenderer renderer = other.GetComponent<SpriteRenderer>();

            // New X value for position:
            // Teleport the player from one edge to te other +- player's width/2
            float newX = isRight ?
                        bounds.min.x + renderer.bounds.size.x/2 :
                        bounds.max.x - renderer.bounds.size.x/2;  

            other.transform.position = new Vector3(newX,
                                                    playerPosition.y,
                                                    playerPosition.z);
        }
    }
}
