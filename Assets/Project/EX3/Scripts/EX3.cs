using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    [SerializeField] private int numero = 30;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= numero; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");   // multiplo di 3 e di 5            
            }else if (i % 3 == 0)
            {
                Debug.Log("Fizz");  // multiplo di 3
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");  // multiplo di 5
            }
            else
            {
                Debug.Log(numero); // non è multiplo ne di 3 ne di 5 !!!!
            }      
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
