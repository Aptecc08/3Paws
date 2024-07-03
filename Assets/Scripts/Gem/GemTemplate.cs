using UnityEngine;

[CreateAssetMenu]
public class GemTemplate : ScriptableObject
{
    [SerializeField] private GemType _type;
    [SerializeField] private Sprite _sprite;

    public Sprite GetSprite()
    {
        return _sprite;
    }

    public GemType GetGemType()
    {
        return _type;
    }
}
