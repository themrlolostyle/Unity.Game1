using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : ObjectPool
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int _howMuch;

    [SerializeField] protected int _timeToSpawn;


    private void Start()
    {
        Initialize(prefab, _howMuch);
        StartCoroutine(Spawn());
    }

    public abstract IEnumerator Spawn();
}
