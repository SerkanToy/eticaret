using System.Dynamic;

namespace eticaret.Models
{
    public class Dynamic: DynamicObject
    {
        Dictionary<string, object> _dictionary = new Dictionary<string, object>();
        public object this[string propertyName]
        {
            get { return _dictionary[propertyName]; }
            set { AddProperty(propertyName, value); }
        }
        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            return _dictionary.TryGetValue(binder.Name, out result);
        }
        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            AddProperty(binder.Name, value);
            return true;
        }

        public void AddProperty(string name, object value)
        {
            _dictionary[name] = value;
        }
    }
}
