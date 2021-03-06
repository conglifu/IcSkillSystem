//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年11月19日-21:21
//CabinIcarus.IcSkillSystem.Expansion.Runtime

using CabinIcarus.IcSkillSystem.Nodes.Runtime.Attributes;
using NPBehave;
using UnityEngine;

namespace CabinIcarus.IcSkillSystem.Expansion.Runtime.Builtin.Nodes
{
    [CreateNodeMenu("CabinIcarus/IcSkillSystem/Behave Nodes/Task/Actions/Animator/Pause Second")]
    public class PauseAnimatorWait:AAnimatorNode
    {
        [SerializeField,Input(ShowBackingValue.Always,ConnectionType.Override,TypeConstraint.Inherited)]
        [PortTooltip("Pause time (Second)")]
        private float _time;
        
        protected override Task CreateAction()
        {
            var wait = new Wait(_getSecond);
            wait.OnStart = _stop;
            wait.OnComplete = _play;
            wait.OnStop = _play;
            
            return wait;
        }

        private float _getSecond()
        {
            return GetInputValue(nameof(_time), _time);
        }

        private void _stop()
        {
            Anim.enabled = false;
        }
        
        private void _play()
        {
            Anim.enabled = true;
        }
    }
}