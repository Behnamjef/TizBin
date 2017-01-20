using UnityEngine;

namespace Script
{
    public class Questions : MonoBehaviour
    {
        public GameObject[] questionPanel;
        public GameObject rightAnswerImg, wrongAnswerImg;

        public GameController GC;
        public enum LevelDifficulty
        {
            Easy = 0,
            Medium = 1,
            Hard = 2
        }

        public LevelDifficulty levelDifficulty;
        

        void Start () {
            Invoke ("AskQuestion", 5);
        }

        void AskQuestion()
        {
            questionPanel[(int)levelDifficulty].SetActive(true);
        }

        public void TrueAnswer()
        {
            questionPanel[(int)levelDifficulty].SetActive(false);
            rightAnswerImg.SetActive(true);
            GC.trueAnswers++;
            Invoke("CreateNextQuestion", 2);
        }

        public void WrongAnswer()
        {
            questionPanel[(int)levelDifficulty].SetActive(false);
            wrongAnswerImg.SetActive(true);
            Invoke("CreateNextQuestion", 2);
        }
        void CreateNextQuestion()
        {
            GC.CreateQuestion();
            Destroy(gameObject);
        }
    }
}
