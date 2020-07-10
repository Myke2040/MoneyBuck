using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System;

public class coinCollect : MonoBehaviour
{

    public float fallSpeed = 10000.0f;
    public float spinSpeed = 250.0f;
    

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        

    }

    void OnMouseDown()
    {

        //renderer.enabled = false;

    }
    void OnCollisionEnter()
    {

        Destroy(gameObject);

    }

}