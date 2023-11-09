using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthMax = 10;
    public int healthCurrent = 0;

    public void TakeDamage(int dmg) {
        this.healthCurrent -= dmg;
        if(this.healthCurrent <= 0) {
            this.Die();
        }
    }

    private void Die() {
        // Notify death observers
    }

    void Start() {
        this.healthCurrent = healthMax;
    }
}
