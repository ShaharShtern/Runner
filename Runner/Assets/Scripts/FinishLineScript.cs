using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLineScript : MonoBehaviour
{
    public GameObject winCanvas;
    private void OnCollisionEnter(Collision collision)
    {
        
            //disable movement script
            collision.gameObject.GetComponent<MovementScript>().enabled = false;
            //stop player in place
            collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //play win sound
            GetComponent<AudioSource>().Play();
            //win screen
            winCanvas.SetActive(true);
            //next level
            Invoke("NextLevel", 2f);
        
    }
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
