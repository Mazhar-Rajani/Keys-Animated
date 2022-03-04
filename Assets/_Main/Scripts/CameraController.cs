using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float animTime = default;
    [SerializeField] private float pos = default;
    [SerializeField] private Ease ease = default;

    private void Start()
    {
        transform.DOMoveX(pos, animTime).SetEase(ease).SetLoops(-1, LoopType.Yoyo);
    }
}