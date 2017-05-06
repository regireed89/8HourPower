using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Dialogue/dialogue")]
public class Dialogue : ScriptableObject
{
    public string[] Lines;
    public int index = 0;
    public string currentLine;
    public int LENGTH;
    public void Init(Dialogue d)
    {
        Lines = d.Lines;
        index = d.index;
        currentLine = d.Lines[index];
        LENGTH = d.Lines.Length;
    }

    public bool Talk()
    {
        var nextline = index + 1;
        if(nextline >= Lines.Length)
            return false;
        index = nextline;
        currentLine = Lines[index];
        return true;
    }                                                                
    
}
