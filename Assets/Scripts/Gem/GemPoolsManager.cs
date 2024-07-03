using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPoolsManager : MonoBehaviour
{
    private Dictionary<int, GemPool> pools = new Dictionary<int, GemPool>();

    public static GemPoolsManager Instance;

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

    public GameObject TakeFromPool(GemType type)
    {
        var gem = pools[(int)type].TakeFromPool();
        gem.SetActive(true);
        return gem;
    }

    public void InitPools(int max, GameObject gemPrefab, List<GemTemplate> templates)
    {
        foreach (GemTemplate template in templates)
            pools[(int)template.GetGemType()] = new GemPool(gemPrefab, template, max);
    }
}
