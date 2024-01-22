using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public string nameOfPlayer;
    public Text playerName;
    
    // Start is called before the first frame update
    void Start()
    {
        SetPlayerName();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName() 
    {
        nameOfPlayer = PlayerPrefs.GetString("name" , "none");
        playerName.text = nameOfPlayer;
    }
}
