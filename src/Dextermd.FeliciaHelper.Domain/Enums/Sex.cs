using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dextermd.FeliciaHelper.Domain.Enums
{
    public enum Sex
    {
        [Display(Name = "Женский")]
        Female = 1,
        [Display(Name = "Мужской")]
        Male
    }
}
