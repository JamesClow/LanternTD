using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [System.Serializable]
    public class Wavelet {
        public int time;
        // public Enemy enemies[];
        public Spawner spawner;
    }

    [System.Serializable]
    public class Wave {
        public List<Wavelet> wavelets;
    }

    private int waveCounter;
    public List<Wave> waves;
    
    void Start() {
        waveCounter = 0;
    }

    // if there are no remaining enemies
    public void WaveHasEnded() {
        
        //if (this.waveCounter >= allWaves.count) {
            // Game is over
       // }
    }
    
    public void TriggerWave() {
        this.waveCounter++;
    }
}
