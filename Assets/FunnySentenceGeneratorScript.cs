using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentenceGeneratorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";
        int count = 0;

        while (count < 7)
        {
            int randomIndex = Random.Range(0, words.Length);
            sentence += words[randomIndex] + " ";
            count++;
        }

        Debug.Log(sentence.Trim());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
