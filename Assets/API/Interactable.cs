using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public event Action OnInteracting;
    public event Action OnInteractableLeft;
    
    public bool CanInteract = false;
    public BoxCollider2D OwnCollider;

    public bool IsInBounds(Bounds bounds)
    {
        return OwnCollider.bounds.Intersects(bounds);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        CanInteract = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CanInteract = false;
        if (OnInteractableLeft != null) OnInteractableLeft();
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && this.CanInteract)
        {
            if (OnInteracting != null)
            {
                OnInteracting();
            }
        }
    }
}
