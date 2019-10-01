using UnityEngine;

namespace DapperDino.Combat
{
    public class DamageOnContact : MonoBehaviour
    {
        [SerializeField] private int amount = 10;

        private void OnTriggerEnter(Collider other)
        {
            var damageable = other.GetComponent<IDamageable>();

            if (damageable == null) { return; }

            damageable.DealDamage(amount);
        }
    }
}
