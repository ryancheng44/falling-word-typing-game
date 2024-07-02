using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList;

    string fileName = "WordList.txt";

    private void Start()
    {
        string filePath = Application.dataPath + "/" + fileName;

        wordList = File.ReadAllLines(filePath);
    }

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
