using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCounter : MonoBehaviour
{
    WaitForSeconds yieldDelay = new WaitForSeconds(0.5f);

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Counter());
    }
    private IEnumerator Counter()
    {
        int count = 0;
        Debug.Log("Current: " + count);

        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                count += 1;
                Debug.Log("Current: " + count);
            }
            yield return yieldDelay;
        }
    }
}
