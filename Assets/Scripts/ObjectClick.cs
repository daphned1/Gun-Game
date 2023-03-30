using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public float t;
    public Transform target;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "Coin") {
            Vector3 a = transform.position;
            Vector3 b = target.position;
            transform.position = Vector3.Lerp(a, b, t);
        }
    }
}
