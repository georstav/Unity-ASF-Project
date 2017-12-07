using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromMultimediaToMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MultimediaToMenu()
    {
        SceneManager.LoadScene("Menu");
        //Goes from Multimedia scene to Menu scene
    }
}
