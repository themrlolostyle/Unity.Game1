using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{
    public override IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeToSpawn);
            if (TryGetObject(out GameObject item))
            {
                item.SetActive(true);
                item.transform.position = transform.position;

                DisableObjectAbroadScreen();
            }
        }
    }
}
