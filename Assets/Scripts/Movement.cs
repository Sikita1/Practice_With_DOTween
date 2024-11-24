using UnityEngine;
using DG.Tweening;

public class Movement : DataChange
{
    private void Start()
    {
        transform.DOMoveZ(-1f, GetDuration())
                 .SetLoops(GetRepit(), GetLoopType())
                 .SetEase(GetEase());
    }
}
