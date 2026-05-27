using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationOffset;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType = LoopType.Incremental;

    private void Start()
    {
        transform.DORotate(_rotationOffset, _duration, RotateMode.LocalAxisAdd)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopType);
    }
}
