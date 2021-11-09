using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{ 
    // A simple script used for placing the slider on the background bouundaries
    void Start()
    {
        Bounds bounds = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>().bounds;
        RectTransform rt = GetComponent<RectTransform>();
        int offset = 1;
        transform.position = new Vector3(bounds.min.x + rt.rect.size.y * rt.lossyScale.y,
                                            transform.position.y,
                                            transform.position.z);
    }
}
