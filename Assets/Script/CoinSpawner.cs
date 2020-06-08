using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : Spawner
{
    public override IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeToSpawn);
            for (int i = 0; i < 5; i++)
            {
                if (TryGetObject(out GameObject item))
                {
                    item.SetActive(true);
                    item.transform.position = new Vector3(transform.position.x + i, transform.position.y, transform.position.z);
                    item.transform.rotation = Quaternion.Euler(90, 0, 0);
                    DisableObjectAbroadScreen();
                }
            }
        }
    }
}
