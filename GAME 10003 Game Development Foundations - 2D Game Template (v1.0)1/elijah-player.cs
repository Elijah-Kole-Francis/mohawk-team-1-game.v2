using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._0_1;

namespace GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._0_1
{
    public class player(float maxHealth, string name, int slot, float maxMana)
    {
        /*
        public float currentHealth;
        public float maxHealth;
        public float damage;
        public Vector2 playerHealth;
        public float healthRegen;
        public float spellcost;
        public float mana;
        public float enemyHealth;
        */

        //setup
        float currentHealth = maxHealth;
        float atkdmg = Random.Float(1, 5);
        float currentMana = maxMana;
        public void TakingDamage(float damage)
        {
            currentHealth -= damage;
        }

        public void HealthRegen(float healthRegen)
        {
            currentHealth += healthRegen;
        }

        public void SpellCasting(float spellcost)
        {
            currentMana -= spellcost;
        }
        public void DamageRoll()
        {
           atkdmg = Random.Float(1, 5);
        }

        public float AttackDamage()
        {
            return atkdmg;
        }
    }
        
}
