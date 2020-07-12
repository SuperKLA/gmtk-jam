﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    public Rigidbody2D OwnRigidBody;
    public float Speed = 1f;
    public event Action OnMove;

    public void Update()
    {
        Vector2 moveDir = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDir.x = Speed;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDir.x = -Speed;
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDir.y = Speed;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDir.y = -Speed;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //DialogTest:
            DialogManager dm = FindObjectOfType<DialogManager>();
            if (!dm.IsDialogActive)
                dm.StartDialog(Dialogs.Dialog22);
            else
                dm.NextTextInDialog();
        }
        
        moveDir.x = Mathf.Clamp(moveDir.x, -this.Speed, this.Speed);
        moveDir.y = Mathf.Clamp(moveDir.y, -this.Speed, this.Speed);
        
        this.OwnRigidBody.velocity = moveDir;
    }
}