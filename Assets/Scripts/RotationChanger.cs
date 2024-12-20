using UnityEngine;
using DG.Tweening;

public class RotationChanger : CharacteristicsChanger
{
    [SerializeField] private Vector3 _target;

    private void Start()
    {
        transform.DORotate(_target, GetDuration())
                 .SetLoops(GetRepit(), GetLoopType())
                 .SetEase(GetEase());
    }
}
