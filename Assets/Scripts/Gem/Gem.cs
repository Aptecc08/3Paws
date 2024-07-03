using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private SpriteRenderer _spriteRender;
    private GemType _type;

    public void SetParameters(GemTemplate template)
    {
        _spriteRender = GetComponent<SpriteRenderer>();
        _spriteRender.sprite = template.GetSprite();
        _type = template.GetGemType();
    }

    public GemType GetGemType()
    {
        return _type;
    }
}
