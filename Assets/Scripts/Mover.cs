using UnityEngine;
using DG.Tweening;

public class Mover : CharacteristicsChanger
{
    [SerializeField] private float _targetPosition;

    private void Start()
    {
        transform.DOMoveZ(_targetPosition, GetDuration())
                 .SetLoops(GetRepit(), GetLoopType())
                 .SetEase(GetEase());
    }
}
