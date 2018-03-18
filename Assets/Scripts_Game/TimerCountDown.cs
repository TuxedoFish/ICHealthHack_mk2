using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{
    
    private float timer = 30f;
    private Text timerSeconds;

    //init
    private void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    //Update
    private void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}