using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPool : MonoBehaviour
{
    private GameObject _gemPrefab;
    private GemTemplate _gemTemplate;
    private Queue<GameObject> _gems = new Queue<GameObject>();

    public GemPool(GameObject gemPrefab, GemTemplate template, int max)
    {
        _gemPrefab = gemPrefab;
        _gemTemplate = template;

        for(int i = 0; i < max; i++)
        {
            PutToPool(CreateNewGem());
        }
    }

    public GameObject TakeFromPool()
    {
        if(_gems.Count == 0)
        {
            _gems.Enqueue(CreateNewGem());
        }

        GameObject gem = _gems.Dequeue();
        gem.SetActive(true);
        return gem;
    }

    private GameObject CreateNewGem()
    {
        GameObject newGem = Instantiate(_gemPrefab);
        newGem.GetComponent<Gem>().SetParameters(_gemTemplate);
        newGem.SetActive(false);
        return newGem;
    }

    public void PutToPool(GameObject gem)
    {
        _gems.Enqueue(gem);
        gem.SetActive(false);
    }
}
