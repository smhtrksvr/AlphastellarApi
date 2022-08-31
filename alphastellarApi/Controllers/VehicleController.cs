using alphastellarApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alphastellarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private bool CheckParameter(VehiclePost vehiclePost)
        {
            if (vehiclePost.SecilenAracSayisi <= 0) return false;

            //foreach (var item in vehiclePost.Depo.Araclar)
            //{
            //    if (item.AracAdedi <= 0) return false;
            //}
            return true;
        }

        [HttpPost]
        public VehicleGet Index(VehiclePost vehiclePost)
        {
            if (!CheckParameter(vehiclePost))
            {
                return (new VehicleGet()
                {
                    AracSecilebilir = false,
                    Arac = new List<Ozellik>()

                });
            };


            var araclar = vehiclePost.Depo.Araclar;

            var olumlu = false;
            int farklıArac = vehiclePost.SecilenAracSayisi;
            var secilenAraclar = new List<Ozellik>();
            int parameterArac = 0;
            foreach (var arac in araclar)
            {

                if (parameterArac < farklıArac)
                {
                    secilenAraclar.Add(new Ozellik {
                        AracAdi = arac.Aracturu,
                        AracId = arac.Id,
                        FarlarVar = arac.Farlar,
                        Farlaracik = arac.FarlarAcik,
                        TekerlekVar = arac.Tekerlek,
                        AracRengi = arac.Renk
                    });
                    parameterArac++;
                }


            }
            if (farklıArac == parameterArac)
            {
                return (new VehicleGet()
                {
                    AracSecilebilir = true,
                    Arac = secilenAraclar
                });
            }
            if (!olumlu)
            {
                return (new VehicleGet()
                {
                    AracSecilebilir = true,
                    Arac = new List<Ozellik>()
                });
            }

        
            
            return (new VehicleGet()
        {
            AracSecilebilir = false,
                Arac = new List<Ozellik>()
            });
        }
    }
}
