using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector2 _startTouchPosition;
    private Vector2 _endTouchPosition;




    void Update()
    {
        Swiping();
    }

    private void Swiping()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            _endTouchPosition = Input.GetTouch(0).position;

            if (_endTouchPosition.x < _startTouchPosition.x)
            {
                NextPage();
            }
            if (_endTouchPosition.x > _startTouchPosition.x)
            {
                PrivousPage();
            }
        }
    }

    private void PrivousPage()
    {
        Debug.Log("Left page");
    }

    private void NextPage()
    {
        Debug.Log("Right page");
    }
}
