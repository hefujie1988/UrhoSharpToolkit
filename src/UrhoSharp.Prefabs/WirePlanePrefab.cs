using System;
using System.Xml.Linq;
using Urho;
using WirePlane = Urho.WirePlane;


namespace UrhoSharp.Prefabs
{
    public class WirePlanePrefab: AbstractComponentPrefab<WirePlane>, IPrefab
    {
        private static  int SizeDefaultValue = 50;
        private static  float ScaleDefaultValue = 1f;
        private static  Color ColorDefaultValue = new Color(0.7f, 0.7f, 0.7f, 1f);
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private int _size;
        private float _scale;
        private Color _color;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public WirePlanePrefab()
        {
            _size = SizeDefaultValue;
            _scale = ScaleDefaultValue;
            _color = ColorDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public WirePlanePrefab(WirePlane val)
        {
            _size = val.Size;
            _scale = val.Scale;
            _color = val.Color;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public int Size {get { return _size;} set { _size=value; } }
        public bool SizeHasValue {get { return !PrefabUtils.AreEqual(ref _size, ref SizeDefaultValue); } }
        public float Scale {get { return _scale;} set { _scale=value; } }
        public bool ScaleHasValue {get { return !PrefabUtils.AreEqual(ref _scale, ref ScaleDefaultValue); } }
        public Color Color {get { return _color;} set { _color=value; } }
        public bool ColorHasValue {get { return !PrefabUtils.AreEqual(ref _color, ref ColorDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override WirePlane Create()
        {
            var result = new WirePlane();
            if(SizeHasValue)
                result.Size = _size;
            if(ScaleHasValue)
                result.Scale = _scale;
            if(ColorHasValue)
                result.Color = _color;
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
                case "Scale":
                    break;
                case "Color":
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
