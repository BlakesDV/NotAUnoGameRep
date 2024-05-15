using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrawer : MonoBehaviour
{
    public GameObject blueCards;
    public GameObject redCards;
    public GameObject yellowCards;
    public GameObject greenCards;
    public GameObject player1Panel;
    public GameObject player2Panel;
    List<GameObject> cards = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cards.Add(blueCards);
        cards.Add(redCards);
        cards.Add(yellowCards);
        cards.Add(greenCards);
    }

    public void StartingDraw()
    {
        for (var i = 0; i <  7; i++) {
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

        // Opcional: Ajustar la posición local dentro del panel si es necesario
        //playerCard.transform.localPosition = Vector3.zero;
    }
    public void Player2DrawOne()
    {
        GameObject player2Card = Instantiate(cards[Random.Range(0, cards.Count)]);
        player2Card.transform.SetParent(player2Panel.transform, false);

        // Opcional: Ajustar la posición local dentro del panel si es necesario
        //playerCard.transform.localPosition = Vector3.zero;
    }
}
