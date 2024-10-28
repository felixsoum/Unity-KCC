using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        float x = 2f * Mathf.Sin(Time.time);
        lineRenderer.SetPosition(0, new Vector3(x, 0, 0));
    }
}
