using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void START_THE_GAME()
    {
        Application.LoadLevel("level1");
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().isKinematic = false;
    }

    public void QUIT_THE_GAME()
    {
        Application.Quit();       
    }
}
