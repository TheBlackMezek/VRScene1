using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterCubeFloor : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        BatterSpawnManager.Instance.SpawnCube();
    }

}
