using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeEvent : MonoBehaviour
{
    void Start (){
        SwipeManager.OnSwipeDetected += OnSwipeDetected;
    }
 
    void OnSwipeDetected (Swipe direction, Vector2 swipeVelocity){
        
    }
}
