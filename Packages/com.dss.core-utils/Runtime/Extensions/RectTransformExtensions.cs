﻿using UnityEngine;

namespace DSS.CoreUtils.Extensions
{
    // @brief A collection of RectTransform extension methods.
    public static class RectTransformExtensions
    {
        // @brief Sets the "Left" property of this RectTransform.
        public static void SetLeft(this RectTransform rt, float left)
        {
            rt.offsetMin = new Vector2(left, rt.offsetMin.y);
        }

        // @brief Returns the "Left" property of this RectTransform.
        public static float GetLeft(this RectTransform rt)
        {
            return rt.offsetMin.x;
        }
  
          // @brief Sets the "Right" property of this RectTransform.
        public static void SetRight(this RectTransform rt, float right)
        {
            rt.offsetMax = new Vector2(-right, rt.offsetMax.y);
        }

        // @brief Returns the "Right" property of this RectTransform.
        public static float GetRight(this RectTransform rt)
        {
            return -rt.offsetMin.x;
        }

        // @brief Sets the "Top" property of this RectTransform.
        public static void SetTop(this RectTransform rt, float top)
        {
            rt.offsetMax = new Vector2(rt.offsetMax.x, -top);
        }

        // @brief Returns the "Top" property of this RectTransform.
        public static float GetTop(this RectTransform rt)
        {
            return -rt.offsetMin.y;
        }

        // @brief Sets the "Bottoms" property of this RectTransform.
        public static void SetBottom(this RectTransform rt, float bottom)
        {
            rt.offsetMin = new Vector2(rt.offsetMin.x, bottom);
        }

        // @brief Returns the "Bottom" property of this RectTransform.
        public static float GetBottom(this RectTransform rt)
        {
            return rt.offsetMin.y;
        }

        // @brief Sets this RectTransform's anchoredPosition.x.
        public static void SetAnchoredPositionX(this RectTransform rt, float x)
        {
            rt.anchoredPosition = new Vector2(x, rt.anchoredPosition.y);
        }

        // @brief Returns this RectTransform's current anchoredPosition.x.
        public static float GetAnchoredPositionX(this RectTransform rt)
        {
            return rt.anchoredPosition.x;
        }

        // @brief Sets this RectTransform's anchoredPosition.y.
        public static void SetAnchoredPositionY(this RectTransform rt, float y)
        {
            rt.anchoredPosition = new Vector2(rt.anchoredPosition.x, y);
        }

        // @brief Returns this RectTransform's current anchoredPosition.y.
        public static float GetAnchoredPositionY(this RectTransform rt)
        {
            return rt.anchoredPosition.y;
        }

        // @brief Sets this RectTransform's sizeDelta.x.
        public static void SetSizeDeltaX(this RectTransform rt, float width)
        {
            rt.sizeDelta = new Vector2(width, rt.sizeDelta.y);
        }

        // @brief Returns this RectTransform's current sizeDelta.x.
        public static float GetSizeDeltaX(this RectTransform rt)
        {
            return rt.sizeDelta.x;
        }

        // @brief Sets this RectTransform's sizeDelta.y.
        public static void SetSizeDeltaY(this RectTransform rt, float height)
        {
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, height);
        }

        // @brief Returns this RectTransform's current sizeDelta.y.
        public static float GetSizeDeltaY(this RectTransform rt)
        {
            return rt.sizeDelta.y;
        }

        // @brief Sets this RectTransform's anchorMin.x.
        public static void SetAnchorMinX(this RectTransform rt, float x)
        {
            rt.anchorMin = new Vector2(x, rt.anchorMin.y);
        }

        // @brief Returns this RectTransform's current anchorMin.x.
        public static float GetAnchorMinX(this RectTransform rt)
        {
            return rt.anchorMin.x;
        }

        // @brief Sets this RectTransform's anchorMin.y.
        public static void SetAnchorMinY(this RectTransform rt, float y)
        {
            rt.anchorMin = new Vector2(rt.anchorMin.x, y);
        }

        // @brief Returns this RectTransform's current anchorMin.y.
        public static float GetAnchorMinY(this RectTransform rt)
        {
            return rt.anchorMin.y;
        }

        // @brief Sets this RectTransform's anchorMax.x.
        public static void SetAnchorMaxX(this RectTransform rt, float x)
        {
            rt.anchorMax = new Vector2(x, rt.anchorMax.y);
        }

        // @brief Returns this RectTransform's current anchorMax.x.
        public static float GetAnchorMaxX(this RectTransform rt)
        {
            return rt.anchorMax.x;
        }

        // @brief Sets this RectTransform's anchorMax.y.
        public static void SetAnchorMaxY(this RectTransform rt, float y)
        {
            rt.anchorMax = new Vector2(rt.anchorMax.x, y);
        }

        // @brief Returns this RectTransform's current anchorMax.y.
        public static float GetAnchorMaxY(this RectTransform rt)
        {
            return rt.anchorMax.y;
        }

        // @brief Sets this RectTransforms pivot.x.
        public static void SetPivotX(this RectTransform rt, float x)
        {
            rt.pivot = new Vector2(x, rt.pivot.y);
        }

        // @brief Returns this RectTransforms pivot.x.
        public static float GetPivotX(this RectTransform rt)
        {
            return rt.pivot.x;
        }

        // @brief Sets this RectTransforms pivot.y.
        public static void SetPivotY(this RectTransform rt, float y)
        {
            rt.pivot = new Vector2(rt.pivot.x, y);
        }

        // @brief Returns this RectTransforms pivot.y.
        public static float GetPivotY(this RectTransform rt)
        {
            return rt.pivot.y;
        }

        // @brief Resets the RectTransforms properties.
        public static void Reset(this RectTransform rt)
        {
            rt.anchoredPosition = Vector2.zero;
            rt.pivot = Vector2.one*0.5f;
            rt.anchorMin = rt.pivot;
            rt.anchorMax = rt.pivot;
            rt.sizeDelta = Vector2.one*100f;

            rt.localScale = Vector3.one;
            rt.localRotation = Quaternion.identity;
        }

        // @brief Expands the RectTransform to it's parent, centered at 0.5
        public static void Expand(this RectTransform rt)
        {
            rt.ExpandAtPivot(Vector2.one*0.5f);
        }

        // @brief Expands the RectTransform to it's parent, centered at the given pivot.
        public static void ExpandAtPivot(this RectTransform rt, Vector2 pivot)
        {
            rt.pivot = pivot;

            rt.anchorMin = Vector2.zero;
            rt.anchorMax = Vector2.one;

            rt.sizeDelta = Vector2.zero;
        }
    }

    // Source(s)
    // ---------
    // SetLeft, SetRight, SetTop, SetBottom
    // Unity Answers user "Eldoir"
    // https://answers.unity.com/questions/888257/access-left-right-top-and-bottom-of-recttransform.html
}