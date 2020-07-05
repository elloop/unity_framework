using System.Collections;
using System.Collections.Generic;
using Elloop.Utils;
using LuaInterface;
using UnityEngine;

namespace Elloop.Framework {

    public class LuaManager : Singleton<LuaManager> {
        // MissingMethodException: Default constructor not found for type Elloop.Framework.LuaManager
//        private LuaManager() {}
        public LuaManager() {
            _luaState = new LuaState();
            _luaState.Start();
        }

        ~LuaManager() {
            _luaState = null;
        }

        private LuaState _luaState;
        public void CallLuaString(string cmd) {
            Debug.Assert(_luaState != null, "LuaManager null luaState.");
            _luaState.DoString(cmd);
        }
    }
}