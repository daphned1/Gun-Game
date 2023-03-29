using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private float speed = 1000f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(10 * Time.deltaTime * speed, 10 * Time.deltaTime * speed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
