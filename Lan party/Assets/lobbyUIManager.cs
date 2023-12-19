using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lobbyUIManager : MonoBehaviour
{
    public Button joinGame;
    //public InputField playerName;
    void Start()
    {
        
    }

    void Awake()
    {
        joinGame.onClick.AddListener(()=>{
            SceneManager.LoadScene(0);
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
