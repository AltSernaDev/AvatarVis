using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GastroYArtesCtrl : MonoBehaviour
{
    [SerializeField] private GameObject[] gastro, arte;
    [SerializeField] private GameObject paneles;

    public void CerrarGastro()
    {
        foreach (GameObject gastroIndividual in gastro)
        {
            gastroIndividual.SetActive(false);
        }
        paneles.SetActive(false);
    }

    public void AbrirGastro(int thisGastro)
    {
        paneles.SetActive(true);
        gastro[thisGastro].SetActive(true);
    }
    
    public void CerrarArtes()
    {
        foreach (GameObject arteIndividual in arte)
        {
            arteIndividual.SetActive(false);
        }
    }

    public void AbrirArte(int thisArte)
    {
        arte[thisArte].SetActive(true);
    }
}
