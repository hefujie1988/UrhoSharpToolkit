using System;
using System.Xml.Linq;
using Urho;
using CollisionBox2D = Urho.Urho2D.CollisionBox2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class CollisionBox2DPrefab: AbstractComponentPrefab<CollisionBox2D>, IPrefab
    {
        private static  Vector2 SizeDefaultValue = new Vector2(0.01f, 0.01f);
        private static  Vector2 CenterDefaultValue = new Vector2(0f, 0f);
        private static  float AngleDefaultValue = 0f;
        private static  bool TriggerDefaultValue = false;
        private static  int CategoryBitsDefaultValue = 1;
        private static  int MaskBitsDefaultValue = 65535;
        private static  int GroupIndexDefaultValue = 0;
        private static  float DensityDefaultValue = 0f;
        private static  float FrictionDefaultValue = 0.2f;
        private static  float RestitutionDefaultValue = 0f;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _size;
        private Vector2 _center;
        private float _angle;
        private bool _trigger;
        private int _categoryBits;
        private int _maskBits;
        private int _groupIndex;
        private float _density;
        private float _friction;
        private float _restitution;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public CollisionBox2DPrefab()
        {
            _size = SizeDefaultValue;
            _center = CenterDefaultValue;
            _angle = AngleDefaultValue;
            _trigger = TriggerDefaultValue;
            _categoryBits = CategoryBitsDefaultValue;
            _maskBits = MaskBitsDefaultValue;
            _groupIndex = GroupIndexDefaultValue;
            _density = DensityDefaultValue;
            _friction = FrictionDefaultValue;
            _restitution = RestitutionDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public CollisionBox2DPrefab(CollisionBox2D val)
        {
            _size = val.Size;
            _center = val.Center;
            _angle = val.Angle;
            _trigger = val.Trigger;
            _categoryBits = val.CategoryBits;
            _maskBits = val.MaskBits;
            _groupIndex = val.GroupIndex;
            _density = val.Density;
            _friction = val.Friction;
            _restitution = val.Restitution;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector2 Size {get { return _size;} set { _size=value; } }
        public bool SizeHasValue {get { return !PrefabUtils.AreEqual(ref _size, ref SizeDefaultValue); } }
        public Vector2 Center {get { return _center;} set { _center=value; } }
        public bool CenterHasValue {get { return !PrefabUtils.AreEqual(ref _center, ref CenterDefaultValue); } }
        public float Angle {get { return _angle;} set { _angle=value; } }
        public bool AngleHasValue {get { return !PrefabUtils.AreEqual(ref _angle, ref AngleDefaultValue); } }
        public bool Trigger {get { return _trigger;} set { _trigger=value; } }
        public bool TriggerHasValue {get { return !PrefabUtils.AreEqual(ref _trigger, ref TriggerDefaultValue); } }
        public int CategoryBits {get { return _categoryBits;} set { _categoryBits=value; } }
        public bool CategoryBitsHasValue {get { return !PrefabUtils.AreEqual(ref _categoryBits, ref CategoryBitsDefaultValue); } }
        public int MaskBits {get { return _maskBits;} set { _maskBits=value; } }
        public bool MaskBitsHasValue {get { return !PrefabUtils.AreEqual(ref _maskBits, ref MaskBitsDefaultValue); } }
        public int GroupIndex {get { return _groupIndex;} set { _groupIndex=value; } }
        public bool GroupIndexHasValue {get { return !PrefabUtils.AreEqual(ref _groupIndex, ref GroupIndexDefaultValue); } }
        public float Density {get { return _density;} set { _density=value; } }
        public bool DensityHasValue {get { return !PrefabUtils.AreEqual(ref _density, ref DensityDefaultValue); } }
        public float Friction {get { return _friction;} set { _friction=value; } }
        public bool FrictionHasValue {get { return !PrefabUtils.AreEqual(ref _friction, ref FrictionDefaultValue); } }
        public float Restitution {get { return _restitution;} set { _restitution=value; } }
        public bool RestitutionHasValue {get { return !PrefabUtils.AreEqual(ref _restitution, ref RestitutionDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override CollisionBox2D Create()
        {
            var result = new CollisionBox2D();
            if(SizeHasValue)
                result.Size = _size;
            if(CenterHasValue)
                result.Center = _center;
            if(AngleHasValue)
                result.Angle = _angle;
            if(TriggerHasValue)
                result.Trigger = _trigger;
            if(CategoryBitsHasValue)
                result.CategoryBits = _categoryBits;
            if(MaskBitsHasValue)
                result.MaskBits = _maskBits;
            if(GroupIndexHasValue)
                result.GroupIndex = _groupIndex;
            if(DensityHasValue)
                result.Density = _density;
            if(FrictionHasValue)
                result.Friction = _friction;
            if(RestitutionHasValue)
                result.Restitution = _restitution;
            if(EnabledHasValue)
                result.Enabled = _enabled;
            if(AnimationEnabledHasValue)
                result.AnimationEnabled = _animationEnabled;
            if(TemporaryHasValue)
                result.Temporary = _temporary;
            if(BlockEventsHasValue)
                result.BlockEvents = _blockEvents;
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "Size":
                    break;
                case "Center":
                    break;
                case "Angle":
                    break;
                case "Trigger":
                    break;
                case "CategoryBits":
                    break;
                case "MaskBits":
                    break;
                case "GroupIndex":
                    break;
                case "Density":
                    break;
                case "Friction":
                    break;
                case "Restitution":
                    break;
                case "Enabled":
                    break;
                case "AnimationEnabled":
                    break;
                case "Temporary":
                    break;
                case "BlockEvents":
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
    }
}