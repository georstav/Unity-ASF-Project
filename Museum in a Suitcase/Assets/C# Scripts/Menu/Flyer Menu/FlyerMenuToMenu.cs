using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlyerMenuToMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToMenu()
    {
        Debug.Log("Hello from the script 3D MODELS to MENU");
        SceneManager.LoadScene("Menu");
        //Goes from  Flyer_3D_Models scene to Menu scene
    }
}