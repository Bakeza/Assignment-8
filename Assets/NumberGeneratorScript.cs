using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGeneratorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int randomNumber = Random.Range(1, 21);

            if (randomNumber == 5)
            {
                continue;
            }

            Debug.Log(randomNumber);

            if (randomNumber == 15)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
