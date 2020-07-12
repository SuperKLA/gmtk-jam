using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteAlways]
public class NPC : MonoBehaviour
{
    public List<SpriteRenderer> OwnSorting;
    public Interactable ActionSpace;
    public Interactive trigger;

    void Start()
    {
        ActionSpace.OnInteracting += OnInteracting;
    }

    private void OnValidate()
    {
        ActionSpace = this.GetComponentInChildren<Interactable>();
        OwnSorting = OwnSorting ?? new List<SpriteRenderer>();
        
        this.OwnSorting.Clear();
        this.OwnSorting.AddRange(this.GetComponentsInChildren<SpriteRenderer>());
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
    
    private void OnInteracting()
    {
        GameRunTime.Current.EventTriggert(trigger);
    }
}
