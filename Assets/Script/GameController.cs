using System.Collections.Generic;
using Assets.Script;
using UnityEngine;

namespace Script
{
    public class GameController : MonoBehaviour
    {
        public List<GameObject> levels;
        public GameObject endPanel;
        public Questions.LevelDifficulty _levelDifficulty;
        private int _counter;
        public int trueAnswers;
        public float timer;
        public bool startTimer;
        private void Update()
        {
            if (startTimer)
                timer += Time.deltaTime;
        }

        public GameObject GetQuestion()
        {
            var s = Random.Range(0, levels.Count);
            var levelToInstantiat = levels[s];
            levels.RemoveAt(s);
            return levelToInstantiat;
        }

        public void CreateQuestion()
        {
            var nextLevel = GetQuestion();
            if (_counter == 5)
            {
                var ep = Instantiate(endPanel).GetComponent<EndPanel>();
                ep.GC = this;
                startTimer = false;
            }
            else
            {
                var question = Instantiate(nextLevel).GetComponent<Questions>();
                question.levelDifficulty = _levelDifficulty;
                question.GC = this;
            }

            _counter++;
        }
    }
}
