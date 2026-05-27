using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DOMove(transform.position + _offset, _duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(_repeats, _loopType);
    }
}
