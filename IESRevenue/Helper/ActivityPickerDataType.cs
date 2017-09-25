using System.Collections.Generic;

namespace IESRevenue.Helper
{
    public class PickerDataType
    {
        /// <summary>The name of the picker data type.</summary>
        public string Name { get; set; }

        /// <summary>The available values for the type.</summary>
        public string[] Values { get; set; }

        /// <summary>The default value to select.</summary>
        public int DefaultValue { get; set; }

        private static List<PickerDataType> pickerDataTypes;

        public static PickerDataType GetPickerDataType(string name)
        {
            foreach (PickerDataType apdt in pickerDataTypes)
            {
                if (apdt.Name == name)
                    return apdt;
            }

            return null;
        }

        public static int GetValueIndex(PickerDataType apdt, string value)
        {
            for (int i = 0; i < apdt.Values.Length; i++)
            {
                if (apdt.Values[i] == value)
                    return i;
            }

            return -1;
        }
    }
}
