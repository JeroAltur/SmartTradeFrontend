using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using SmartTradeFrontend.Models;

namespace SmartTradeFrontend.Services
{
    internal class SmartTradeServices
    {
        
        public SmartTradeServices() 
        { 
            
        }

        //PaginaPrincipal
        private PaginaPrincipalController pagPrin = new PaginaPrincipalController();

        public async Task<List<Producto>> Tendencias()
        {
            List<Producto> result;
            result = await pagPrin.Tendencias();
            return result;
        }


    }
}
