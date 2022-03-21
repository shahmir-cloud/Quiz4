using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void HowGame()
    {
        image.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void backGame()
    {
        image.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
