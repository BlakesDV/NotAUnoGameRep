using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrawer : MonoBehaviour
{
    public GameObject[] cardPrefabs; // Array of card prefabs
    public GameObject player1Panel;
    public GameObject player2Panel;

    List<GameObject> cards = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // Add card prefabs to the list
        foreach (GameObject cardPrefab in cardPrefabs)
        {
            cards.Add(cardPrefab);
        }
    }

    public void StartingDraw()
    {
        for (int i = 0; i < 7; i++)
        {
            GameObject player1Card = Instantiate(cards[Random.Range(0, cards.Count)]);
            player1Card.transform.SetParent(player1Panel.transform, false);

            GameObject player2Card = Instantiate(cards[Random.Range(0, cards.Count)]);
            player2Card.transform.SetParent(player2Panel.transform, false);
        }
    }

    public void Player1DrawOne()
    {
        GameObject player1Card = Instantiate(cards[Random.Range(0, cards.Count)]);
        player1Card.transform.SetParent(player1Panel.transform, false);
    }

    public void Player2DrawOne()
    {
        GameObject player2Card = Instantiate(cards[Random.Range(0, cards.Count)]);
        player2Card.transform.SetParent(player2Panel.transform, false);
    }
}
