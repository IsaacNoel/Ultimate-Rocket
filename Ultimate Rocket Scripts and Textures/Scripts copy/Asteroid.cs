using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject Coin;
    public float speedf;

    public void Start()
    {
        speedf = GameObject.FindGameObjectWithTag("GameController").GetComponent<Speed>().speed / 2f;
        float coinSpawn = 2f / speedf;
        InvokeRepeating("SpawnCoin", 0f, coinSpawn);
    }
    private void SpawnCoin()
    {
        Instantiate(Coin, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
    }

    void Update()
    {
        
        if (gameObject.transform.position.y < Camera.main.transform.position.y - 7f)
        {
            Destroy(gameObject);
        }
        else
        {
            Vector2 down = new Vector2(transform.position.x, transform.position.y - speedf * Time.deltaTime);
            transform.position = down;
        }
    }
}
