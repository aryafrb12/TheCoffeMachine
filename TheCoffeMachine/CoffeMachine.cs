using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMachine
{
    class CoffeMachine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk Milk;

        public CoffeMachine (CoffePowder powder, WaterGalon galon, Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.Milk = milk;
        }
        public String makeEsspreso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOnecup();
            this.coffePowder.makeOneCup();
            return "Yey! Your Esspreso coffe is ready";
        }

        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the milk is empty";
            }

            this.waterGalon.makeOnecup();
            this.coffePowder.makeOneCup();
            this.Milk.makeOneCup();
            return "Yey! your Cappucino coffe is ready";
        }

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()}, the coffe powder : {this.coffePowder.getNetto()}, and the milk : {this.Milk.getVolume()}";
        }
    }
}
