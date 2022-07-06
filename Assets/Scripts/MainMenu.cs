using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    void Start() {
        audio = GetComponent<AudioSource>();

        if (!alreadyPlayed) {
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
    }

    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PlayAgain(){
        SceneManager.LoadScene(0);
    }
}
