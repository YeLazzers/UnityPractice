using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    private Transform parentTransform;
    private float multiplyChance = 100f;

    private void Awake()
    {
        parentTransform = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Transform>();
    }

    public void Initialize(Vector3 parentScale, float parentMultiplyChance)
    {
        transform.localScale = parentScale / 2f;
        multiplyChance = parentMultiplyChance / 2f;
        GetComponent<Renderer>().material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }

    public void Destroy()
    {
        Debug.Log("Destroyed");

        int luck = Random.Range(0, 101);


        if (luck <= multiplyChance)
        {
            int childCount = Random.Range(2, 7);

            for (int i = 0; i < childCount; i++)
            {
                var newCube = Instantiate(_cubePrefab, parentTransform);
                newCube.GetComponent<CubeController>().Initialize(transform.localScale, multiplyChance);
            }
        }

        StartCoroutine(DelayedDestroy());
    }

    private IEnumerator DelayedDestroy()
    {
        yield return null;
        Destroy(gameObject);
    }
}
