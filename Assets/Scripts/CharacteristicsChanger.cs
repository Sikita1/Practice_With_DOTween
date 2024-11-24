using UnityEngine;
using DG.Tweening;

public class CharacteristicsChanger : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    
    private float _duration = 2f;
    private int _repit = -1;
    private Ease _ease = Ease.Linear;

    public float GetDuration() =>
        _duration;

    public int GetRepit() =>
        _repit;

    public LoopType GetLoopType() =>
        _loopType;

    public Ease GetEase() =>
        _ease;
 }
