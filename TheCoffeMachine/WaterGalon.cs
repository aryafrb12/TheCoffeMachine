﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMachine
{
    class WaterGalon
    {
        private int volume = 0;//mili liter
        private int volumeOneCup = 250;

        public WaterGalon(int volume)
        {
            this.volume = volume;
        }

        public Boolean isAvailable()
        {
            return volume >= volumeOneCup;
        }

        public void addWater(int volume)
        {
            this.volume += volume;
        }

        public int makeOnecup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }

        public int getVolume()
        {
            return this.volume;
        }
    }
}
