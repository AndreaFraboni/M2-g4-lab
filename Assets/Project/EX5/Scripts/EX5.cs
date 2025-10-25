using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX5 : MonoBehaviour
{
    [SerializeField] private int numberToFind;
    [SerializeField] private int arraySize;

    [SerializeField] private int numberOffset;


    // Start is called before the first frame update
    void Start()
    {
        int[] randomArray = new int[arraySize];

        for (int i = 0; i<arraySize; i++)
        {
            int randomNumber = Random.Range(numberToFind-numberOffset, numberToFind+numberOffset);
            randomArray[i] = randomNumber;

            if (randomNumber==numberToFind)
            {
                Debug.Log("Number FOUUND !!!");
            }
            else
            {
                Debug.Log("Number Not Found !!!!");
            }
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
