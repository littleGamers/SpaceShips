using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerCharge : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [Tooltip("Adds special power charge when destroying enemies.")]
    [SerializeField] float enemyPowerPoints = 10f;
    float fullPower = 1; // According to slider's limits

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag)
        {
            // Get special power bar:
            Slider powerBar = GameObject.FindGameObjectWithTag("PowerBar").GetComponent<Slider>();
            powerBar.value += enemyPowerPoints;

            if (powerBar.value == fullPower)
            {
                // Paint slider in blue;
                Image fill = GameObject.FindGameObjectWithTag("BarFill").GetComponent<Image>();
                fill.color = Color.blue;

                // Make special ability alert flicker:
                Flicker specialPowerAlert = GameObject.FindGameObjectWithTag("PowerAlert").GetComponent<Flicker>();
                specialPowerAlert.setFlicker(true);
            }

        }
    }
}
