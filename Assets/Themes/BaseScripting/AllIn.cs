using UnityEngine;

public class AllIn : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;
    void Update()
    {
        float speedDelta = _speed * Time.deltaTime;
        transform.Translate(Vector3.forward * speedDelta * 10f);
        transform.Rotate(Vector3.up, 360 * speedDelta);

        transform.localScale += new Vector3(speedDelta, speedDelta, speedDelta);
    }
}
