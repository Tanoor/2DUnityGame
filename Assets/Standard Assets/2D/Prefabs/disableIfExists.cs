using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableIfExists : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Application.loadedLevelName == "level1" || Application.loadedLevelName == "level2") {
            Destroy(gameObject);
        }
    }
}
