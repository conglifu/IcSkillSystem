using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/AudioModule/AudioDataLoadState Value")]
    public partial class AudioDataLoadStateValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.AudioDataLoadState _value;

        public override Type ValueType { get; } = typeof(UnityEngine.AudioDataLoadState);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}