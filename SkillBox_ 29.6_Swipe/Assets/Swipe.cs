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
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.deltaPosition.x > 0)
            {
                Debug.Log("Right");
            }
            if(touch.deltaPosition.x < 0)
            {
                Debug.Log("Left");
            }
        }
    }
}
