

namespace UnityEngine
{
    // ReSharper disable UnusedType.Global
    public class Vector3
    {
        // ReSharper disable MemberCanBePrivate.Global,UnusedMember.Global,FieldCanBeMadeReadOnly.Global,InconsistentNaming

        public float x {get; private set;}
        public float y {get; private set;}
        public float z {get; private set;}

        public Vector3(float _x, float _y, float _z) { x=_x; y=_y; z=_z;}
    }
}
