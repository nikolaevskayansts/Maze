using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandText : MonoBehaviour
{
    TextMeshPro txt;
    public List<string> sentences = new List<string>();
    float timeLeft;
    string sentenceChose;
    RectTransform rtText;
    public GameObject text;
    


    private void Start()
    {
        timeLeft = Random.Range(3, 10);

        GetComponent<TextMeshPro>().fontSize = Random.Range(9, 25);
        sentenceChose = sentences[Random.Range(0, sentences.Count)];
        txt = gameObject.GetComponent<TextMeshPro>();
        txt.text = sentenceChose;
        
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            GetComponent<TextMeshPro>().fontSize = Random.Range(8, 20);

            sentenceChose = sentences[Random.Range(0, sentences.Count)];
            txt = gameObject.GetComponent<TextMeshPro>();
            txt.text = sentenceChose;

            timeLeft = Random.Range(3, 10);
        }

        
    }
}