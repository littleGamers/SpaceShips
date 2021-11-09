using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombHit : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Get NumberField object to decrement the number of hits when got hit and destroy game object (enemy)
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(other.gameObject);
            // Get enemy game object and loop over all of them to destroy all enemies in explosion
            GameObject []enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject enemy in enemyObjects)
            {
                Destroy(enemy);
            }
            // get explode object and turn it on to make explosion after bomb hit
            RandomBombExplosion explodeObject = GameObject.FindGameObjectWithTag("Explode").GetComponent<RandomBombExplosion>();
            explodeObject.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
