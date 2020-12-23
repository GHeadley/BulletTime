using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureLogic : MonoBehaviour, IMixedRealityGestureHandler<Vector3>
{
    public void OnGestureStarted(InputEventData eventData)
    {
        Debug.Log($"OnGestureStarted Input [{Time.frameCount}]: {eventData.MixedRealityInputAction.Description}");
        Destroy(this.gameObject);
    }

    public void OnGestureUpdated(InputEventData<Vector3> eventData)
    {
        Debug.Log($"OnGestureUpdated Vector [{Time.frameCount}]: {eventData.MixedRealityInputAction.Description}");
        Destroy(this.gameObject);
    }

    public void OnGestureCompleted(InputEventData<Vector3> eventData)
    {
        Debug.Log($"OnGestureCompleted Vector [{Time.frameCount}]: {eventData.MixedRealityInputAction.Description}");
        Destroy(this.gameObject);
    }

    public void OnGestureUpdated(InputEventData eventData)
    {
        Debug.Log($"OnGestureUpdated Input [{Time.frameCount}]: {eventData.MixedRealityInputAction.Description}");
        Destroy(this.gameObject);
    }

    public void OnGestureCompleted(InputEventData eventData)
    {
        Debug.Log($"OnGestureCompleted Input [{Time.frameCount}]: {eventData.MixedRealityInputAction.Description}");
        Destroy(this.gameObject);
    }

    public void OnGestureCanceled(InputEventData eventData)
    {
        Debug.Log($"OnGestureCanceled Input [{Time.frameCount}]: {eventData.MixedRealityInputAction.Description}");
        Destroy(this.gameObject);
    }
}
