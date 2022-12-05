using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rick;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueMag = 0f; // torque magnitude
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 20f;
    bool canMove = true;

    void Start()
    {
        rick = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.Space))
            surfaceEffector2D.speed = boostSpeed;
        else
            surfaceEffector2D.speed = normalSpeed;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rick.AddTorque(torqueMag);

        else if (Input.GetKey(KeyCode.RightArrow))
            rick.AddTorque(-torqueMag);
    }
}
