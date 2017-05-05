using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameStateBehaviour : MonoBehaviour
{
    public AudioSource GameAudio;
    public AudioClip pauseClip;
    public AudioClip unpauseClip;    
    public Button unpauseButton;
    public Button restartButton;

    private void Start()
    {
        GameAudio = GetComponent<AudioSource>();
    }
    public void Pause()
    {
        unpauseButton.gameObject.SetActive(true);
        GameAudio.clip = pauseClip;
        GameAudio.Play();
        Time.timeScale = 0f;
    }

    public void UnPause()
    {
        unpauseButton.gameObject.SetActive(false);
        GameAudio.clip = unpauseClip;
        GameAudio.Play();
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        restartButton.gameObject.SetActive(true);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}
