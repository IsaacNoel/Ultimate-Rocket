using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool gameOn = true;
    void Update()
    {
        if (gameOn == true)
        {
            RocketMove();
        }
    }
    void RocketMove()
    {
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 position = new Vector2(mousePosition.x, mousePosition.y);
        transform.position = position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOn = false;

    }

}
