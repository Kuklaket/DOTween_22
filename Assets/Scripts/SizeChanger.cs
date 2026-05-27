using DG.Tweening;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleOffset;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DOScale(_scaleOffset, _duration)
            .SetRelative()
            .SetEase(Ease.InOutSine)
            .SetLoops(_repeats, _loopType);
    }
}
