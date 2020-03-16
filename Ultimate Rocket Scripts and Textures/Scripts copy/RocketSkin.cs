using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RocketSkin : MonoBehaviour
{
    int coins;
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
    }

    public void SetDefault()
    {
        PlayerPrefs.SetInt("RocketSkin", 0);
    }

    public void SetOrange()
    {
        if(PlayerPrefs.GetInt("Orange", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 1);
        }
        else if(coins >= 500)
        {
            PlayerPrefs.SetInt("Coins", coins - 500);
            PlayerPrefs.SetInt("Orange", 1);
        }
    }
    public void SetRow()
    {
        if (PlayerPrefs.GetInt("Row", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 2);
        }
        else if (coins >= 1500)
        {
            PlayerPrefs.SetInt("Coins", coins - 1500);
            PlayerPrefs.SetInt("Row", 1);
        }
    }
    public void SetCarrot()
    {
        if (PlayerPrefs.GetInt("Carrot", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 3);
        }
        else if (coins >= 1000)
        {
            PlayerPrefs.SetInt("Coins", coins - 100);
            PlayerPrefs.SetInt("Carrot", 1);
        }
    }
    public void SetCloud()
    {
        if (PlayerPrefs.GetInt("Cloud", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 4);
        }
        else if (coins >= 1000)
        {
            PlayerPrefs.SetInt("Coins", coins - 1000);
            PlayerPrefs.SetInt("Cloud", 1);
        }
    }
    public void SetGold()
    {
        if (PlayerPrefs.GetInt("Highscore", 0) >= 1000)
        {
  
            PlayerPrefs.SetInt("RocketSkin", 5);
        }
    }
    public void SetDark()
    {
        if (PlayerPrefs.GetInt("Highscore", 0) >= 500)
        {
            PlayerPrefs.SetInt("RocketSkin", 6);
        }
    }
    public void SetVoid()
    {
        if (PlayerPrefs.GetInt("Void", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 7);
        }
        else if (coins >= 750)
        {
            PlayerPrefs.SetInt("Coins", coins - 750);
            PlayerPrefs.SetInt("Void", 1);
        }
    }
    public void SetColo()
    {
        if (PlayerPrefs.GetInt("Colo", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 8);
        }
        else if (coins >= 1000)
        {
            PlayerPrefs.SetInt("Coins", coins - 1000);
            PlayerPrefs.SetInt("Colo", 1);
        }
    }
    public void SetRetro()
    {
        if (PlayerPrefs.GetInt("Retro", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 9);
        }
        else if (coins >= 500)
        {
            PlayerPrefs.SetInt("Coins", coins - 500);
            PlayerPrefs.SetInt("Retro", 1);
        }
    }
    public void SetTrident()
    {
        if (PlayerPrefs.GetInt("Trident", 0) == 1)
        {
            PlayerPrefs.SetInt("RocketSkin", 10);
        }
        else if (coins >= 500)
        {
            PlayerPrefs.SetInt("Coins", coins - 500);
            PlayerPrefs.SetInt("Trident", 1);
        }
    }
}
