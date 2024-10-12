using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public Text bestText;
    public GameObject playButton;
    public GameObject gameOver;
    public AudioSource audioSource;  
    public AudioClip audioClip1;     

    private int score;
    private int best;
    private int bestScore;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        playButton.SetActive(false);
        gameOver.SetActive(false);

        
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestText.text = bestScore.ToString();
    }

    public void Play()
    {
        score = 0;
        best = bestScore;
        scoreText.text = score.ToString();
        bestText.text = best.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
        audioSource.Stop();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();

        if (score >= 0 && score < 10)
        {
            PlayAudio1();
        }

        BestScore();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    // Method to play audioClip1
    private void PlayAudio1()
    {
        if (audioSource != null && audioClip1 != null)
        {
            audioSource.clip = audioClip1;
            audioSource.Play();
        }
    }

    public void BestScore()
    {
        if (score > bestScore)
        {
            bestScore = score;

            PlayerPrefs.SetInt("BestScore", bestScore);
            PlayerPrefs.Save(); 

            bestText.text = bestScore.ToString();
        }
        best = bestScore;
    }
}
