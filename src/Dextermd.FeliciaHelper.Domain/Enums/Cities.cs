using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dextermd.FeliciaHelper.Domain.Enums
{
    public enum Cities
    {
        Chisinau = 1,
        [Display(Name = "Anenii Noi")]
        AneniiNoi,
        Balti,
        Basarabeasca,
        Biruinta,
        Briceni,
        Bucovat,
        Cahul,
        Cainari,
        Camenca,
        Cantemir,
        Causeni,
        [Display(Name = "Ceadir Lunga")]
        CeadirLunga,
        Cimislia,
        Codru,
        Comrat,
        Cornesti,
        Costesti,
        Crasnoe,
        Cricova,
        Criuleni,
        Cupcini,
        Dnestrovsc,
        Donduseni,
        Drochia,
        Dubasari,
        Durlesti,
        Edinet,
        Falesti,
        Floresti,
        Frunza,
        Ghindesti,
        Glodeni,
        Grigoriopol,
        Hincesti,
        Ialoveni,
        Iargara,
        Leova,
        Lipcani,
        Maiac,
        Marculesti,
        Nisporeni,
        Ocnita,
        Orhei,
        Otaci,
        Rezina,
        Riscani,
        Singera,
        Singerei,
        Slobozia,
        Soldanesti,
        Soroca,
        [Display(Name = "Stefan Voda")]
        StefanVoda,
        Straseni,
        Taraclia,
        Telenesti,
        Ungheni,
        [Display(Name = "Vadul Lui Voda")]
        VadulLuiVoda,
        Vatra,
        Vulcanesti
    }
}
