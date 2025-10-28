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
        int[] randomArray = new int[arraySize]; // dichiaro array

        for (int i = 0; i < arraySize; i++) // ciclo x riempire array e verifica caccia al numero
        {
            int randomNumber = Random.Range(numberToFind - numberOffset, numberToFind + numberOffset);
            randomArray[i] = randomNumber;

            if (randomNumber == numberToFind)
            {
                Debug.Log("Number FOUND !!!");
            }
            else
            {
                Debug.Log("Number Not Found !!!!");
            }
        }
        Debug.Log("Iteractions Finished !!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
