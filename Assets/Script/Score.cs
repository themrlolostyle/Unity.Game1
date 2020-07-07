using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private BallWallet _ball;
    [SerializeField] private TMP_Text _coinCountText;

    private void OnEnable()
    {
        _ball.ScoreChanged += OnScoreChanging;
    }

    private void OnDisable()
    {
        _ball.ScoreChanged -= OnScoreChanging;
    }

    private void OnScoreChanging(int score)
    {
        _coinCountText.text = score.ToString();
    }
}
