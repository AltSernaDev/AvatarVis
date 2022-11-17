using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class AguaSurCode : MonoBehaviour, MouseClickInterface
{
    private RecursosRegiones recursos;
    [SerializeField] private Brain.region estaRegion;
    [SerializeField] private GameObject panelCanvas;
    [SerializeField] private TextMeshProUGUI nombreText;
    [SerializeField] private TextMeshProUGUI DescrpText;
    [SerializeField] private GameObject botonesInfo;

    private void Start()
    {
        recursos = gameObject.GetComponent<RecursosRegiones>();
    }

    public void Click()
    {
        Brain.brainCode.estadoActual = Brain.estados.zoom;
        Brain.brainCode.onCanvasDisplayed = true;
        Brain.brainCode.botonesEpocas.SetActive(false);
        Brain.brainCode.regionActiva = estaRegion;
        Brain.brainCode.PonerMusicaRegion();
        // mover camara
        // poner musica
        

        nombreText.text = recursos.nombre;
        DescrpText.text = recursos.descripcion;
        //mover la camara
        
        setOnCanvas();
        if (Brain.brainCode.regionActiva == Brain.region.ninguna || Brain.brainCode.regionActiva == Brain.region.republica)
        {
            botonesInfo.SetActive(false);
        }
        else
        {
            botonesInfo.SetActive(true);
        }
    }

    private void setOnCanvas()
    {
        panelCanvas.SetActive(true);
    }
}
