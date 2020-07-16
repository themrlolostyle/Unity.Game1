using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour
{
    private Camera _camera;

    private List<GameObject> _pool = new List<GameObject>();

    protected void Initialize(GameObject prefab, int count)
    {
        _camera = Camera.main;

        for (int i = 0; i < count; i++)
        {
            GameObject spawned = Instantiate(prefab);
            spawned.SetActive(false);

            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(p => p.activeSelf == false);

        return result != null;
    }

    public void DisableObjectAbroadScreen()
    {
        float deadLinePosX = _camera.ScreenToWorldPoint(new Vector3(0, 0, -(_camera.transform.position.z))).x;

        foreach (var item in _pool)
        {
            if (item.transform.position.x < deadLinePosX)
            {
                item.SetActive(false);
            }
        }
    }
}
