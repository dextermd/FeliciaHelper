using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dextermd.FeliciaHelper.Domain.Enums
{
    public enum PharmacyStatus
    {
        [Display(Name = "Работает")]
        Work = 1,
        [Display(Name = "Не работает")]
        NotWork,
        [Display(Name = "Закрыта")]
        Close,
        [Display(Name = "Ремонт")]
        Repair

    }
}
