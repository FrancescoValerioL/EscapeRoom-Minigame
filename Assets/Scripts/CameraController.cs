using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Rigidbody playerBody;
    private Vector3 offset = new Vector3(10, 4.5f, -11);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Make tha camera follow the player
        transform.position = playerBody.transform.position + offset;
    }
}
