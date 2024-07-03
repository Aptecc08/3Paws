using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemManager : MonoBehaviour
{
    [SerializeField] private int _maxGemPool;
    [SerializeField] private int poolsAmount;
    [SerializeField] private GameObject _gemPrefab;
    [SerializeField] private List<GemTemplate> _gemTemplates;
    [SerializeField] private List<GemType> _gemTypes;
    
    public static GemManager Instance;

    //ТОЛЬКО ДЛЯ ДЕБАГА, ПОТОМ ПЕРЕДЛАТЬ
    public List<Slot> Slots;

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(Instance);
    }

    private void Start()
    {
        InitPools();
        foreach (Slot slot in Slots)
            SetGemToSlot(slot);
    }

    private List<GemTemplate> CreateListOfTemplate()
    {
        List<GemTemplate> listOfTemplate = new List<GemTemplate>(); 
        foreach(GemType type in _gemTypes)
        {
            for (int i = 0; i < _gemTemplates.Count; i++)
            {
                if (_gemTemplates[i].GetGemType() == type)
                {
                    listOfTemplate.Add(_gemTemplates[i]);
                    break;
                }
            }
        }
        poolsAmount = listOfTemplate.Count;
        return listOfTemplate;
    }

    public void SetGemTypes(List<GemType> types)
    {
        _gemTypes = types;
    }

    public void InitPools()
    {
        GemPoolsManager.Instance.InitPools(_maxGemPool, _gemPrefab, CreateListOfTemplate());
    }

    public void SetGemToSlot(Slot slot)
    {
        //тут будет вызов аналитики для подбора камня, пока что просто рандомный
        var temp = Random.Range(0, poolsAmount);
        var type = _gemTypes[temp];
        var gemGO = GemPoolsManager.Instance.TakeFromPool(type);
        slot.SetGem(gemGO);
    }
}
