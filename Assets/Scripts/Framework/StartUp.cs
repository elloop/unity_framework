using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elloop.Framework {

    public class StartUp : MonoBehaviour {
        private void Awake() {
            var gameDirector = new GameObject("GameDirector");
            gameDirector.AddComponent<GameDirector>();
            DontDestroyOnLoad(gameDirector);
        }

        void Start() {
        }

        void Update() { }
    }
}
