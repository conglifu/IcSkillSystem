using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/XRModule/GestureEventTypes Value")]
    public partial class GestureEventTypesValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.Experimental.XR.GestureEventTypes _value;

        public override Type ValueType { get; } = typeof(UnityEngine.Experimental.XR.GestureEventTypes);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}