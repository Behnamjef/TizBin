using System;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class EndPanel : MonoBehaviour
    {
        public Text point;
        public GameController GC;
        private void Start()
        {
            point.text = GC.trueAnswers + "#:#Swnj#jHk•U\n" + Math.Round(GC.timer,2) + "#:#·I¶p";
        }
    }
}
