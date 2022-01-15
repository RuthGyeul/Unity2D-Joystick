using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    Rigidbody2D myRigid;
    Vector3 playerPosition;
    public float moveSpeed = 8.0f;
    public bool Left_Key = false;
    public bool Right_Key = false;
    public bool Up_Key = false;
    public bool Down_Key = false;

    void Start () 
    {
        // myRigid = GetComponent<Rigidbody2D>();
    }

    void Update () {
        myRigid = GetComponent<Rigidbody2D>();
        // Get component
        playerPosition = this.transform.position;
        // Keep updating character's position

        if (Left_Key)
        {
            playerPosition += Vector3.left * moveSpeed * Time.deltaTime;
            // character position + move left with certain speed
            myRigid.MovePosition(playerPosition);
            // character position move
        }
        if (Right_Key)
        {
            playerPosition += Vector3.right * moveSpeed * Time.deltaTime;
            myRigid.MovePosition(playerPosition);
        }
        if (Up_Key)
        {
            playerPosition += Vector3.up * moveSpeed * Time.deltaTime;
            myRigid.MovePosition(playerPosition);
        }
        if (Down_Key)
        {
            playerPosition += Vector3.down * moveSpeed * Time.deltaTime;
            myRigid.MovePosition(playerPosition);
        }
    }
}
