using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTo3D_Models : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void FromMenuTo3D_Models()
    {
        SceneManager.LoadScene("3D_Models_Manual");
        //Goes from  Menu scene to 3D_Models_Manual scene
    }
}
