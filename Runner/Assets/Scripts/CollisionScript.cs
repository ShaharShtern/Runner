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
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //disable movement script
            GetComponent<MovementScript>().enabled = false;
            //stop player in place
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //reset scene
            Invoke("ResetGame", 2f);
        }
    }
    void ResetGame()
    {
        //reloard current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
