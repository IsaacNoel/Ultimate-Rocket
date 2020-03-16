using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuText : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI coin;
    int highscore;
    int coinCount;
    
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        score.text = "HighScore: " + highscore.ToString();
        
    }
    public void Update()
    {
        coinCount = PlayerPrefs.GetInt("Coins", 0);
        coin.text = "Coins: " + coinCount.ToString();
    }
}
