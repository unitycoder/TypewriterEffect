﻿using Assets.Scripts.Typewriters;
using UnityEngine;

namespace Assets.Scripts.SceneScripts
{
    public class DemoScript : MonoBehaviour
    {
        // -- Editor

        public string textToAnimate = "Hello world";

        public TypewriterAnimator typewriterAnimator;

        // -- Class

        void Start()
        {
            typewriterAnimator.Animate(textToAnimate);
        }
    }
}