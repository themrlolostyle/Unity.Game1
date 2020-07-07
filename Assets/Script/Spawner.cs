using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int _howManyCreate;
    [SerializeField] private int _howManySpawn;
    [SerializeField] private int _timeToSpawn;
    
    private void Start()
    {
        Initialize(prefab, _howManyCreate);
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeToSpawn);
            for (int i = 0; i < _howManySpawn; i++)
            {
                if (TryGetObject(out GameObject item))
                {
                    item.SetActive(true);
                    item.transform.position = new Vector3(transform.position.x + i, transform.position.y, transform.position.z);
                    DisableObjectAbroadScreen();
                }
            }
        }
    }
}
