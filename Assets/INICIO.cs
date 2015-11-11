using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class INICIO : MonoBehaviour {
    public void Inicio(string level)
    {
        Application.LoadLevel("INICIO");
    }
    public void SHURE(string level)
    {
        Application.LoadLevel("SHURE");
    }

    public void AKG(string level)
    {
        Application.LoadLevel("AKG");
    }
    public void FREAKG(string level)
    {
        Application.LoadLevel("FREAKG");
    }
    public void FRESHURE(string level)
    {
        Application.LoadLevel("FRESHURE");
    }
    public void POLARSHURE(string level)
    {
        Application.LoadLevel("POLARSHURE");
    }
    public void POLARAKG(string level)
    {
        Application.LoadLevel("POLARAKG");
    }
}
