using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {
    [Header("Vehicles")]
    public List<GameObject> vehicles;

    [Header("Spawn Loaction")]
    public Transform spawnLocation;

    [Header("Chase cam")]
    public RVP.CameraControl camera;

    private GameObject vehicle;
	// Use this for initialization
	void Start () {
        vehicle = Instantiate(vehicles[CurrentVehicle.currentVehicleId], spawnLocation.transform.position, Quaternion.Euler(0, -168, 0)) as GameObject;
        vehicle.SetActive(true);

        camera.target = vehicle.transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
