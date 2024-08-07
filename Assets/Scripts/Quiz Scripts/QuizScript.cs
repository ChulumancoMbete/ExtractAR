using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizScript : MonoBehaviour
{
    //Question and answer variables
    public List<QuestionandAnswer> QnA;
    public GameObject[] Options;
    public int CurrentQuestion;
    public Text QuestionTxt;
    public int TotalQuestions = 0;
    private int questionsGenerated = 0;
    private List<int> askedQuestions = new List<int>();

    //Timer variables
    public Text CountdownTimertxt;
    public float TimeStart = 60;
    private bool TimeEnded = false;

    //Score UI variables 
    public int Score;
    public Text ScoreTxt;

    //UI Variables
    public GameObject OpeningUI;
    public GameObject QuizUI;
    public GameObject ScoreUI;

    //Audio variables
    public AudioClip CorrectAudio;
    public AudioClip IncorrectAudio;

    private void Start()
    {
        TotalQuestions = QnA.Count;
        GenerateQuestion();
        questionsGenerated = 0; //Reset counter
        askedQuestions.Clear(); //Reset list of questions asked
    }

    //Method to update the timer and user information every frame
    public void Update()
    {
        DisplayTime();
    }

    //Timer Method
    public void DisplayTime()
    {
        if (!TimeEnded)
        {
            float mins = Mathf.FloorToInt(TimeStart / 60);
            float sec = Mathf.FloorToInt(TimeStart % 60);
            CountdownTimertxt.text = string.Format("{0:00}:{1:00}", mins, sec);
            if (TimeStart >= 0)
            {
                TimeStart -= Time.deltaTime;
            }
            else
            {
                TimeEnded = true;
                QuizUI.SetActive(false);
                ScoreUI.SetActive(true);
                GameOver();
            }
        }
    }

    //Start button
    public void StartButton()
    {
        TotalQuestions = QnA.Count;

        OpeningUI.SetActive(false);
        QuizUI.SetActive(true);

        GenerateQuestion();
    }

    //Question Qenerator
    public void GenerateQuestion()
    {
        if (QnA.Count > 0 && questionsGenerated < 6)
        {
            do
            {
                CurrentQuestion = Random.Range(0, QnA.Count);
            }
            while (askedQuestions.Contains(CurrentQuestion));

            askedQuestions.Add(CurrentQuestion);

            QuestionTxt.text = QnA[CurrentQuestion].Question;
            SetAnswers();

            questionsGenerated++;
        }
        else
        {
            GameOver();
            askedQuestions.Clear();
        }
    }

    //Method to set the answers, which is linked to the answer script
    public void SetAnswers()
    {
        for (int i = 0; i < Options.Length; i++)
        {
            // Set answers to be false for when a new question shows
            Options[i].GetComponent<AnswerScript>().isCorrect = false;

            // To get the text from the selected answer
            Options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[CurrentQuestion].Answers[i];

            if (QnA[CurrentQuestion].CorrectAnswer == i + 1)
            {
                Options[i].GetComponent<AnswerScript>().isCorrect = true;
            }

            Options[i].GetComponent<Image>().color = Options[i].GetComponent<AnswerScript>().Start_Color;
        }
    }

    //when you answer correct
    public void Correct()
    {
        Score += 1;
        GetComponent<AudioSource>().clip = CorrectAudio;
        GetComponent<AudioSource>().Play();
        QnA.RemoveAt(CurrentQuestion);
        StartCoroutine(NextQuestion());
    }

    //when you answer wrong
    public void Wrong()
    {
        GetComponent<AudioSource>().clip = IncorrectAudio;
        GetComponent<AudioSource>().Play();
        QnA.RemoveAt(CurrentQuestion);
        StartCoroutine(NextQuestion());
    }

    //Method to allow the quiz to wait for 1 second once any answer button is pressed, and moves to the next question
    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(1);
        GenerateQuestion();
    }

    //GAME OVER METHOD
    public void GameOver()
    {
        ScoreTxt.text = Score + "/" + 6; //TotalQuestions;
        QuizUI.SetActive(false);
        ScoreUI.SetActive(true);
    }

    // Continue METHOD that loads the next set of questions
    public void ContinueQuiz()
    {
        OpeningUI.SetActive(false);
        QuizUI.SetActive(true);
        ScoreUI.SetActive(false);
        GenerateQuestion();
        questionsGenerated = 0; //Reset counter
        askedQuestions.Clear(); //Reset list of questions asked
    }

    //Exit Button
    public void Exit()
    {
        SceneManager.LoadScene("Dashboard");
    }
}
