using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InformationToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void FromInformationToMenu()
    {
        SceneManager.LoadScene("Menu");
        //Goes from Gallery   scene to Menu scene
    }
}
