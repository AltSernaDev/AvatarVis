using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    void Update()
    {
        if (Brain.brainCode.estadoActual == Brain.estados.navegando)
        {
            Selecting();
        }
    }
    void Selecting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                var selectable = hit.transform;
                MouseClickInterface selectableCode = selectable.gameObject.GetComponent<MouseClickInterface>();
                if (selectableCode != null)
                {
                    selectableCode.Click();
                }
            }
        }
    }
}
