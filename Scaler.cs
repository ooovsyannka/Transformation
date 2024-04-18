using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleValue;
    [SerializeField] private float _speedResiz;

    private void Update()
    {
        Resiz();
    }

    private void Resiz()
    {
        float resizValue = Mathf.PingPong( _speedResiz*Time.time, _scaleValue);

        transform.localScale = Vector3.one * resizValue;
    }
}