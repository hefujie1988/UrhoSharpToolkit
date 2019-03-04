using System;
using System.Xml.Linq;
using Urho;
using ConstraintMouse2D = Urho.Urho2D.ConstraintMouse2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class ConstraintMouse2DPrefab: AbstractComponentPrefab<ConstraintMouse2D>, IPrefab
    {
        private static  Vector2 TargetDefaultValue = new Vector2(0f, 0f);
        private static  float MaxForceDefaultValue = 0f;
        private static  float FrequencyHzDefaultValue = 5f;
        private static  float DampingRatioDefaultValue = 0.7f;
        private static  RigidBody2D OtherBodyDefaultValue = null;
        private static  bool CollideConnectedDefaultValue = false;
        private static  Constraint2D AttachedConstraintDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _target;
        private float _maxForce;
        private float _frequencyHz;
        private float _dampingRatio;
        private RigidBody2D _otherBody;
        private bool _collideConnected;
        private Constraint2D _attachedConstraint;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ConstraintMouse2DPrefab()
        {
            _target = TargetDefaultValue;
            _maxForce = MaxForceDefaultValue;
            _frequencyHz = FrequencyHzDefaultValue;
            _dampingRatio = DampingRatioDefaultValue;
            _otherBody = OtherBodyDefaultValue;
            _collideConnected = CollideConnectedDefaultValue;
            _attachedConstraint = AttachedConstraintDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ConstraintMouse2DPrefab(ConstraintMouse2D val)
        {
            _target = val.Target;
            _maxForce = val.MaxForce;
            _frequencyHz = val.FrequencyHz;
            _dampingRatio = val.DampingRatio;
            _otherBody = val.OtherBody;
            _collideConnected = val.CollideConnected;
            _attachedConstraint = val.AttachedConstraint;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector2 Target {get { return _target;} set { _target=value; } }
        public bool TargetHasValue {get { return !PrefabUtils.AreEqual(ref _target, ref TargetDefaultValue); } }
        public float MaxForce {get { return _maxForce;} set { _maxForce=value; } }
        public bool MaxForceHasValue {get { return !PrefabUtils.AreEqual(ref _maxForce, ref MaxForceDefaultValue); } }
        public float FrequencyHz {get { return _frequencyHz;} set { _frequencyHz=value; } }
        public bool FrequencyHzHasValue {get { return !PrefabUtils.AreEqual(ref _frequencyHz, ref FrequencyHzDefaultValue); } }
        public float DampingRatio {get { return _dampingRatio;} set { _dampingRatio=value; } }
        public bool DampingRatioHasValue {get { return !PrefabUtils.AreEqual(ref _dampingRatio, ref DampingRatioDefaultValue); } }
        public RigidBody2D OtherBody {get { return _otherBody;} set { _otherBody=value; } }
        public bool OtherBodyHasValue {get { return !PrefabUtils.AreEqual(ref _otherBody, ref OtherBodyDefaultValue); } }
        public bool CollideConnected {get { return _collideConnected;} set { _collideConnected=value; } }
        public bool CollideConnectedHasValue {get { return !PrefabUtils.AreEqual(ref _collideConnected, ref CollideConnectedDefaultValue); } }
        public Constraint2D AttachedConstraint {get { return _attachedConstraint;} set { _attachedConstraint=value; } }
        public bool AttachedConstraintHasValue {get { return !PrefabUtils.AreEqual(ref _attachedConstraint, ref AttachedConstraintDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override ConstraintMouse2D Create()
        {
            var result = new ConstraintMouse2D();
            if(TargetHasValue)
                result.Target = _target;
            if(MaxForceHasValue)
                result.MaxForce = _maxForce;
            if(FrequencyHzHasValue)
                result.FrequencyHz = _frequencyHz;
            if(DampingRatioHasValue)
                result.DampingRatio = _dampingRatio;
            if(OtherBodyHasValue)
                result.OtherBody = _otherBody;
            if(CollideConnectedHasValue)
                result.CollideConnected = _collideConnected;
            if(AttachedConstraintHasValue)
                result.AttachedConstraint = _attachedConstraint;
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
                case "Target":
                    break;
                case "MaxForce":
                    break;
                case "FrequencyHz":
                    break;
                case "DampingRatio":
                    break;
                case "OtherBody":
                    break;
                case "CollideConnected":
                    break;
                case "AttachedConstraint":
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