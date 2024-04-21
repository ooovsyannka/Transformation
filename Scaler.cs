using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleValue;
    [SerializeField] private float _speedResiz;

    private void Update()
    {
        Resize();
    }

    private void Resize()
    {
        transform.localScale += Vector3.one * _speedResiz * _scaleValue * Time.deltaTime ;
    }
}