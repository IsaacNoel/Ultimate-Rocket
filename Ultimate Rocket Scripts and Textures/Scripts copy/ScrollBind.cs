using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBind : MonoBehaviour
{
    public GameObject anchor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < 0.1f * Screen.height)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 10);
        }
        if (anchor.transform.position.y > 0.5f * Screen.height)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 10);
        }

    }
}
