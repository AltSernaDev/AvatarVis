using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Monumento : MonoBehaviour ,MouseClickInterface
{
    public Brain.EnumMonumentos monu;
    [SerializeField] private float rotationSpeed = 3f;
    [SerializeField] private string nombreDelMonu;
    
    

    public void Click()
    {
        Brain.brainCode.otherCamera.SetActive(true);
        Brain.brainCode.estadoActual = Brain.estados.zoom;
        Brain.brainCode.esteMonumento = monu;
        Brain.brainCode.MostrarMonumento(nombreDelMonu);
    }

    private void Update()
    {
        //transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }
}
