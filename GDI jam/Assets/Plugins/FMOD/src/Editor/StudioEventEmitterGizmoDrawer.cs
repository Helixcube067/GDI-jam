<<<<<<< HEAD
﻿using UnityEngine;
using UnityEditor;

namespace FMODUnity
{
    public class StudioEventEmitterGizoDrawer
    {
        [DrawGizmo(GizmoType.Selected | GizmoType.Active | GizmoType.NotInSelectionHierarchy | GizmoType.Pickable)]
        static void DrawGizmo(StudioEventEmitter studioEmitter, GizmoType gizmoType)
        {
            Gizmos.DrawIcon(studioEmitter.transform.position, "FMOD/FMODEmitter.tiff", true);
        }
    }
}
=======
﻿using UnityEngine;
using UnityEditor;

namespace FMODUnity
{
    public class StudioEventEmitterGizoDrawer
    {
        [DrawGizmo(GizmoType.Selected | GizmoType.Active | GizmoType.NotInSelectionHierarchy | GizmoType.Pickable)]
        static void DrawGizmo(StudioEventEmitter studioEmitter, GizmoType gizmoType)
        {
            Gizmos.DrawIcon(studioEmitter.transform.position, "FMOD/FMODEmitter.tiff", true);
        }
    }
}
>>>>>>> cda03ece3689c5aa90b5303da18f9351c6284a15
