using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruder : MonoBehaviour
{
    public bool IsMouseDown;
    public Rigidbody2D OwnRigidbody2D;
    public Rigidbody2D BoatRigid;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        BoatRigid.velocity = -OwnRigidbody2D.velocity;
    }

    private void OnMouseDown()
    {
        IsMouseDown = true;
    }

    private void OnMouseUp()
    {
        IsMouseDown = false;
    }
}
