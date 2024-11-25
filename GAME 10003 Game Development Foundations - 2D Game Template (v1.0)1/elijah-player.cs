using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._0_1;

namespace GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._0_1
{
    //initialized objects of max health, name, scene, mana for controller  
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
        float playerX = (0);
        float playerY = (0);
        public void SetPlayerPos(float posX, float posY)
        {
            playerX = posX;
            playerY = posY;
        }
        public void blit()
        {
            //head
            Draw.FillColor = new(0, 255, 0, 50);
            Draw.Circle(playerX, playerY, 35);

            //crown
            Draw.FillColor = Color.Yellow;
            Draw.Rectangle(90, 200, 70, 10);
            Draw.Ellipse(90, 200, 10, 10);

            //body
            Draw.FillColor = Color.DarkGray;
            Draw.Capsule(125, 250, 125, 390, 15);

            //arm
            Draw.Capsule(125, 285, 210, 305, 5);

            //legs
            Draw.Capsule(125, 390, 70, 490, 10);
            Draw.Capsule(125, 390, 200, 420, 10);
            Draw.Capsule(200, 420, 200, 490, 10);

            //Sword
            Draw.FillColor = Color.LightGray;
            Draw.Quad(190, 330, 230, 300, 240, 310, 200, 340);
            Draw.Quad(220, 290, 230, 380, 260, 310, 250, 320);

            Draw.FillColor= Color.DarkGray;
            Draw.Capsule(230, 310, 330, 230, 5);
        }
        public string Name()
        {
            return name;
        }

        public int Slot()
        { 
            return slot;
        }
        
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
