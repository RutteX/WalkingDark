using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;

    public Animator animator;

    private Queue<string> sentences;
   
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        animator.SetBool("isOne", true);
        if (dialog.name != null) {nameText.text = dialog.name;}

        sentences.Clear();

        foreach(string sentence in dialog.sentences) 
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0) 
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
    }

    public void EndDialog()
    {
        animator.SetBool("isOne", false);
    }
}
