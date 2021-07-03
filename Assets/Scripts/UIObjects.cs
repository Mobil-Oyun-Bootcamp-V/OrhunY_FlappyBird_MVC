using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIObjects : MonoBehaviour
{
    public bool isSwing;

    private void Start()
    {
        if (isSwing)
        {
            Swing();
        }
    }

    public void ONCLick()
    {
        transform.DOScale(transform.localScale - Vector3.one * 1.2f , 1).SetEase(Ease.Linear).Rewind(true);
    }

    public void Swing()
    {
        float yPos = transform.position.y;
        transform.DOMoveY(yPos + 50f, 1, false).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    public void Animated()
    {
        throw new System.NotImplementedException();
    }
}
