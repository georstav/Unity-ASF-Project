using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenToMenu : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("Flyer_3D_Models");
        //Goes from Splash Screen to the first scene which is the Flyer_3D_Models

    }

}

