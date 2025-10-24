using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1_ter : MonoBehaviour
{
    [SerializeField] private int numxtab;

    // Start is called before the first frame update
    void Start()
    {
        int n = 0;

        while (n<10)
        {
            int valore = (n + 1) * numxtab;
            Debug.Log(valore);

            n++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
