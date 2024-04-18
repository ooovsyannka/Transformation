using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _distance;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime * _distance);
    }
}
