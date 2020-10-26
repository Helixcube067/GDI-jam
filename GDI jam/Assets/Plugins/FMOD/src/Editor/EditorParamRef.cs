<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace FMODUnity
{
    public class EditorParamRef : ScriptableObject
    {
        [SerializeField]
        public string Name;
        [SerializeField]
        public float Min;
        [SerializeField]
        public float Max;
        [SerializeField]
        public float Default;
        [SerializeField]
        public FMOD.Studio.PARAMETER_ID ID;

        public bool Exists;
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace FMODUnity
{
    public class EditorParamRef : ScriptableObject
    {
        [SerializeField]
        public string Name;
        [SerializeField]
        public float Min;
        [SerializeField]
        public float Max;
        [SerializeField]
        public float Default;
        [SerializeField]
        public FMOD.Studio.PARAMETER_ID ID;

        public bool Exists;
    }
}
>>>>>>> cda03ece3689c5aa90b5303da18f9351c6284a15
