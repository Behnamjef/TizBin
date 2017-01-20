using Script;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class StartPanel : MonoBehaviour
    {
        public Button easyButton, mediumButton, hardButton, startButton;

        public GameController gameController;

        private void OnEnable()
        {
            easyButton.onClick.AddListener(() => SetDifficulty(Questions.LevelDifficulty.Easy));
            mediumButton.onClick.AddListener(() => SetDifficulty(Questions.LevelDifficulty.Medium));
            hardButton.onClick.AddListener(() => SetDifficulty(Questions.LevelDifficulty.Hard));
        }


        private void SetDifficulty(Questions.LevelDifficulty levelDifficulty)
        {
            gameController._levelDifficulty = levelDifficulty;

            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("ShowStartButton");

            startButton.onClick.AddListener(StartButton);
        }

        private void StartButton()
        {
            gameController.CreateQuestion();
            gameController.startTimer = true;

            Destroy(gameObject);
        }
    }
}
