using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.name == "Player")
        {
            finishSound.Play();
            CompleteLevel();
        }
    }


    private void CompleteLevel()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }
}
