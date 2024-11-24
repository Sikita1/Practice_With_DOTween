using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : CharacteristicsChanger
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Замена текста", GetDuration()));
        sequence.Append(_text.DOText("\n Добавление текста", GetDuration()).SetRelative());
        sequence.Append(_text.DOText("Взлом текста", GetDuration(), true, ScrambleMode.All));
        sequence.SetLoops(GetRepit(), GetLoopType());
    }
}
