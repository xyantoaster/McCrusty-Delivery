using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    // Update is called once per frame
    public void StartH2P()
    {
        SceneManager.LoadScene("HowToPlay1");
    }

    // Next Scene Logic
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(SceneManager.GetActiveScene().name == "HowToPlay1")
            {
                SceneManager.LoadScene("HowToPlay2");
            }
            else if(SceneManager.GetActiveScene().name == "HowToPlay2")
            {
                SceneManager.LoadScene("HowToPlay3");
            }
            else if(SceneManager.GetActiveScene().name == "HowToPlay3")
            {
                SceneManager.LoadScene("HowToPlay4");
            }
            else if(SceneManager.GetActiveScene().name == "HowToPlay4")
            {
                SceneManager.LoadScene("HowToPlay5");
            }
            else if (SceneManager.GetActiveScene().name == "HowToPlay5")
            {
                SceneManager.LoadScene("HowToPlay6");
            }
            else if(SceneManager.GetActiveScene().name == "HowToPlay6")
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
