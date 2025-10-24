using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.VisualScripting;
using UnityEngine;

public class EX1_bis : MonoBehaviour
{
    [SerializeField] private int numa;
    [SerializeField] private int numb;
    [SerializeField] private int numc;

    int valorealto;

    // Start is called before the first frame update
    void Start()
    {

        if (numa > numb)
        {
            if (numa > numc)
            {
                Debug.Log("Il numero più alto è numa = " + numa);
            }
            else
            {
                Debug.Log("Il numero più alto è numc = " + numc);
            }
        }
        else
        {
            if (numb > numc)
            {
                Debug.Log("Il numero più alto è numb = " + numb);
            }
            else
            {
                Debug.Log("Il numero più alto è numc = " + numc);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
