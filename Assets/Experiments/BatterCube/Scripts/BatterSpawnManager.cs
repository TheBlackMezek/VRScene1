using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterSpawnManager : MonoBehaviour {

	public static BatterSpawnManager Instance { get; private set; }

    [SerializeField]
    private GameObject cubePrefab;
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private string invalidTag;



    private void Awake()
    {
        Instance = this;

        SpawnCube();
    }

    public void SpawnCube()
    {
        GameObject cube = Instantiate(cubePrefab);
        cube.tag = invalidTag;
        cube.transform.position = spawnPoint.position;
    }

}
