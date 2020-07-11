using System;
using UnityEngine;

class DragTransform : MonoBehaviour
{
    public SpriteRenderer OwnRenderer;
    public Rigidbody2D    OwnRigidbody;
    public Rigidbody2D BoatRigidbody;

    private Color mouseOverColor = Color.blue;
    private Color originalColor  = Color.yellow;
    private bool  dragging       = false;
    private float distance = 0f;

    private Vector3 touchDownPoint;
    private float T = 0;

    public bool AttachImage;

    private void Start()
    {
        distance = 0f;
    }

    void OnMouseEnter()
    {
        OwnRenderer.material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        OwnRenderer.material.color = originalColor;
    }

    void OnMouseDown()
    {
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Vector3 touchDownPoint = ray.GetPoint(distance);
        // OwnRigidbody.MovePosition(touchDownPoint);

        // distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        // dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray     ray      = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            
            if(AttachImage)
            OwnRigidbody.MovePosition(rayPoint);
            
            this.T += Time.deltaTime;
            var abstand = Vector3.Distance(touchDownPoint, rayPoint);
            var speed = abstand / this.T;
            var dir = this.touchDownPoint - rayPoint;
            OwnRigidbody.velocity = -dir;


            var dirA = this.touchDownPoint - this.BoatRigidbody.transform.position;
            var dirB = rayPoint - this.BoatRigidbody.transform.position;
            var angle = Vector3.Angle(dirA, dirB);

            var forward = this.BoatRigidbody.transform.forward;
            var signed = Vector3.Dot(dirA, this.BoatRigidbody.transform.right);
            //this.BoatRigidbody.rotation += -angle/100;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            touchDownPoint = ray.GetPoint(distance);
            this.T = 0;
            
            distance = Vector3.Distance(transform.position, Camera.main.transform.position);

            dragging = true;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            dragging = false;
            
            OwnRigidbody.velocity = Vector2.zero;
        }
    }
}