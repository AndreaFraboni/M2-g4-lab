using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciclo : MonoBehaviour
{
    [SerializeField] private int index;
    [SerializeField] private int num;
    
    // Start is called before the first frame update
    void Start()
    {
        while (index>0)
        {
            num++;

            Debug.Log("Valore variabile num = " + num);

            index--;
        }
        Debug.Log("Cycle finished !!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
