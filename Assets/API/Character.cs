using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class Character : MonoBehaviour
{
    public List<SpriteRenderer> OwnSorting;
    public Transform      OwnTransform;
    public CharacterInput CharacterInput;
    public Collider2D OwnCollider;
    
    public static Character Current;

    private void Start()
    {
        Current = this;
    }
    
    private void Update()
    {
        UpdateSprites();
    }

    private void UpdateSprites()
    {
        for (int c = 0; c < this.OwnSorting.Count; c++)
        {
            var sorting = Mathf.RoundToInt(this.OwnSorting[c].transform.position.y * 100f) * -1;
            this.OwnSorting[c].sortingOrder = sorting;
        }
    }

    public void SetCharacterOn(Vector3 position)
    {
        this.OwnTransform.position = position;
    }
    
    public void SetCharacterLayer(LayerMask layer)
    {
        this.gameObject.layer = layer;
        foreach (Transform child in this.gameObject.GetComponentsInChildren<Transform>(true))  
        {
            child.gameObject.layer = layer; // add any layer you want. 
        }
    }
}