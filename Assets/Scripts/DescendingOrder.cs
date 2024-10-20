using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Puedes introducir estos n�meros desde el inspector o desde un m�todo
    public float numero1;
    public float numero2;
    public float numero3;

    void Start()
    {
        VerificarOrdenDecreciente();
    }

    void VerificarOrdenDecreciente()
    {
        if (numero1 > numero2 && numero2 > numero3)
        {
            Debug.Log("Los n�meros est�n en orden decreciente.");
        }
        else
        {
            Debug.Log("Los n�meros NO est�n en orden decreciente.");
        }
    }
}
