using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleStore : MonoBehaviour
{
    public GameObject shop;
    public void toggleShopOn()
    {
        shop.SetActive(true);
    }
    public void toggleShopOff()
    {
        shop.SetActive(false);
    }
}
