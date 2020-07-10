using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    private float moveSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(dirX, 0f);
    }
    void OnCollisionEnter()
    {

        Destroy(rb);

    }

}
