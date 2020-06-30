using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, 0, _speed * Time.deltaTime);
    }

    public void PickUp()
    {
        gameObject.SetActive(false);
    }
}
