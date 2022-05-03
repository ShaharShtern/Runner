using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Skins")==0)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (PlayerPrefs.GetInt("Skins") == 1)
        {
            player.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (PlayerPrefs.GetInt("Skins") ==2)
        {
            player.GetComponent<Renderer>().material.color = Color.yellow;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //reset coins and skins
        if (Input.GetKeyDown("p"))
        {
            PlayerPrefs.SetInt("Coins", 0);
            PlayerPrefs.SetFloat("Skins", 0);
            PlayerPrefs.SetInt("BoughtYellow", 0);
            PlayerPrefs.SetInt("BoughtBlue", 0);
        }
        //return to start screen
        if (Input.GetKey("b"))
        {
            SceneManager.LoadScene(0);
        }
        //infinite money :)
        if (Input.GetKey("m"))
        {
            PlayerPrefs.SetInt("Coins", 100000);
        }
    }
}
