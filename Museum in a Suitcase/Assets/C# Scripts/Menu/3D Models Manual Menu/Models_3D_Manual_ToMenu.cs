using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Models_3D_Manual_ToMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void From3DManualToMenu()
    {
        Debug.Log("Hello from the script From 3D MODELS TO MENU");
        SceneManager.LoadScene("Menu");
        //Goes from 3D Models Manual   scene to Menu scene
       
    }

}
