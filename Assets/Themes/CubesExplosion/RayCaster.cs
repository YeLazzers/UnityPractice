using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{


    private void Awake()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            CubeController cube;

            if (Physics.Raycast(ray, out raycastHit))
            {
                raycastHit.collider.gameObject.TryGetComponent<CubeController>(out cube);
                if (cube != null)
                {
                    Debug.Log("Clicked: " + raycastHit.collider.name);
                    cube.Destroy();
                }

            }
        }
    }
}
