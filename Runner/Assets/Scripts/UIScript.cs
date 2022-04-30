using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text scoreText;
    public Text coinsText;
    public MovementScript movementScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = movementScript.score.ToString();
        coinsText.text = PlayerPrefs.GetInt("Coins").ToString();
    }
}
