using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{

    void Start()
    {
        
    }
    void Update()
    {
        //reset game
        if (Input.GetKeyDown("r"))
        {
            ResetGame();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //death
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //disable movement script
            GetComponent<MovementScript>().enabled = false;
            //stop player in place
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //check what enemy collided with for playtesting
            print(collision.gameObject);
            //death sound
            collision.gameObject.GetComponent<AudioSource>().Play();
            //reset scene
            Invoke("ResetGame", 2f);
        }
    }
    void ResetGame()
    {
        //reloard current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + FindObjectOfType<MovementScript>().score/10);

    }
    
}
