﻿using BAL_IK.Data.Interfaceler.Personeller;
using BAL_IK.Model.RequestClass;
using BAL_IK.Model.ResponseClass;
using RestSharp;
using static BAL_IK.Model.ResponseClass.PersonelIslemleriResponse;

namespace BAL_IK.UI.ServislerUI
{
    public class PersonelServisUI : IPersonellerServis
    {
        public PersonelHarcamaEkle HarcamaEkleme(PersonelIslemleriRequest.HarcamaEkle pr)
        {
            var request = new RestRequest("api/Personel/HarcamaEkleme", Method.POST, DataFormat.Json).AddJsonBody(pr);
            var response = Globals.ApiClient.Execute<PersonelHarcamaEkle>(request);
            return response.Data;
        }

        public HarcamaListelemeResponse HarcamalarıGetir()
        {
            var request = new RestRequest("api/Personel/HarcamalarıGetir", Method.GET, DataFormat.Json);
            var response= Globals.ApiClient.Execute<HarcamaListelemeResponse>(request);
            return response.Data;
        }

       
        public IzinlerResponse IzinleriGetir(string guid)
        {
            var request = new RestRequest("api/Personel/IzinleriGetir", Method.GET, DataFormat.Json).AddParameter("guid", guid);
            var response = Globals.ApiClient.Execute<IzinlerResponse>(request);

            return response.Data;
        }

      

        public PersonelIslemleriResponse.PersonelEkleResponse PersonelEkleme(PersonelIslemleriRequest.PersonelEkle pr)
        {
            var request = new RestRequest("api/Personel/PersonelEkleme",Method.POST,DataFormat.Json).AddJsonBody(pr);
            var response = Globals.ApiClient.Execute<PersonelEkleResponse>(request);
            return response.Data;
        }

        public PersonelIslemleriResponse.PersonelResp PersonelGetir(string guid)
        {
            var request = new RestRequest("api/Personel/PersonelGetir", Method.GET, DataFormat.Json).AddParameter("guid",guid);
            var response = Globals.ApiClient.Execute<PersonelResp>(request);

                return response.Data;
        }

        public PersonelIslemleriResponse.PersonelGuncelleResponse PersonelGuncelleme(PersonelIslemleriRequest.PersonelGuncelle pr)
        {
            var request = new RestRequest("api/Personel/PersonelGuncelleme", Method.POST, DataFormat.Json).AddJsonBody(pr);
            var response = Globals.ApiClient.Execute<PersonelGuncelleResponse>(request);
            return response.Data;
        }

        public PersonelIslemleriResponse.PersonelListelemeResponse PersonelListeleme()
        {
            throw new System.NotImplementedException();
        }

        public VardiyalarResponse VardiyalariGetir(string guid)
        {
            var request = new RestRequest("api/Personel/VardiyalariGetir", Method.GET, DataFormat.Json).AddParameter("guid", guid);
            var response = Globals.ApiClient.Execute<VardiyalarResponse>(request);

            return response.Data;
        }
        public MolalarResponse MolalariGetir(string guid)
        {
            var request = new RestRequest("api/Personel/MolalariGetir", Method.GET, DataFormat.Json).AddParameter("guid", guid);
            var response = Globals.ApiClient.Execute<MolalarResponse>(request);

            return response.Data;
        }

        public EkleizinResponse Ekleizin(PersonelIslemleriRequest.Ekleizin izinEkle)
        {
            
            var request = new RestRequest("api/Personel/IzinEkle", Method.POST, DataFormat.Json).AddJsonBody(izinEkle);
            var response = Globals.ApiClient.Execute<EkleizinResponse>(request);
            return response.Data;
        }

        public IzinTurlerResponse IzinTurleriGetir()
        {

            var request = new RestRequest("api/Personel/IzinTurleriGetir", Method.GET, DataFormat.Json);
            var response = Globals.ApiClient.Execute<IzinTurlerResponse>(request);
            return response.Data;
        }

        public ZimmetlerResponse ZimmetTurleriGetir(string guid)
        {
            var request = new RestRequest("api/Personel/ZimmetTurleriGetir", Method.GET, DataFormat.Json).AddParameter("guid", guid);
            var response = Globals.ApiClient.Execute<ZimmetlerResponse>(request);

            return response.Data;
        }
    }
}
