using UnityEngine;

namespace DapperDino.Combat
{
    public class HealthSystem : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] private int maxHealth = 100;
        private int currentHealth = 0;

        private void Start() => currentHealth = maxHealth;

        public void DealDamage(int amount)
        {
            if (amount <= 0) { return; }

            currentHealth = Mathf.Max(0, currentHealth - amount);

            if (currentHealth == 0)
            {
                Destroy(gameObject);
            }
        }

        public void Heal(int amount)
        {
            if (amount <= 0) { return; }

            currentHealth = Mathf.Min(maxHealth, currentHealth + amount);
        }
    }
}
