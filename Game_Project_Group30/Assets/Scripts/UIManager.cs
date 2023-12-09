using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    
    public Bullets Bullets;
    public PlayerController PlayerController;
   
    public TMP_Text livesDisplay;


    // Update is called once per frame
    void Update()
    {

        
        livesDisplay.text = "Lives: " + PlayerController.lives;

    }

}
