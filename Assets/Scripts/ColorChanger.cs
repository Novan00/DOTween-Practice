using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private float _speed = 3f;
    private Color _color = Color.red;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.DOColor(_color, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
