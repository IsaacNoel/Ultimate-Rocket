using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerRocketSkin : MonoBehaviour
{
    public GameObject rocket;
    public GameObject standIn;
    public GameObject menu;
    public Sprite defaultskin;
    public Sprite orange;
    public Sprite colo;
    public Sprite row;
    public Sprite carrot;
    public Sprite voidskin;
    public Sprite gold;
    public Sprite dark;
    public Sprite retro;
    public Sprite trident;
    public Sprite cloud;
    public TextMeshProUGUI defaultskin1;
    public TextMeshProUGUI orange1;
    public TextMeshProUGUI colo1;
    public TextMeshProUGUI row1;
    public TextMeshProUGUI carrot1;
    public TextMeshProUGUI voidskin1;
    public TextMeshProUGUI gold1;
    public TextMeshProUGUI dark1;
    public TextMeshProUGUI retro1;
    public TextMeshProUGUI trident1;
    public TextMeshProUGUI cloud1;
    SpriteRenderer image;
    Image menuImage;
    int skinSelect;
    void Start()
    {
        image = rocket.GetComponent<SpriteRenderer>();
        menuImage = standIn.GetComponent<Image>();
        skinSelect = PlayerPrefs.GetInt("RocketSkin", 0);
        if (skinSelect == 0)
        {
            image.sprite = defaultskin;
            menuImage.sprite = defaultskin;
        }
        else if (skinSelect < 5)
        {
            if (skinSelect == 1)
            {
                image.sprite = row;
                menuImage.sprite = row;
            }
            if (skinSelect == 2)
            {
                image.sprite = orange;
                menuImage.sprite = orange;
            }
            if (skinSelect == 3)
            {
                image.sprite = carrot;
                menuImage.sprite = carrot;
            }
            if (skinSelect == 4)
            {
                image.sprite = cloud;
                menuImage.sprite = cloud;
            }
        }
        else if (skinSelect >= 5)
        {
            if (skinSelect == 5)
            {
                image.sprite = gold;
                menuImage.sprite = gold;
            }
            if (skinSelect == 6)
            {
                image.sprite = dark;
                menuImage.sprite = dark;
            }
            if (skinSelect == 7)
            {
                image.sprite = voidskin;
                menuImage.sprite = voidskin;
            }
            if (skinSelect == 8)
            {
                image.sprite = colo;
                menuImage.sprite = colo;
            }
            if (skinSelect == 9)
            {
                image.sprite = retro;
                menuImage.sprite = retro;
            }
            if (skinSelect == 10)
            {
                image.sprite = trident;
                menuImage.sprite = trident;
            }
        }
    }
    private void Update()
    {
        Start();
    }
    private void Awake()
    {
        if (PlayerPrefs.GetInt("Orange", 0) == 1)
        {
            if (PlayerPrefs.GetInt("Trident", 0) == 1)
            {
                trident1.text = "Select";
            }
            if (PlayerPrefs.GetInt("Cloud", 0) == 1)
            {
                cloud1.text = "Select";
            }
            if (PlayerPrefs.GetInt("Colo", 0) == 1)
            {
                colo1.text = "Select";
            }
            if (PlayerPrefs.GetInt("Carrot", 0) == 1)
            {
                carrot1.text = "Select";
            }
            if (PlayerPrefs.GetInt("Gold", 0) == 1)
            {
                gold1.text = "Select";
            }
            if (PlayerPrefs.GetInt("Dark", 0) == 1)
            {
                dark1.text = "Select";
            }
            if (PlayerPrefs.GetInt("Row", 0) == 1)
            {
                row1.text = "Select";
            }
            if (PlayerPrefs.GetInt("Void", 0) == 1)
            {
                voidskin1.text = "Select";
            }
        }
    }
}
        