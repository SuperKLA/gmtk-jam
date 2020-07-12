using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    DialogManager DM { get { return DialogManager.Current; } }
    
    public Animator OwnAnimator;
    public Rigidbody2D OwnRigidBody;
    public float Speed = 1f;
    private static readonly int Speed1 = Animator.StringToHash("Speed");
    public event Action OnMove;

    public void Update()
    {
        if (GameRunTime.TerminalOpen)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameRunTime.SpaceUPCanFire = true;
        }

        if (Input.GetKeyUp(KeyCode.Space) && DialogManager.Current.IsDialogActive && GameRunTime.SpaceUPCanFire)
        {
            GameRunTime.SpaceUPCanFire = false;
            DialogManager.Current.NextTextInDialog();
        }

        if (DialogManager.Current.IsDialogActive )
            return;

        Vector2 moveDir = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveDir.x = Speed;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveDir.x = -Speed;
        }
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            moveDir.y = Speed;
        }
        
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            moveDir.y = -Speed;
        }

        

        OwnAnimator.SetFloat(Speed1, Mathf.Clamp01(moveDir.sqrMagnitude));
        
        moveDir.x = Mathf.Clamp(moveDir.x, -this.Speed, this.Speed);
        moveDir.y = Mathf.Clamp(moveDir.y, -this.Speed, this.Speed);
        
        this.OwnRigidBody.velocity = moveDir;
    }
}