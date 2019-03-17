using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MAIN_MENU()
    {
        Application.LoadLevel("mainMenu");
        Destroy(GameObject.FindGameObjectWithTag("Player"));
    }

    public void QUIT_THE_GAME()
    {
        Application.Quit();       
    }
}
