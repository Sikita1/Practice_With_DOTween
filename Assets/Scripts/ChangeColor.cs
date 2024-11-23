using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;

    private void Start()
    {
        _renderer.material.DOColor(_targetColor, _duration)
                          .SetLoops(-1, LoopType.Yoyo)
                          .SetEase(Ease.Linear);
    }
}
