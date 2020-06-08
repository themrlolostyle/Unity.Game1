using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public event UnityAction<int> ScoreChanger;

    private int _score;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Coin>(out Coin coin))
        {
            _score++;
            ScoreChanger?.Invoke(_score);
            coin.gameObject.SetActive(false);
        }
    }
}
