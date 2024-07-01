using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPoolsManager : MonoBehaviour
{
    public static GemPoolsManager Instance;
    public Dictionary<int, GemPool> pools;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(Instance);
    }

    public void PutToPool(Gem gem)
    {
        pools[(int)gem.GetGemType()].PutToPool(gem.gameObject);
    } 
}
