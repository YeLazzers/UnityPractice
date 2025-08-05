using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(InputReader))]
public class Counter : MonoBehaviour
{
    public UnityAction<int> OnCountChanged;

    private WaitForSeconds _delay = new WaitForSeconds(0.5f);
    private Coroutine _coroutine;
    private int _count = 0;
    private InputReader _inputReader;

    private void Awake()
    {
        _inputReader = GetComponent<InputReader>();
    }

    private void OnEnable()
    {
        _inputReader.OnPressed += ToggleCoroutine;
    }

    private void OnDisable()
    {
        _inputReader.OnPressed -= ToggleCoroutine;
    }

    private void ToggleCoroutine()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
        else
        {
            _coroutine = StartCoroutine(CountCoroutine());
        }
        Debug.Log($"MouseClick. Running: {_coroutine != null}");
    }

    private IEnumerator CountCoroutine()
    {
        while (enabled)
        {
            yield return _delay;
            _count += 1;
            OnCountChanged?.Invoke(_count);
        }
    }
}
