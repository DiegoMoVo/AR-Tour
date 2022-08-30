using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class readTextfile : MonoBehaviour
{
    [SerializeField] TextAsset file;
    //where to place the text
    public Transform contentWindow;
    public GameObject recallTextObject;
    // Start is called before the first frame update
    void Start()
    {
      string readFromFile = file.text;
      List<string> fileLines = File.ReadAllLines(readFromFile).ToList();

      foreach (string line in fileLines)
      {
        Instantiate(recallTextObject, contentWindow);
        recallTextObject.GetComponent<Text>().text = line;
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
