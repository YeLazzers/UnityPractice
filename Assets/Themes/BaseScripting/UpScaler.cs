using UnityEngine;

public class UpScaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0f;

    void Update()
    {
        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
