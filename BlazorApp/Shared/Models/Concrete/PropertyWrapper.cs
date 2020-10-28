using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Shared.Models.Concrete
{
    public class PropertyWrapper
    {
        readonly DisplayAttribute displayAttr;
        readonly PropertyInfo info;

        public PropertyWrapper(object Value, string PropertyName, PropertyInfo Info)
        {
            info = Info;
            this.Value = Value;
            displayAttr = info.GetCustomAttribute<DisplayAttribute>();

            if (displayAttr != null)
                DisplayValue = displayAttr.Name;
            else
                DisplayValue = PropertyName;

            if (Value is bool b)
                PropertyValue = b ? "Yes" : "No";
            else
                PropertyValue = Value.ToString();
        }

        public object Value { get; }
        public string PropertyName { get; }
        public string DisplayValue { get; }
        public string PropertyValue { get; }
    }
}
