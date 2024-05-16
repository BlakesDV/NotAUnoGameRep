using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardData : MonoBehaviour
{
    // Reference to the SpriteRenderer where the sprite will be displayed
    public SpriteRenderer variantSpriteRenderer;

    // Define a structure to hold sprite and number variants
    [Serializable]
    public struct Variant
    {
        public Sprite sprite;
        public int number;
    }

    // List of sprite variants
    public List<Variant> variants = new List<Variant>();

    // Example function to set the sprite and number
    public void SetVariant(int index)
    {
        if (index < 0 || index >= variants.Count)
        {
            Debug.LogError("Invalid index!");
            return;
        }

        // Ensure variantSpriteRenderer is not null before attempting to access it
        if (variantSpriteRenderer != null)
        {
            variantSpriteRenderer.sprite = variants[index].sprite;
        }
        else
        {
            Debug.LogError("Variant SpriteRenderer reference not set!");
        }

        // You can set the number to a text component or use it as you need
        Debug.Log("Number: " + variants[index].number);
    }

    // Example function to randomly select a variant and set it
    public void SetRandomVariant()
    {
        if (variants.Count == 0)
        {
            Debug.LogError("No variants defined!");
            return;
        }

        // Get a random index within the range of variants list
        int randomIndex = UnityEngine.Random.Range(0, variants.Count);

        // Set the sprite and number based on the random variant
        SetVariant(randomIndex);
    }
}
