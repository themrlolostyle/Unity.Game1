using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallWallet : MonoBehaviour
{
    public event UnityAction<int> ScoreChanged;

    private int _score;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Coin>(out Coin coin))
        {
            _score++;
            ScoreChanged?.Invoke(_score);
            coin.PickUp();
        }
    }
}
