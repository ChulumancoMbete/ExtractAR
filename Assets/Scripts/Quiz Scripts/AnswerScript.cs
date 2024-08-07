using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizScript Quiz;
    public Color Start_Color;

    

    private void Start()
    {
        Start_Color = GetComponent<Image>().color;
    }

    //Method to allow the return of the original colour in 1 second once any answer button is pressed, and moves to the next question
    IEnumerator ReturnButtonColor()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Image>().color = Start_Color;
    }

    //Method to tell what happens when the answer chosen is wrong or right
    public void Answer()
    {
        if (isCorrect)
        {
            Quiz.Correct();
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer!");
            StartCoroutine(ReturnButtonColor());
        }
        else
        {
            Quiz.Wrong();
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer!");
            StartCoroutine(ReturnButtonColor());
        }
    }
}
