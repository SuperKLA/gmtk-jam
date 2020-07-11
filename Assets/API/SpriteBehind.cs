using UnityEngine;


public class SpriteBehind : MonoBehaviour {
    public Color color = Color.white;

    public SpriteRenderer spriteRenderer;

    void OnBecameVisible() {

        UpdateOutline(true);
    }

    void OnBecameInvisible() {
        UpdateOutline(false);
    }

    // void Update() {
    //     UpdateOutline(true);
    // }

    void UpdateOutline(bool outline) {
        MaterialPropertyBlock mpb = new MaterialPropertyBlock();
        spriteRenderer.GetPropertyBlock(mpb);
        mpb.SetColor("_Color", outline ? color : Color.clear);
        spriteRenderer.SetPropertyBlock(mpb);
    }
}