using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;
// using UnityEngine. SceneManager;

public class Linker20 : MonoBehaviour
{
    public GameObject butt;
    // Start is called before the first frame update
    public void Change()
    {
        SceneManager.LoadScene("AVANTI");
    }
}