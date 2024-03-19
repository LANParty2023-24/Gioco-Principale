using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;
// using UnityEngine. SceneManager;

public class Linker : MonoBehaviour
{
    public GameObject but;
    // Start is called before the first frame update
    public void Cambia()
    {
        SceneManager.LoadScene("SampleScene");
    }
}