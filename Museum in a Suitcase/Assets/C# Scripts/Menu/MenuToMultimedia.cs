using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuToMultimedia : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FromMenuToMultimedia()
    {
        SceneManager.LoadScene("Multimedia");
        //Goes from  Menu scene to Multimedia scene
    }
}
