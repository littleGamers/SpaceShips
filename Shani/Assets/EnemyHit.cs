using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Get NumberField object to decrement the number of hits when got hit and destroy game object (enemy)
        if (other.tag == triggeringTag && enabled)
        {
            GameObject newObject = GameObject.FindGameObjectWithTag("Lives");
            if (newObject)
            {
                NumberField numberOfHits = newObject.GetComponent<NumberField>();
                Destroy(other.gameObject);
                numberOfHits.decrementHit();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
