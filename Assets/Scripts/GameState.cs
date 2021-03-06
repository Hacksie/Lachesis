﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HackedDesign
{
    [System.Serializable]
    public class GameState
    {
        public GameStateEnum gameState;
        public Selectable currentSelectable;
        public int day = 0;
        public float dayTime = 0;

        public Vector2 spacePosition;
    }

    public enum GameStateEnum
    {
        MainMenu,
        Intro,
        Playing,
        Start,
        Select,
        DeadAir,
        DeadHealth
    }

    public enum ActionStateEnum
    {
        Select,
        Repair,
        Build,
        Destroy
    }
}