using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    public string firstName;
    public string secondName;



    [TextArea(3, 10)]
    public string[] firstSentences;

    [TextArea(3, 10)]
    public string[] secondSentences;


}
