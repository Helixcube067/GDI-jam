<<<<<<< HEAD
﻿using UnityEngine;

namespace FMODUnity
{
    [AddComponentMenu("FMOD Studio/FMOD Studio Listener")]
    public class StudioListener : MonoBehaviour
    {
        Rigidbody rigidBody;
        Rigidbody2D rigidBody2D;

        public int ListenerNumber = -1;

        void OnEnable()
        {
            RuntimeUtils.EnforceLibraryOrder();
            rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
            ListenerNumber = RuntimeManager.AddListener(this);
        }

        void OnDisable()
        {
            RuntimeManager.RemoveListener(this);
        }

        void Update()
        {
            if (ListenerNumber >= 0 && ListenerNumber < FMOD.CONSTANTS.MAX_LISTENERS)
            {
                SetListenerLocation();
            }
        }

        void SetListenerLocation()
        {
            if (rigidBody)
            {
                RuntimeManager.SetListenerLocation(ListenerNumber, gameObject, rigidBody);
            }
            else
            {
                RuntimeManager.SetListenerLocation(ListenerNumber, gameObject, rigidBody2D);
            }
        }
    }
=======
﻿using UnityEngine;

namespace FMODUnity
{
    [AddComponentMenu("FMOD Studio/FMOD Studio Listener")]
    public class StudioListener : MonoBehaviour
    {
        Rigidbody rigidBody;
        Rigidbody2D rigidBody2D;

        public int ListenerNumber = -1;

        void OnEnable()
        {
            RuntimeUtils.EnforceLibraryOrder();
            rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
            ListenerNumber = RuntimeManager.AddListener(this);
        }

        void OnDisable()
        {
            RuntimeManager.RemoveListener(this);
        }

        void Update()
        {
            if (ListenerNumber >= 0 && ListenerNumber < FMOD.CONSTANTS.MAX_LISTENERS)
            {
                SetListenerLocation();
            }
        }

        void SetListenerLocation()
        {
            if (rigidBody)
            {
                RuntimeManager.SetListenerLocation(ListenerNumber, gameObject, rigidBody);
            }
            else
            {
                RuntimeManager.SetListenerLocation(ListenerNumber, gameObject, rigidBody2D);
            }
        }
    }
>>>>>>> cda03ece3689c5aa90b5303da18f9351c6284a15
}