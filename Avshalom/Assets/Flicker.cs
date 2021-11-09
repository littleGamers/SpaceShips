using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    [Tooltip("While true - the object is flickering")]
    [SerializeField] bool flickerEnabled = false;
    [Tooltip("Delay in seconds between flickers")]
    [SerializeField] float flickerDelay = 1f;
    void Start()
    {
        this.StartCoroutine(flicker());
    }

    // A simple coroutine for showing/hiding the object (flicker)
    private IEnumerator flicker()
    {
        while (true)
        {
            yield return new WaitForSeconds(flickerDelay);

            if (!flickerEnabled)
                continue;
            
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = true;
            yield return new WaitForSeconds(flickerDelay);
            renderer.enabled = false;
            
        }
    }

    // Turn flickering on/off
    public void setFlicker(bool mode)
    {
        flickerEnabled = mode;
    }
}
