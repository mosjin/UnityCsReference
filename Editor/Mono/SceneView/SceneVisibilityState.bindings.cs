// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using Object = UnityEngine.Object;

namespace UnityEditor
{
    [NativeClass(null)]
    [NativeType(Header = "Editor/Src/SceneVisibility/SceneVisibilityState.h")]
    [StaticAccessor("GetSceneVisibilityState()", StaticAccessorType.Dot)]
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    internal class SceneVisibilityState : Object
    {
        [FreeFunction("GetSceneVisibilityState")]
        public static extern Object GetInstance();

        public static extern void SetGameObjectHidden([NotNull] GameObject gameObject, bool isHidden, bool includeChildren);

        public static extern void SetGameObjectsHidden([NotNull] GameObject[] gameObjects, bool isHidden, bool includeChildren);

        public static extern bool IsGameObjectHidden([NotNull] GameObject gameObject);

        public static extern bool IsHierarchyHidden([NotNull] GameObject gameObject);

        public static extern bool AreAllChildrenVisible([NotNull] GameObject gameObject);

        public static extern bool AreAllChildrenHidden([NotNull] GameObject gameObject);

        public static extern void ShowScene(Scene scene);

        public static extern void HideScene(Scene scene);

        public static extern bool HasHiddenGameObjects(Scene scene);

        public static extern void ClearScene(Scene scene);

        public static extern void SetSceneIsolation(Scene scene, bool isolating);

        public static extern void ClearIsolation();

        public static extern void OnSceneSaving(Scene scene, string scenePath);

        public static extern void GeneratePersistentDataForAllLoadedScenes();

        public static extern void GeneratePersistentDataForLoadedScene(Scene scene);

        public static extern void OnSceneSaved(Scene scene);

        public static extern int GetHiddenObjectCount();
        public static extern void SetPrefabStageScene(Scene scene);

        public static Action internalStructureChanged;

        [RequiredByNativeCode]
        private static void Internal_InternalStructureChanged()
        {
            internalStructureChanged?.Invoke();
        }

        public static extern bool active { get; set; }
        public static extern bool prefabStageIsolated { get; set; }
        public static extern bool mainStageIsolated { get; set; }
    }
}
