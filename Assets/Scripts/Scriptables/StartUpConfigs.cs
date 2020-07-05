using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elloop.Scriptables {
    [CreateAssetMenu(menuName = "配置文件/启动配置", fileName = "start_up_configs")]
    public class StartUpConfigs : ScriptableObject {
        public string startUpSceneName;
    }
}