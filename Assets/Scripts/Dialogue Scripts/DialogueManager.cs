using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text firstNameText;
    public Text firstDialogueText;
    public Text secondNameText;
    public Text secondDialogueText;
    public Animator firstAnimator;
    public Animator secondAnimator;
    public Queue <string> firstSentences;
    public Queue <string> secondSentences;
    public GameObject shopUi;
    public GameObject firstdialogueBox;
    public GameObject seconddialogueBox;
    private bool first;
    private bool second;
    PlayerMovement movement;

    private void Start()
    {
        firstSentences = new Queue<string>();
        secondSentences = new Queue<string>();
        movement = FindObjectOfType<PlayerMovement>();
        first =  true;
        second = false;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        secondAnimator.SetBool("IsOpen", true);

        firstNameText.text = dialogue.firstName;
        secondNameText.text = dialogue.secondName;

        firstSentences.Clear();

        foreach(string sentence in dialogue.firstSentences)
        {
            firstSentences.Enqueue(sentence);
        }

        foreach (string sentence in dialogue.secondSentences)
        {
            secondSentences.Enqueue(sentence);
        }


        StartCoroutine(DisplayNextSentence());
    }

    private IEnumerator DisplayNextSentence()
    {
        yield return new WaitForSeconds(2);

        if (first == true)
        {
            firstAnimator.SetBool("isOpen", true);

            string sentence = firstSentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(FirstTypeSentence(sentence)); 
        }

        if(second == true)
        {
          string sentence = secondSentences.Dequeue();
          StopAllCoroutines();
          StartCoroutine(SecondTypeSentence(sentence));
        }
        
    }

    IEnumerator FirstTypeSentence (string sentence)
    {
        firstDialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            firstDialogueText.text += letter;
            yield return null;
        }

        first = false;
        second = true;

        if (firstSentences.Count == 0)
        {
            secondAnimator.SetBool("IsOpen", false);
            EndFirstDialogue();
        }

        else
        {
            StartCoroutine(DisplayNextSentence());
        }
    }

    IEnumerator SecondTypeSentence(string sentence)
    {
        secondDialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            secondDialogueText.text += letter;
            yield return null;
        }

        first = true;
        second = false;

        if (secondSentences.Count == 0)
        {
            firstAnimator.SetBool("isOpen", false);
            EndSecondDialogue();
        }

        else
        {
            StartCoroutine(DisplayNextSentence());
        }
    }

    void EndFirstDialogue()
    {
        firstAnimator.SetBool("isOpen", false) ;
        shopUi.SetActive(true);
    }

    void EndSecondDialogue()
    {
        secondAnimator.SetBool("IsOpen", false);
    }

}
