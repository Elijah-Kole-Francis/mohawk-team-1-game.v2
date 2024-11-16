using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._0_1
{
    public class player
    {
        private float currentHealth;
        private float damage;
        private Vector2 playerHealth;
        private float healthRegen;
        private float spellcost;
        private float mana;
        private float enemyHealth;
        public player()
        {

        }

        private void TakingDamage(float damage)
        {
            currentHealth -= damage;
        }

        private void HealthReven()
        {
            healthRegen += currentHealth;
        }

        private void DealingDamage(float damage)
        {
            enemyHealth -= damage;
        }

        private void Spellcasting(float spellcost)
        {
            mana -= spellcost;
        }
    }
}
