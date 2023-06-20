using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private BasketHit score;
    public TextMeshProUGUI scoreText;


    void Update()
    {
        scoreText.text = "Score: " + score.counter;
    }
}
