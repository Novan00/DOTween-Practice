using DG.Tweening;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    private float _speed = 3f;

    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 360), _speed, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1);
    }
}
