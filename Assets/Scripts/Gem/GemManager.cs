using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemManager : MonoBehaviour
{
    private int[] _gemTypes;

    public static GemManager Instance;

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(Instance);
    }

    public void SetGemTypes(int[] types)
    {
        _gemTypes = types;
    }

    public void GetTypeForGenerateGem()
    {
        
    }
}
