using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundaries : MonoBehaviour {
            string currentScene;
    void Start()
        {
            currentScene = SceneManager.GetActiveScene().name;
        }

    private void OnCollisionEnter2D(Collision2D col)
    {

        
        if (col.gameObject.CompareTag("Floor"))
        {
            SceneManager.LoadScene(currentScene);
        }

        
    } 
}
