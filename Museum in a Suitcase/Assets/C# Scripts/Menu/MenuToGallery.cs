﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToGallery : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void FromMenuToGallery()
    {
        SceneManager.LoadScene("Gallery");
        //Goes from  Menu scene to Gallery scene
    }
}
