using System.Collections;
using UnityEngine;

public class MouseCounter : MonoBehaviour
{
    private WaitForSeconds _delay = new WaitForSeconds(0.5f);
    private Coroutine coroutine;
    private int _count = 0;
    private bool _isRunning = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isRunning)
            {

                StopCoroutine(coroutine);
                _isRunning = false;
            }
            else
            {
                coroutine = StartCoroutine(CountCoroutine());
                _isRunning = true;
            }
            Debug.Log("MouseClick. Running: " + _isRunning);
        }
    }

    private IEnumerator CountCoroutine()
    {
        while (true)
        {
            yield return _delay;
            _count += 1;
            Debug.Log("Current: " + _count);
        }
    }
}
