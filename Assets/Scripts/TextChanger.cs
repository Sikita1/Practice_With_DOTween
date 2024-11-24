using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : CharacteristicsChanger
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������ ������", GetDuration()));
        sequence.Append(_text.DOText("\n ���������� ������", GetDuration()).SetRelative());
        sequence.Append(_text.DOText("����� ������", GetDuration(), true, ScrambleMode.All));
        sequence.SetLoops(GetRepit(), GetLoopType());
    }
}
