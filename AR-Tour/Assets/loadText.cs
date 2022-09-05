using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class loadText : MonoBehaviour
{
    public TextAsset filename;                     
    Text text;
    void Start()
    { 
        text = GetComponent<Text>();
        if (filename)
        {
            text.text = filename.text;
        }
    }
}