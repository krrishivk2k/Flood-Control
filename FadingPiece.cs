﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Flood_Control
{
    public class FadingPiece : GamePiece
    {
        public float alphaLevel = 1.0f;
        public static float alphaChangeRate = 0.02f;

        public FadingPiece(string pieceType, string suffix)
            : base(pieceType)
        {
        }

        public void UpdatePiece()
        {
            alphaLevel = MathHelper.Max(0, alphaLevel - alphaChangeRate);
        }
    }
}