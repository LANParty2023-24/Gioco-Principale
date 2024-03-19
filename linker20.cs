using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;
// using UnityEngine. SceneManager;


// bool i = True;

public class Linker20 : MonoBehaviour
{
    public GameObject butt;
    // Start is called before the first frame update
    public void Change()
    {
        //if(i == True){

            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
            Debug.Log("sium");
        //}
        
    }
}