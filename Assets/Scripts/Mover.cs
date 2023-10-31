using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetToMove;

    private float _speed = 3f;

    private void Start()
    {
        transform.DOMove(_targetToMove, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
