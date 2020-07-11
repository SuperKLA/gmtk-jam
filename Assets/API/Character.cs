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
}