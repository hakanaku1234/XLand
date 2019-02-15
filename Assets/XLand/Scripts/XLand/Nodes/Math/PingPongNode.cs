using UnityEngine;

namespace XLand.Nodes
{
    [MarkAsNode(DisplayName = "Math/Ping Pong")]
    public class PingPongNode : Node
    {
        [MarkAsNodeField(Type = NodeFieldType.Input)]
        public float t;

        [MarkAsNodeField(Type = NodeFieldType.Input)]
        public float length;

        [MarkAsNodeField(Type = NodeFieldType.Output)]
        public float output;

        public override void Evaluate()
        {
            output = Mathf.Repeat(t, length);
        }
    }
}