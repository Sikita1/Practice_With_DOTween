using UnityEngine;
using DG.Tweening;

public class ScaleChanger : CharacteristicsChanger
{
    [SerializeField] private Vector3 _target;

    private void Start()
    {
        transform.DOScale(_target, GetDuration())
                 .SetLoops(GetRepit(), GetLoopType())
                 .SetEase(GetEase());
    }
}
