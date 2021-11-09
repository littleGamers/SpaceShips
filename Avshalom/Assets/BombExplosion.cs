using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BombExplosion : MonoBehaviour
{
    [SerializeField] Transform prefabToSpawn;

    [Tooltip("Number of explosions in one time")]
    [SerializeField] float numOfExplosions; // When using special power

    // Background bouundaries to specify bounds for the spawn
    Vector3 maxPoint;
    Vector3 minPoint;

    void Start()
    {
        // Calculate bounds
        Bounds bounds = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>().bounds;
        maxPoint = bounds.max;
        minPoint = bounds.min;
        this.enabled = false;
    }

    // Spawns 'numOfExplosions' explosions in one time and suspends itselfl until next call:
    private void Update()
    {
        // Get the special power bar:
        Slider powerBar = GameObject.FindGameObjectWithTag("PowerBar").GetComponent<Slider>();
        float counter = 0;

        // Spawn explosions:
        while (counter++ < numOfExplosions)
        {
            // Generate random x and y values:
            Vector3 positionOfSpawnedObject = new Vector3(Random.Range(minPoint.x, maxPoint.x),
                                                            Random.Range(minPoint.y, maxPoint.y),
                                                            transform.position.z);

            // Spawn explosion
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
        }
        this.enabled = false;
    }

    public void spawnExplosions()
    {
        this.enabled = true;
    }
}
