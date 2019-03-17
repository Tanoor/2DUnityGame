using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int coins = 0;
    public GUISkin LabelSkin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI() 
    {
        GUI.skin = LabelSkin;
        GUI.color = Color.white;
        GUI.Label(new Rect(10, 5, 300, 50), "Score : "+coins);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
