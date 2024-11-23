using UnityEngine;
using DG.Tweening;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 _target;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(_target, _duration)
                 .SetLoops(-1, LoopType.Restart)
                 .SetEase(Ease.Linear);
    }
}
