using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Brain : MonoBehaviour
{
    public static Brain brainCode;
    public bool onCanvasDisplayed;
    public GameObject canvasObj;
    public epocas epocaOn;
    public region regionActiva;
    public estados estadoActual;
    [SerializeField] private GameObject mapaRoku;
    [SerializeField] private GameObject mapaAang;
    [SerializeField] private GameObject mapaKorra;
    public GameObject botonesEpocas;
    [SerializeField] private GameObject[] gastro, arte;
    [SerializeField] private GameObject paneles;
    [SerializeField] private TextMeshProUGUI avatarNombre;
    [SerializeField] private GameObject esquinaCanv;
    [SerializeField] public AudioSource ambienteAudSource, musicaRegionAudSource;
    [SerializeField] private AudioClip[] regionMusic;

    [SerializeField] private GameObject[] OBJSmonumentos;
    public GameObject otherCamera;
    public EnumMonumentos esteMonumento;
    [SerializeField] private TextMeshProUGUI nombreMonumento;
    [SerializeField] private GameObject uiMonus;
    
    public enum EnumMonumentos
    {
        Omashu,
        PrisionRocaHirviente,
        Abadia,
        Drill,
        TemploDeCuracion,
        Naufragio,
        TemploDeFuego,
        IslaTemploAire,
        PalacioReal,
        IslaDeRoku,
        TemploAireEste,
        TribuAguaRoku
    }

    public void MostrarMonumento(string nombreEsto)
    {
        switch (esteMonumento)
        {
            case EnumMonumentos.Omashu:
                OBJSmonumentos[0].SetActive(true);
                break;
            case EnumMonumentos.PrisionRocaHirviente:
                OBJSmonumentos[1].SetActive(true);
                break;
            case EnumMonumentos.Abadia:
                OBJSmonumentos[2].SetActive(true);
                break;
            case EnumMonumentos.Drill:
                OBJSmonumentos[3].SetActive(true);
                break;
            case  EnumMonumentos.TemploDeCuracion:
                OBJSmonumentos[4].SetActive(true);
                break;
            case EnumMonumentos.Naufragio:
                OBJSmonumentos[5].SetActive(true);
                break;
            case EnumMonumentos.TemploDeFuego:
                OBJSmonumentos[6].SetActive(true);
                break;
            case EnumMonumentos.IslaTemploAire:
                OBJSmonumentos[7].SetActive(true);
                break;
            case EnumMonumentos.PalacioReal:
                OBJSmonumentos[8].SetActive(true);
                break;
            case EnumMonumentos.IslaDeRoku:
                OBJSmonumentos[9].SetActive(true);
                break;
            case EnumMonumentos.TemploAireEste:
                OBJSmonumentos[10].SetActive(true);
                break;
            case EnumMonumentos.TribuAguaRoku:
                OBJSmonumentos[11].SetActive(true);
                break;
        }

        nombreMonumento.text = nombreEsto;
        uiMonus.SetActive(true);
        botonesEpocas.SetActive(false);
    }

    public void apagarMonumentosEstado()
    {
        foreach (GameObject monusObj in OBJSmonumentos)
        {
            monusObj.SetActive(false);
        }
        
        otherCamera.SetActive(false);
        estadoActual = estados.navegando;
        uiMonus.SetActive(false);
        botonesEpocas.SetActive(true);
    }
    
    public void CerrarGastro()
    {
        foreach (GameObject gastroIndividual in gastro)
        {
            gastroIndividual.SetActive(false);
        }
        paneles.SetActive(false);
        esquinaCanv.SetActive(true);
    }

    public void PonerMusicaRegion()
    {
        switch (regionActiva)
        {
            case region.agua:
                musicaRegionAudSource.clip = regionMusic[0];
                musicaRegionAudSource.Play();
                ambienteAudSource.Pause();
                break;
            case region.aire:
                musicaRegionAudSource.clip = regionMusic[1];
                musicaRegionAudSource.Play();
                ambienteAudSource.Pause();
                break;
            case region.fuego:
                musicaRegionAudSource.clip = regionMusic[2];
                musicaRegionAudSource.Play();
                ambienteAudSource.Pause();
                break;
            case region.tierra:
                musicaRegionAudSource.clip = regionMusic[3];
                musicaRegionAudSource.Play();
                ambienteAudSource.Pause();
                break;
            case region.republica:
                musicaRegionAudSource.clip = regionMusic[4];
                musicaRegionAudSource.Play();
                ambienteAudSource.Pause();
                break;
        }
    }

    public void AbrirGastro()
    {
        switch (regionActiva)
        {
            case region.agua:
                gastro[0].SetActive(true);
                break;
            case region.aire:
                gastro[1].SetActive(true);
                break;
            case region.fuego:
                gastro[2].SetActive(true);
                break;
            case region.tierra:
                gastro[3].SetActive(true);
                break;
        }
        paneles.SetActive(true);
        esquinaCanv.SetActive(false);
    }
    
    public void CerrarArtes()
    {
        foreach (GameObject arteIndividual in arte)
        {
            arteIndividual.SetActive(false);
        }
        esquinaCanv.SetActive(true);
    }

    public void AbrirArte()
    {
        switch (regionActiva)
        {
            case region.agua:
                arte[0].SetActive(true);
                break;
            case region.aire:
                arte[1].SetActive(true);
                break;
            case region.fuego:
                arte[2].SetActive(true);
                break;
            case region.tierra:
                arte[3].SetActive(true);
                break;
            default:
                Debug.Log("jaja");
                break;
        }
        esquinaCanv.SetActive(false);
    }

    private void Awake()
    {
        brainCode = this;
    }

    private void Update()
    {
        switch (estadoActual)
        {
            case estados.navegando:
                
                break;
            
            case estados.zoom:
                
                /*if (onCanvasDisplayed && Input.GetKeyDown(KeyCode.Escape))
                {
                    canvasObj.SetActive(false);
                    onCanvasDisplayed = false;
                    estadoActual = estados.navegando;
                    botonesEpocas.SetActive(true);
                }*/
                break;
        }
        
    }

    public void cerrarInfo()
    {
        canvasObj.SetActive(false);
        onCanvasDisplayed = false;
        estadoActual = estados.navegando;
        botonesEpocas.SetActive(true);
        ambienteAudSource.UnPause();
        musicaRegionAudSource.Stop();
    }
    
    public enum estados
    {
        navegando,
        zoom
    }

    public enum region
    {
        agua,
        fuego,
        aire,
        tierra,
        ninguna,
        republica
    }
    
    public enum epocas
    {
        Roku,
        Aang,
        Korra
    }

    public void CambiarEpoca(int thisEpoca)
    {
        switch (thisEpoca)
        {
            case 0:
                mapaRoku.SetActive(true);
                mapaAang.SetActive(false);
                mapaKorra.SetActive(false);
                epocaOn = epocas.Roku;
                avatarNombre.text = "Roku";
                
                // Quizas cambiar monumentos
                break;
            case 1:
                mapaRoku.SetActive(false);
                mapaAang.SetActive(true);
                mapaKorra.SetActive(false);
                epocaOn = epocas.Aang;
                avatarNombre.text = "Aang";
                    
                // Quizas cambiar monumentos;
                break;
            case 2:
                mapaRoku.SetActive(false);
                mapaAang.SetActive(false);
                mapaKorra.SetActive(true);
                epocaOn = epocas.Korra;
                avatarNombre.text = "Korra";
                
                // Quizas cambiar monumentos
                break;
        }
    }
}
