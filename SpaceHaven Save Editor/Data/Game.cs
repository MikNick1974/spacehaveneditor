﻿using System.Collections.Generic;

namespace SpaceHaven_Save_Editor.Data
{
    public class Game
    {
        public Game()
        {
            Ships = new List<Ship>();
            Player = new Player();
            Research = new Research();
        }

        public Player Player { get; set; }
        public Research Research { get; set; }
        public List<Ship> Ships { get; set; }
    }
}