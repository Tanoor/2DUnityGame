using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public Vector2 position;
        public GameObject[] platforms;
        private fallingPlatform fp;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                other.transform.position = position;
                foreach(GameObject platform in platforms) {
                    fp = platform.GetComponent<fallingPlatform>();
                    fp.Reset();
                }
            }
        }

        void Start() {
            platforms = GameObject.FindGameObjectsWithTag("trap");
        }
    }
}
