using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class YourScoreFinal : MonoBehaviour
{
    Text finalScore;
    private void Start()
    {
        finalScore = GetComponent<Text>();
    }
    void Update()
    {
        int AccessingS = ScoreScript.scoreValue;
        finalScore.text = "Final Score:" + AccessingS;

    }
}