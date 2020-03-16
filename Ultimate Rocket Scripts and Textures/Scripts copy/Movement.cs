using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Analytics;

public class Movement : MonoBehaviour
{
    [SerializeField] float scoreTime;
    public GameObject canvas;
    public GameObject scoreZ;
    public bool gameOn = true;
    public int score;
    public int coin;
    public int coinCount;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI overText;
    public TextMeshProUGUI highText;
    public TextMeshProUGUI coinText;

    void Start()
    {
        InvokeRepeating("ScoreUp", scoreTime, scoreTime);
    }
    public void ScoreUp()
    {
        if (gameOn == true)
        {
            ++score;
            scoreText.text = score.ToString();     
        }
    }
    public void Update()
    {
        if (gameOn == true)
        {
            RocketMove();   
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameOn == true)
        {
            ++coin;
        }
    }
    void RocketMove()
    {
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 position = new Vector2(mousePosition.x, mousePosition.y);
        transform.position = position;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        gameOn = false;
        canvas.SetActive(true);
        scoreZ.SetActive(false);
        highText.text = "HighScore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        overText.text = "Score: " + score.ToString();

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
        if (PlayerPrefs.GetInt("DoubleCoin", 0) == 1)
        {
            coin = 2 * coin;
            string coinString = coin.ToString();
            string coinText1 = "Coins: " + coinString + "!";
            coinText.text = coinText1;
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) + coin);
            PlayerPrefs.SetInt("DoubleCoin", 0);
        }
        else
        {
            coinText.text = "Coins: " + coin.ToString();
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins", 0) + coin);
        }
    }
}
