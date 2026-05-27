using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _newText;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private float _delay = 2f;
    [SerializeField] private int _loops = -1;
    
    [SerializeField] private LoopType _loopType = LoopType.Restart;
    [SerializeField] private TextAnimationType _animationType;

    private enum TextAnimationType
    {
        Normal,
        Relative,
        Scrambled
    }

    private void Start()
    {
        Tween tween = null;

        switch (_animationType)
        {
            case TextAnimationType.Normal:
                tween = _text.DOText(_newText, _duration);
                break;
            case TextAnimationType.Relative:
                tween = _text.DOText(_newText, _duration).SetRelative();
                break;
            case TextAnimationType.Scrambled:
                tween = _text.DOText(_newText, _duration, true, ScrambleMode.All);
                break;
        }

        tween?.SetDelay(_delay).SetLoops(_loops, _loopType);
    }
}

