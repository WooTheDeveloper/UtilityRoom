using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace TCFramework
{
    public static class SceneEx
    {
        public static T FindObjectOfType<T>(this Scene scene, bool includeInactive = false)
        {
            var roots = Temp<GameObject>.list;
            scene.GetRootGameObjects(roots);

            for (int i = 0; i < roots.Count; ++i)
            {
                var obj = roots[i].GetComponentInChildren<T>(includeInactive);
                if (obj != null) return obj;
            }

            roots.Clear();
            return default;

        }

        public static Object FindObjectOfType(this Scene scene, Type type, bool includeInactive = false)
        {
            var roots = Temp<GameObject>.list;
            scene.GetRootGameObjects(roots);

            for (int i = 0; i < roots.Count; ++i)
            {
                var obj = roots[i].GetComponentInChildren(type, includeInactive);
                if (obj) return obj;
            }

            roots.Clear();
            return null;
        }

        public static T[] FindObjectsOfType<T>(this Scene scene, bool includeInactive = false)
        {
            var roots = Temp<GameObject>.list;
            scene.GetRootGameObjects(roots);

            var results = Temp<T>.list;
            var objects = Temp<T>.list2;
            for (int i = 0; i < roots.Count; ++i)
            {
                roots[i].GetComponentsInChildren(includeInactive, objects);
                results.AddRange(objects);
            }

            var array = results.ToArray();
            results.Clear();
            objects.Clear();
            roots.Clear();
            return array;
        }

        public static Object[] FindObjectsOfType(this Scene scene, Type type, bool includeInactive = false)
        {
            var roots = Temp<GameObject>.list;
            scene.GetRootGameObjects(roots);

            var results = Temp<Object>.list;
            for (int i = 0; i < roots.Count; ++i)
            {
                var objects = roots[i].GetComponentsInChildren(type, includeInactive);
                results.AddRange(objects);
            }

            var array = results.ToArray();
            results.Clear();
            roots.Clear();
            return array;
        }

        public static void FindObjectsOfType<T>(this Scene scene, bool includeInactive, List<T> results)
        {
            var roots = Temp<GameObject>.list;
            scene.GetRootGameObjects(roots);

            var objects = Temp<T>.list;
            for (int i = 0; i < roots.Count; ++i)
            {
                roots[i].GetComponentsInChildren<T>(includeInactive, objects);
                results.AddRange(objects);
            }

            objects.Clear();
            roots.Clear();
        }

        public static void FindObjectsOfType<T>(this Scene scene, List<T> results)
        {
            FindObjectsOfType(scene, false, results);
        }
    }
}