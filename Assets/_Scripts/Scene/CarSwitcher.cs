using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CarSwitcher : MonoBehaviour
{
    [Header("Vehicles")]
    public List<GameObject> vehicles;

    private int m_VehicleId;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            nextCar();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            prevCar();
        }
    }

    public void nextCar()
    {
        // Disable the previous vehicle.
        vehicles[m_VehicleId].SetActive(false);

        m_VehicleId = (m_VehicleId + 1) % vehicles.Count;

        resetPos();
        vehicles[m_VehicleId].SetActive(true);
        setCurrentVehicle();
    }

    public void prevCar()
    {
        // Disable the previous vehicle.
        vehicles[m_VehicleId].SetActive(false);


        m_VehicleId = (m_VehicleId - 1) % vehicles.Count;
        if (m_VehicleId < 0)
        {
            m_VehicleId = vehicles.Count - 1;
        }

        resetPos();
        vehicles[m_VehicleId].SetActive(true);
        setCurrentVehicle();
    }

    void resetPos()
    {
        Transform transform = vehicles[m_VehicleId].transform;
        Vector3 pos = new Vector3(0.12f, 1.1f, 1.9f);
        Quaternion rotation = new Quaternion(0.0f, 180.0f, 0.0f, 0.0f);

        transform.SetPositionAndRotation(pos, rotation);

    }

    public void setCurrentVehicle()
    {
        CurrentVehicle.currentVehicleId = m_VehicleId;
    }
}
