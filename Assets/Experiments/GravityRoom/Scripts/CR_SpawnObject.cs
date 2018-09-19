using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;

public class CR_SpawnObject : MonoBehaviour {

    [SerializeField]
    private VRTK_BaseControllable controllable;
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Transform spawnPoint;



    private void OnEnable()
    {
        controllable.MaxLimitReached += OnMaxLimitReached;
    }

    private void OnDisable()
    {
        controllable.MaxLimitReached -= OnMaxLimitReached;
    }

    private void OnMaxLimitReached(object sender, ControllableEventArgs e)
    {
        GameObject obj = Instantiate(prefab);
        prefab.transform.position = spawnPoint.position;
    }

}
