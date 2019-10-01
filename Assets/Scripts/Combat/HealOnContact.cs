using UnityEngine;

namespace DapperDino.Combat
{
    public class HealOnContact : MonoBehaviour
    {
        [SerializeField] private int amount = 10;

        private void OnTriggerEnter(Collider other)
        {
            var healable = other.GetComponent<IHealable>();

            if (healable == null) { return; }

            healable.Heal(amount);
        }
    }
}
