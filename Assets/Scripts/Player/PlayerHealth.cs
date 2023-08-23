using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [Header("Health Bar")]
        private float health;
        private float lerpTime;
        public float maxHealth = 100;
        public float chipSpeed = 2f;
        public Slider frontSlider; //The front slider control
        public Slider backSlider; //The back slider control
        public Image backFill; //The back image control

        [Header("Damage Overlay")]
        public Volume overlay;
        public float duration;
        public float fadeSpeed;
        public float durationTimer;
        public void Start()
        {
            health = maxHealth;
        }
        
        public void Update()
        {
            health = Mathf.Clamp(health, 0, maxHealth);
            UpdateHealthUI();
            if (overlay.weight > 0)
            {
                durationTimer += Time.deltaTime;
                if (durationTimer > duration)
                {
                }
            }
        }

        private void UpdateHealthUI()
        {
            //Chips the health bar
            float frontFillChip = frontSlider.value;
            float backFillChip = backSlider.value;
            
            float hFraction = health / maxHealth;
            
            //Used for losing health
            if (backFillChip > hFraction)
            {
                frontSlider.value = hFraction;
                backFill.color = Color.red;
                lerpTime += Time.deltaTime;
                float percentComplete = lerpTime / chipSpeed;
                percentComplete *= percentComplete;
                //Moves bar 
                backSlider.value = Mathf.Lerp(backFillChip, hFraction, percentComplete);
            }
            
            //Used for gaining health
            if (!(frontFillChip < hFraction)) return;
            {
                backFill.color = Color.green;
                backSlider.value = hFraction;
                lerpTime += Time.deltaTime;
                float percentComplete = lerpTime / chipSpeed;
                percentComplete *= percentComplete;
                //Moves bar
                frontSlider.value = Mathf.Lerp(frontFillChip, backSlider.value, percentComplete);
            }
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            lerpTime = 0f;
        }

        public void RestoreHealth(float healAmount)
        {
            health += healAmount;
            lerpTime = 0f;
        }
    }
}
