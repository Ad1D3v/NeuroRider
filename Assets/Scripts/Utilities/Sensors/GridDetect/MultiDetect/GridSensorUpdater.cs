using UnityEngine;
using Unity.MLAgents.Sensors;

namespace NeuroRider.Sensors.Grid.Util
{
    /// <summary>
    /// Creates and updates a <see cref="CR_GridSensor"/>.
    /// Can be used for testing a standalone sensor component.
    /// </summary>
    [RequireComponent(typeof(CR_GridSensorComponentBase))]
    public class GridSensorUpdater : MonoBehaviour
    {
        [SerializeField, Range(1, 20)]
        private int m_UpdateInterval = 1;
        private int m_UpdateCount;

        private ISensor m_Sensor;

        private void Awake()
        {
            m_Sensor = GetComponent<CR_GridSensorComponentBase>().CreateSensor();
        }

        private void FixedUpdate()
        {
            if (m_UpdateCount % m_UpdateInterval == 0)
            {
                m_Sensor.Update();
            }
            m_UpdateCount++;
        }
    }
}