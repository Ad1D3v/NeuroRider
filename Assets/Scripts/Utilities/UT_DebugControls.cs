using UnityEngine;

namespace NeuroRider.MotoBase
{
    public class UT_DebugControls : MonoBehaviour
    {
        private CR_MotoPhysics m_Physics;

        private void Awake()
        {
            m_Physics = GetComponent<CR_MotoPhysics>();
            m_Physics.Initialize();
        }

        private void FixedUpdate()
        {
            m_Physics.ApplyActions(new float[]
                {
                    Input.GetAxis("Vertical"),
                    Input.GetAxis("Jump"),
                    Input.GetAxis("Horizontal")
                },
                Time.fixedDeltaTime
                );

            m_Physics.Stabilize();
        }
    }
}