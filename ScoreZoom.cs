using System;
using System.Collections.Generic;
using System.Text;

namespace Flood_Control
{
    public class ScoreZoom
    {
        public string Text;
        public Color DrawColor;
        public int displayCounter;
        public int maxDisplayCount = 30;
        public float scale = 0.4f;
        private float lastScaleAmount = 0.0f;
        private float scaleAmount = 0.4f;

        public float Scale
        {
            get { return scaleAmount * displayCounter; }
        }

        public bool IsCompleted
        {
            get { return (displayCounter > maxDisplayCount); }
        }

        public ScoreZoom(string displayText, Color fontColor)
        {
            Text = displayText;
            DrawColor = fontColor;
            displayCounter = 0;
        }

        public void Update()
        {
            scale += lastScaleAmount + scaleAmount;
            lastScaleAmount += scaleAmount;
            displayCounter++;
        }
    }
}
