using System;
using System.Collections.Generic;

namespace Fertilize {

    class Plant 
    {
        private int _height;
        private int _health;
        private string _species;

        public Plant(int height, int health, string species)
        {
            _height = height;
            _health = health;
            _species = species;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetHealth()
        {
          return _health;
        }

        public string GetSpecies()
        {
            return _species;
        }

        public void SetHeight(int newHeight)
        {
            _height = newHeight;
        }

        public void SetHealth(int newHealth)
        {
            _health = newHealth;
        }

        public void SetSpecies(string newSpecies)
        {
            _species = newSpecies;
        }

        public void Water()
        {
            _height++;
        }

        public void Feed()
        {
            Random rnd = new Random();
            int feedNumber = rnd.Next(1, 2);
            _health = _health + feedNumber;
        }

        public void NiceDay()
        {
            _health++;
        }

        public void GiveSunshine()
        {
            _height++;
            _health++;
        }

        public void Windstorm()
        {
           _height = _height - 2;
        }

        public void AphidAttack()
        {
           _health = _health - 2;
        }

        public void SlugBite()
        {
            _height--;
            _health = _health - 2;
        }
    }
}