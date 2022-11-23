using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dextermd.FeliciaHelper.Domain.Enums
{
    public enum EconomicAgent
    {
        [Display(Name = "Birivofarm")]
        Birivofarm = 1,
        [Display(Name = "Sibtomix Grup")]
        SibtomixGrup,
        [Display(Name = "Farmacia Salut SRL")]
        FarmaciaSalutSRL
    }
}
