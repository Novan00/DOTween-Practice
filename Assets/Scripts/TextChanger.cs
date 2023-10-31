using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private string _repalceText = "Ну здарова!";
    private string _additionText = "Это я!";
    private string _hackedText = "Я вызломал этот текст";
    private float _speed = 2f;
    private float _delay = 2f;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_repalceText, _speed).SetDelay(_delay));
        sequence.Append(_text.DOText(_additionText, _speed).SetRelative());
        sequence.Append(_text.DOText(_hackedText, _speed, true, ScrambleMode.All));

        sequence.SetLoops(-1);
    }
}
