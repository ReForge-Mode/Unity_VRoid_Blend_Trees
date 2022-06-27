using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpressionControl : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Slider slider;

    /// <summary>
    /// Call this function as an event in the Slider.
    /// The Slider will call this event when there's a value change in the Slider UI.
    /// Technically, you can call this in Update() function as well.
    /// But it's less efficient to the performance.
    /// </summary>
    public void ChangeSanityValue()
    {
        anim.SetFloat("Insanity", slider.value);
    }
}
