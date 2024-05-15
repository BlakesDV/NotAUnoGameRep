using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrawer : MonoBehaviour
{
    public GameObject cardFront;
    public GameObject cardBack;
    public GameObject player1Panel;
    public GameObject player2Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1OnClick()
    {
        GameObject player1Card = Instantiate(cardFront);
        player1Card.transform.SetParent(player1Panel.transform, false);

        // Opcional: Ajustar la posición local dentro del panel si es necesario
        //playerCard.transform.localPosition = Vector3.zero;
    }
    public void Player2OnClick()
    {
        GameObject player2Card = Instantiate(cardFront);
        player2Card.transform.SetParent(player2Panel.transform, false);

        // Opcional: Ajustar la posición local dentro del panel si es necesario
        //playerCard.transform.localPosition = Vector3.zero;
    }
}
