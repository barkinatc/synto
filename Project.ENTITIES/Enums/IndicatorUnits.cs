using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Enums
{
    public enum IndicatorUnits
    {
        [Description("TL")]
        TurkLira = 0,
        [Description("KG")]
        Kilogram = 1,
        [Description("M")]
        Metre = 2,
        [Description("m²")]
        MetreKare =3 ,
        [Description("m³")]
        MetreKup =4,
        [Description("Adet")]
        Adet = 5 ,
        [Description("%")]
        Yuzde = 6,
        [Description("TON")]
        Ton = 7,
        [Description("LT")]
        Litre = 8
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
