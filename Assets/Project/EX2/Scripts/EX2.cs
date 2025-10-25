using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    private int[] arraynumeri = new int[4]; // inziazlizzo l'array di 4 numeri

    int sommadeinumeri = 0;                 // inizializzo la sommanumeri a 0
    int moltiplicazionedeinumeri = 1;       // inizializzo la moltiplicazionedeinumeri a 1 perchè se uso 0 avrei sempre 0 come risultato della moltiplicazione indipendentemente dai valori nell'array

    // Start is called before the first frame update
    void Start()
    {
        // Input
        // carico i valori nell'array :
        arraynumeri[0] = 1;
        arraynumeri[1] = 2;
        arraynumeri[2] = 4;
        arraynumeri[3] = 5;

        for (int i = 0; i<arraynumeri.Length; i++)
        {
            int elemento;
            elemento = arraynumeri[i];

            Debug.Log("elemento letto dall'array = " + elemento);

            sommadeinumeri += elemento;

            moltiplicazionedeinumeri = moltiplicazionedeinumeri * elemento;

        }

        //Output
        Debug.Log("Somma di tutti i numeri = " + sommadeinumeri);
        Debug.Log("Moltiplicazione di tutti i numeri = " + moltiplicazionedeinumeri);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
