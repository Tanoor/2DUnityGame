using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public bool showGUI = false;
    public GameObject canvas; 

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showGUI = !showGUI;
        }

        if (showGUI) {
            canvas.SetActive(true);
            Time.timeScale = 0;
        } else {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        canvas = GameObject.Find("Canvas");
    }
}
