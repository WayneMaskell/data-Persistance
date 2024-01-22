using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UiControl : MonoBehaviour
{
    public InputField inputText;
    public string username;
    public string saveName;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void SaveName() 
    {
       saveName = inputText.text;
        PlayerPrefs.SetString( "name" ,saveName);

        
        
        
    }
}
