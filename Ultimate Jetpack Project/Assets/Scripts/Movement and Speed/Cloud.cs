using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y < Camera.main.transform.position.y - 7f)
        {
            Destroy(gameObject);
        }
    }
}
