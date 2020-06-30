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
        foreach (var item in _pool.Where(item => item.activeSelf == true && _camera.WorldToViewportPoint(item.transform.position).x < 0))
        {
            item.SetActive(false);
        }
    }
}
