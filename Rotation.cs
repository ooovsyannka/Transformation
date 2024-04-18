using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _angel;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(_speedRotate * Time.deltaTime * Vector3.up * _angel);
    }
}