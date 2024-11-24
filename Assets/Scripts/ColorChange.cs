using UnityEngine;
using DG.Tweening;

public class ColorChange : DataChange
{
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Color _targetColor;

    private void Start()
    {
        _renderer.material.DOColor(_targetColor, GetDuration())
                          .SetLoops(GetRepit(), GetLoopType())
                          .SetEase(GetEase());
    }
}
