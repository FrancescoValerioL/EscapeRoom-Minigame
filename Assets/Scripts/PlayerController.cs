using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float movementSpeed;
    private float horizontalMovement;
    private float verticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

    }
    //Player movement controller
    private void PlayerMovement()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed;
        verticalMovement = Input.GetAxis("Vertical") * movementSpeed;
        playerRb.velocity = new Vector3(horizontalMovement, 0, verticalMovement);
        
    }
}
