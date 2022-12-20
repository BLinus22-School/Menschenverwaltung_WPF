using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Menschenverwaltung
{
    [Flags]
    public enum EnumFamilienstand
    {
        // https://stackoverflow.com/questions/13099834/how-to-get-the-display-name-attribute-of-an-enum-member-via-mvc-razor-code

        [Display(Name = "ledig")]
        ledig = 10,

        [Display(Name = "verheiratet")]
        verheiratet = 20,

        [Display(Name = "geschieden")]
        geschieden = 30,

        [Display(Name = "verwitwet")]
        verwitwet = 40,

        [Display(Name = "eingetragene Lebenspartnerschaft")]
        eingetrageneLebenspartnerschaft = 50,

        [Display(Name = "eingetragene Lebenspartnerschaft verstorben")]
        eingetrageneLebenspartnerschaftVerstorben = 52,

        [Display(Name = "eingetragene Lebenspartnerschaft aufgehoben")]
        eingetrageneLebenspartnerschaftAufgehoben = 54
    }
}
