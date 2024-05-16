using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMoves : MonoBehaviour
{
    //code recovered from tutotial by M.S. Farzan

    private GameManager gameManager;

    private bool isDrag = false;
    private bool inDropPanel = false;
    private GameObject dropPanel;
    private Vector2 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDrag) {
            transform.position =  new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inDropPanel = true;
        dropPanel = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        inDropPanel = false;
        dropPanel = null;
    }

    public void StartDrag()
    {
        startPos = transform.position;
        isDrag = true;
    }

    public void EndDrag()
    {
        if (isDrag)
        {
            isDrag = false;
            if (inDropPanel)
            {
                transform.SetParent(dropPanel.transform, false);
                gameManager.EndTurn();
            }
            else
            {
                transform.position = startPos;
            }
        }
    }
}
