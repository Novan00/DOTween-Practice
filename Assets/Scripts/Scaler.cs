using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    private Vector3 _targetScale = new Vector3(3, 3, 1);
    private float _speed = 3f;

    void Start()
    {
        transform.DOScale(_targetScale, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
