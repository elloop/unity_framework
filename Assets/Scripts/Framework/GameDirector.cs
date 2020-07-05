using System;
using System.Collections;
using System.Collections.Generic;
using Elloop.Utils;
using UnityEngine;

namespace Elloop.Framework {

    public class GameDirector : MonoBehaviour {
        private void Awake() {
            Director.Instance.OnAwake();
        }

        private void Start() {
            Director.Instance.OnStart();
        }

        private void Update() {
            Director.Instance.OnUpdate();
        }
    }

    public class Director : Singleton<Director> {
        // MissingMethodException: Default constructor not found for type Elloop.Framework.Director
//        protected Director(){}

        public void Init() {
        }

        public void OnAwake() {
        }

        public void OnStart() {
            LuaManager.Instance.CallLuaString("require 'main'");
        }

        public void OnUpdate() {
        }
    }
}