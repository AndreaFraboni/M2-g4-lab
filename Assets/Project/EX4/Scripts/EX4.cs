using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX4 : MonoBehaviour
{

    [SerializeField] private int startNumber, amount;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Numero di partenza = " + startNumber);

        for (int i = 1; i<=amount; i++)
        {
            Debug.Log(startNumber + i);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
