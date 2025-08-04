using UnityEngine;

public class AroundRotater : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 0f;

    void Update()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
