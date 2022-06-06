using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    
    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
