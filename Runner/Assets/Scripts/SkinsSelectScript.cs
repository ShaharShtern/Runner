using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsSelectScript : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //RED = 0 // BLUE = 1 // YELLOW = 2
    public void RedSkin()
    {
        PlayerPrefs.SetInt("Skins", 0);
    }
    public void BlueSkin()
    {
        //check if already purchased blue
        if (PlayerPrefs.GetInt("BoughtBlue") == 0)
        {
            //check if player has enough coins
            if (PlayerPrefs.GetInt("Coins") >= 1000)
            {
                //coin payment
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 1000);
                //change Skins to 1 (blue)
                PlayerPrefs.SetInt("Skins", 1);
                //mark blue as bought
                PlayerPrefs.SetInt("BoughtBlue", 1);
            }
        }
        //if already bought
        else if (PlayerPrefs.GetInt("BoughtBlue") == 1)
        {
            //change Skins to 2 (blue)
            PlayerPrefs.SetInt("Skins", 1);
        }

    }
    public void YellowSkin()
    {
        //check if already purchased yellow
        if (PlayerPrefs.GetInt("BoughtYellow") == 0)
        {
            //check if player has enough coins
            if (PlayerPrefs.GetInt("Coins") >= 5000)
            {
                //coin payment
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 5000);
                //change Skins to 2 (yellow)
                PlayerPrefs.SetInt("Skins", 2);
                //mark blue as bought
                PlayerPrefs.SetInt("BoughtYellow", 1);
            }
        }
        //if already bought
        else if (PlayerPrefs.GetInt("BoughtYellow") == 1)
        {
            //change Skins to 2 (yellow)
            PlayerPrefs.SetInt("Skins", 2);
        }
    }
}

