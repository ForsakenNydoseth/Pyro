namespace Pyro.Math.Geometry
{
    public interface I3DShape
    {
        public Vector3D[] Points { get; }
        public Limit[] XLimits { get; }
        public Limit[] YLimits { get; }
        public Limit[] ZLimits { get; }
        
        public Vector3D this[int num]
        {
            get;
            set;
        }
    }
}