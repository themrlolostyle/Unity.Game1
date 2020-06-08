using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    [SerializeField] private Transform _ball;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        transform.position = new Vector3(_ball.position.x + _xOffset, transform.position.y, transform.position.z);
    }
}
