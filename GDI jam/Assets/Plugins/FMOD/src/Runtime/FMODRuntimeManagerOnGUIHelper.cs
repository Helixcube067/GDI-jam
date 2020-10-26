<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FMODUnity
{
    public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
    {
        public RuntimeManager TargetRuntimeManager = null;

        private void OnGUI()
        {
            if (TargetRuntimeManager)
            {
                TargetRuntimeManager.ExecuteOnGUI();
            }
        }
    }
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FMODUnity
{
    public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
    {
        public RuntimeManager TargetRuntimeManager = null;

        private void OnGUI()
        {
            if (TargetRuntimeManager)
            {
                TargetRuntimeManager.ExecuteOnGUI();
            }
        }
    }
>>>>>>> cda03ece3689c5aa90b5303da18f9351c6284a15
}