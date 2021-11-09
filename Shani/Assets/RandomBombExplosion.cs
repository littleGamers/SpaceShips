using System.Collections;
using UnityEngine;

/**
 * This component instantiates a given prefab at random time intervals and random bias from its object position.
 */
public class RandomBombExplosion : MonoBehaviour
{
    [SerializeField] Transform prefabToSpawn;
    [SerializeField] float numOfExplosions;
    Vector3 leftBound;
    Vector3 rightBound;

    void Start()
    {
        Bounds boundPoints = GameObject.FindGameObjectWithTag("BackGround").GetComponent<SpriteRenderer>().bounds;
        leftBound = boundPoints.min;
        rightBound = boundPoints.max;
    }

    private void Update()
    {
        // Loop till counter will get to number of explosions as requested in GUI
        float counter = 0;
        while (counter <= numOfExplosions)
        {
            // Set the range of the explosions on all map
            Vector3 positionOfSpawnedObject = new Vector3(
                Random.Range(leftBound.x, rightBound.x),
                Random.Range(leftBound.y, rightBound.y),
                transform.position.z);
            // Create new explosion with the position and no rotation and increment counter by 1
            Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
            counter++;
        }
        // When finished the amount of requested explosions - disable them
        this.enabled = false;
    }
}