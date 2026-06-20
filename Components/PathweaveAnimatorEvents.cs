using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModuDevCore.PathweaveUIX.Runtime.Animation {
    public class PathweaveAnimatorEvents : MonoBehaviour
    {
        public Animator animator => GetComponent<Animator>();
        public Action ReadyToChangeCallback;
        public void ReadyToChange() {
            ReadyToChangeCallback();
        }
    }
}
