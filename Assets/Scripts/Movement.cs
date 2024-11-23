using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMoveZ(-1f, _duration)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
    }
}
