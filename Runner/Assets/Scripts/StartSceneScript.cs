using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneScript : MonoBehaviour
{
    public GameObject levelSelect;
    public GameObject skinSelect;
    public Text coinsText;

    private void Update()
    {
        coinsText.text = PlayerPrefs.GetInt("Coins").ToString();
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene(3);
    }
    public void LevelSelect()
    {
        if (levelSelect.activeSelf)
            levelSelect.SetActive(false);
        else
            levelSelect.SetActive(true);
    }
    public void SkinSelect()
    {
        if (skinSelect.activeSelf)
            skinSelect.SetActive(false);
        else
            skinSelect.SetActive(true);
    }
}
