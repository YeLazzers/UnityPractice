using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.OnCountChanged += LogCount;
    }

    private void OnDisable()
    {
        _counter.OnCountChanged -= LogCount;
    }

    private void LogCount(int count)
    {
        Debug.Log("Count: " + count);
    }
}
