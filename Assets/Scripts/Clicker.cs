using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Clicker : MonoBehaviour
{
    public int clicks = 0;
    


    private void OnMouseDown()
    {
        clicks++;
        UiManager.instance.UpdateClicks(clicks);
        transform.DOScale(1.2f, 0.5f).SetLoops(2, LoopType.Yoyo);
    }
}
