using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public float KeeperSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            gameObject.transform.position = new Vector3(transform.position.x - (KeeperSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.position = new Vector3(transform.position.x + (KeeperSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LeftBoarder")
        {
            gameObject.transform.position = new Vector3(-4.6f, transform.position.y, transform.position.z);
        }
        if (other.tag == "RightBoarder")
        {
            gameObject.transform.position = new Vector3(4.6f, transform.position.y, transform.position.z);
        }
    }
}