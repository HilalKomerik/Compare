using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TrueFalseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject trueIcon, falseIcon;
    void Start()
    {
        ScaleValueClose();
    }

    public void TrueFalseScaleOpen(bool rightOrWrong)
    {
        if (rightOrWrong)
        {
            trueIcon.GetComponent<RectTransform>().DOScale(1, 0.2f);
            falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
        else
        {
            falseIcon.GetComponent<RectTransform>().DOScale(1, 0.2f);
            trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        Invoke("ScaleValueClose",0.4f);

    }

    void ScaleValueClose()
    {
        trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
}
