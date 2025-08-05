using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
