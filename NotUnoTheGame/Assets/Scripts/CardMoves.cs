using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMoves : MonoBehaviour
{
    private bool isDrag = false;
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

    public void StartDrag()
    {
        startPos = transform.position;
        isDrag = true;
    }

    public void EndDrag()
    {
        isDrag = false;
    }
}
