using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public SpriteRenderer OwnRenderer;
    public Transform      OwnTransform;

    private void Update()
    {
        OwnRenderer.sortingOrder = Mathf.RoundToInt(OwnTransform.position.y * 100f) * -1;
    }
}