using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TCFramework
{
    public static class TransformEx
    {
        public static bool IsOrIsChildOf(this Transform transform, Transform parent)
        {
            return transform == parent || transform.IsChildOf(parent);
        }

        public static void GetLocalPosition(this Transform transform, out float x, out float y, out float z)
        {
            var pos = transform.localPosition;
            x = pos.x;
            y = pos.y;
            z = pos.z;
        }

        public static void SetLocalPosition(this Transform transform, float x, float y, float z)
        {
            transform.localPosition = new Vector3(x, y, z);
        }

        public static float GetLocalPositionX(this Transform transform)
        {
            return transform.localPosition.x;
        }

        public static void SetLocalPositionX(this Transform transform, float x)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.x = x;
            transform.localPosition = localPosition;
        }

        public static float GetLocalPositionY(this Transform transform)
        {
            return transform.localPosition.y;
        }

        public static void SetLocalPositionY(this Transform transform, float y)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.y = y;
            transform.localPosition = localPosition;
        }

        public static float GetLocalPositionZ(this Transform transform)
        {
            return transform.localPosition.z;
        }

        public static void SetLocalPositionZ(this Transform transform, float z)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.z = z;
            transform.localPosition = localPosition;
        }

        public static void GetPosition(this Transform transform, out float x, out float y, out float z)
        {
            var pos = transform.position;
            x = pos.x;
            y = pos.y;
            z = pos.z;
        }

        public static void SetPosition(this Transform transform, float x, float y, float z)
        {
            transform.position = new Vector3(x, y, z);
        }

        public static float GetPositionX(this Transform transform)
        {
            return transform.position.x;
        }

        public static void SetPositionX(this Transform transform, float x)
        {
            Vector3 position = transform.position;
            position.x = x;
            transform.position = position;
        }

        public static float GetPositionY(this Transform transform)
        {
            return transform.position.y;
        }

        public static void SetPositionY(this Transform transform, float y)
        {
            Vector3 position = transform.position;
            position.y = y;
            transform.position = position;
        }

        public static float GetPositionZ(this Transform transform)
        {
            return transform.position.z;
        }

        public static void SetPositionZ(this Transform transform, float z)
        {
            Vector3 position = transform.position;
            position.z = z;
            transform.position = position;
        }

        public static void SetLocalRotation(this Transform transform, float x, float y, float z, float w)
        {
            transform.localRotation = new Quaternion(x, y, z, w);
        }

        public static void GetLocalEulerAngles(this Transform transform, out float x, out float y, out float z)
        {
            var pos = transform.localEulerAngles;
            x = pos.x;
            y = pos.y;
            z = pos.z;
        }

        public static void SetLocalEulerAngles(this Transform transform, float x, float y, float z)
        {
            transform.localEulerAngles = new Vector3(x, y, z);
        }

        public static float GetLocalEulerAnglesX(this Transform transform)
        {
            return transform.localEulerAngles.x;
        }

        public static void SetLocalEulerAnglesX(this Transform transform, float x)
        {
            Vector3 localEulerAngles = transform.localEulerAngles;
            localEulerAngles.x = x;
            transform.localEulerAngles = localEulerAngles;
        }
        
        public static float GetLocalEulerAnglesY(this Transform transform)
        {
            return transform.localEulerAngles.y;
        }

        public static void SetLocalEulerAnglesY(this Transform transform, float y)
        {
            Vector3 localEulerAngles = transform.localEulerAngles;
            localEulerAngles.y = y;
            transform.localEulerAngles = localEulerAngles;
        }


        public static float GetLocalEulerAnglesZ(this Transform transform)
        {
            return transform.localEulerAngles.z;
        }

        public static void SetLocalEulerAnglesZ(this Transform transform, float z)
        {
            Vector3 localEulerAngles = transform.localEulerAngles;
            localEulerAngles.z = z;
            transform.localEulerAngles = localEulerAngles;
        }

        public static void GetEulerAngles(this Transform transform, out float x, out float y, out float z)
        {
            var pos = transform.eulerAngles;
            x = pos.x;
            y = pos.y;
            z = pos.z;
        }

        public static void SetEulerAngles(this Transform transform, float x, float y, float z)
        {
            transform.eulerAngles = new Vector3(x, y, z);
        }

        public static float GetEulerAnglesX(this Transform transform)
        {
            return transform.eulerAngles.x;
        }

        public static void SetEulerAnglesX(this Transform transform, float x)
        {
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.x = x;
            transform.eulerAngles = eulerAngles;
        }

        public static float GetEulerAnglesY(this Transform transform)
        {
            return transform.eulerAngles.y;
        }

        public static void SetEulerAnglesY(this Transform transform, float y)
        {
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.y = y;
            transform.eulerAngles = eulerAngles;
        }

        public static float GetEulerAnglesZ(this Transform transform)
        {
            return transform.eulerAngles.z;
        }

        public static void SetEulerAnglesZ(this Transform transform, float z)
        {
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.z = z;
            transform.eulerAngles = eulerAngles;
        }

        public static void LookAt(this Transform transform, float x, float y, float z)
        {
            transform.LookAt(new Vector3(x, y, z));
        }

        public static void SetLocalScale(this Transform transform, float x, float y, float z)
        {
            transform.localScale = new Vector3(x, y, z);
        }

        public static void SetLocalScale(this Transform transform, float scale)
        {
            transform.localScale = new Vector3(scale, scale, scale);
        }

        public static void GetLocalScale(this Transform transform, out float x, out float y, out float z)
        {
            var scale = transform.localScale;
            x = scale.x;
            y = scale.y;
            z = scale.z;
        }

        public static void GetLossyScale(this Transform transform, out float x, out float y, out float z)
        {
            var scale = transform.lossyScale;
            x = scale.x;
            y = scale.y;
            z = scale.z;
        }

        public static string GetPath(this Transform transform, Transform parent = null)
        {
            if (!transform || !transform.parent || transform == parent)
                return "";

            string path = transform.name;
            var p = transform.parent;
            while (p && p != parent)
            {
                path = p.name + "/" + path;
                p = p.parent;
            }
            return path;
        }
        
        public static Object Find(this Transform parent, string path, Type type)
        {
            if (!parent)
                return null;

            Transform transform = string.IsNullOrEmpty(path) ? parent : parent.Find(path);
            if (transform)
            {
                if (type == typeof(Transform))
                    return transform;
                else if (type == typeof(GameObject))
                    return transform.gameObject;
                else
                    return transform.GetComponent(type);
            }
            return null;
        }

        public static T Find<T>(this Transform parent, string path) where T : Object
        {
            return Find(parent, path, typeof(T)) as T;
        }

        public static Transform FindByName(this Transform parent, string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            // 如果当前节点就能够找到的话，直接返回
            Transform ret = parent.Find(name);
            if (ret != null) return ret;

            // 否则遍历每个子节点
            int count = parent.childCount;
            for (int i = 0; i < count; ++i)
            {
                var child = parent.GetChild(i);
                ret = FindByName(child, name);
                if (ret != null) return ret;
            }
            return null;
        }

        public static void SetParentAndIdentity(this Transform transform, Transform parent)
        {
            transform.SetParent(parent, false);
            SetIdentity(transform);
        }

        public static void SetIdentity(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public static void DestroyChildren(this Transform transform)
        {
            if (!transform) return;
            int count = transform.childCount;
            for (int i = count - 1; i >= 0; --i)
            {
                ObjectEx.Destroy(transform.GetChild(i).gameObject);
            }
        }
    }
}