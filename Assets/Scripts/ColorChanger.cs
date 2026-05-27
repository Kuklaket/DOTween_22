using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        _renderer.material.DOColor(_color, _duration)
        .SetDelay(_delay)
        .SetEase(Ease.Linear)
        .SetLoops(_repeats, _loopType);
    }
}
