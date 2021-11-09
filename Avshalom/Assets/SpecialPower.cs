using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialPower : MonoBehaviour
{
    float fullPower = 1; // According to slider's limits
    void Update()
    {
        // Get special power bar:
        Slider powerBar = GameObject.FindGameObjectWithTag("PowerBar").GetComponent<Slider>();

        if (Input.GetKeyDown(KeyCode.LeftControl) && powerBar.value == fullPower)
        {
            // Reset power bar:
            powerBar.value = 0;
            Image fill = GameObject.FindGameObjectWithTag("BarFill").GetComponent<Image>();
            fill.color = Color.green;

            // Stop special power alert from flickering
            Flicker specialPowerAlert = GameObject.FindGameObjectWithTag("PowerAlert").GetComponent<Flicker>();
            specialPowerAlert.setFlicker(false);

            // Destroy all enemies on the screen:
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            {
                Destroy(enemy);
            }

            // Spawn explosion animations:
            BombExplosion explosion = GameObject.FindGameObjectWithTag("ExplosionSpawner").GetComponent<BombExplosion>();
            explosion.spawnExplosions();
        }

    }
}
