
using UnityEngine;
using UnityEngine.UI;
public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogueConfig;
    public Dialogue dialogue;
    public Text ui_text;
    private void Start()
    {
        dialogue = Instantiate(dialogueConfig);
        dialogue.Init(dialogueConfig);        
        ui_text.text = dialogue.currentLine;
    }
    public void Execute()
    {
        if(!dialogue.Talk())        
            return;   
        
            
        ui_text.text = dialogue.currentLine;
    }

    public void Revert()
    {
        dialogue.index = 0;
    }
}
