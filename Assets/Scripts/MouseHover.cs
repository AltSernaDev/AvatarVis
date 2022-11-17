using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    private Material Mat;
    [SerializeField] private Material otherMat;
    [SerializeField] private GameObject region;
    private bool hovered;

    void Start()
    {
        Mat = region.GetComponent<MeshRenderer>().material;
    }

    private void OnMouseEnter()
    {
        if(Brain.brainCode.onCanvasDisplayed)
            return;
        //region.transform.localScale *= 1.1f;
        //transform.localScale *= 1.1f;
        Mat.color += otherMat.color;
        hovered = true;
    }

    private void OnMouseExit()
    {
        if(Brain.brainCode.onCanvasDisplayed)
            return;
        //region.transform.localScale /= 1.1f;
        //transform.localScale /= 1.1f;
        Mat.color -= otherMat.color;
        hovered = false;
    }

    private void Update()
    {
        if (hovered)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                //region.transform.localScale /= 1.1f;
                //transform.localScale /= 1.1f;
                Mat.color -= otherMat.color;
                hovered = false;
            }
        }
    }
}
