using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public event Action OnInteracting;
    public bool CanInteract = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        CanInteract = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CanInteract = false;
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && this.CanInteract)
        {
            if (OnInteracting != null) OnInteracting();
        }
    }
}
