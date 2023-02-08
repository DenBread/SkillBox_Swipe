using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    readonly float _scale = 3.5f;
    public float accum;

    private void Update()
    {
        AnimetionScale();
    }

    private void AnimetionScale()
    {
        accum += 1.1f * Time.deltaTime;
        transform.localScale = Vector3.Lerp(Vector2.zero, new Vector3(_scale, _scale, _scale), Mathf.SmoothStep(0, 1, accum));
    }
}
