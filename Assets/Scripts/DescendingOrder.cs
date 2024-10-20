using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Puedes introducir estos números desde el inspector o desde un método
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
            Debug.Log("Los números están en orden decreciente.");
        }
        else
        {
            Debug.Log("Los números NO están en orden decreciente.");
        }
    }
}
