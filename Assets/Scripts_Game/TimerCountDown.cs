using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{
    
    public float timer = 30f;
    private Text timerSeconds;
    public int loadLevel;
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
            SceneManager.LoadScene(loadLevel);
        }
    }
}