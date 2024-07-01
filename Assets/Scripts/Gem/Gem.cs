using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private Sprite _sprite;
    private GemType _type;

    public Gem(GemTemplate template)
    {
        SetParameters(template);
    }

    public void SetParameters(GemTemplate template)
    {
        _sprite = template.GetSprite();
        _type = template.GetType();
    }

    public GemType GetGemType()
    {
        return _type;
    }
}
