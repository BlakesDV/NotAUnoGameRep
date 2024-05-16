using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardData : MonoBehaviour
{
    public SpriteRenderer variantSpriteRenderer;

    [Serializable]
    public struct Variant
    {
        public Sprite sprite;
        public int number;
    }
    public List<Variant> variants = new List<Variant>();

    public void SetVariant(int index)
    {
        if (index < 0 || index >= variants.Count)
        {
            Debug.LogError("Invalid index!");
            return;
        }
        if (variantSpriteRenderer != null)
        {
            variantSpriteRenderer.sprite = variants[index].sprite;
        }
        else
        {
            Debug.LogError("Variant SpriteRenderer reference not set!");
        }
    }

    // Example function to randomly select a variant and set it
    public void SetRandomVariant()
    {
        if (variants.Count == 0)
        {
            Debug.LogError("No variants defined!");
            return;
        }
        int randomIndex = UnityEngine.Random.Range(0, variants.Count);
        SetVariant(randomIndex);
    }
}
