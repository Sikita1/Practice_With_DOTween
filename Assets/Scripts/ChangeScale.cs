using UnityEngine;
using DG.Tweening;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private Vector3 _target;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_target, _duration)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
    }
}
