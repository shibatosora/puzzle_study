using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    float _time = 0.0f;
    float _inv_time_max = 1.0f;

    public void Set(float max_time)
    {
        Debug.Assert(0 < max_time);

        _time = max_time;
        _inv_time_max = 1.0f / (float)max_time;
    }
    public bool Update()
    {
        _time = Mathf.Max(--_time, 0);
            return (0<_time);
    }

    public float GetNormalized()
    {
        return _inv_time_max * (float)_time;
    }
}
