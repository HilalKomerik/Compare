using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CirclesManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] circleArray;

    void Start()
    {
        CircleScaleClose();
    }
    
    public void CircleScaleClose()
    {
        foreach (GameObject circle in circleArray)
        {
            circle.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }

    public void CircleScaleOpen(int whichCircle)
    {
        circleArray[whichCircle].GetComponent<RectTransform>().DOScale(1, 0.3f);

        if (whichCircle % 5 == 0) 
        {
            CircleScaleClose();
        }
    }
}
