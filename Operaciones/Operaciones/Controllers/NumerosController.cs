using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Operaciones.Controllers
{
    
    public class NumerosController : ApiController
    {
        [HttpGet]
        public Numero operaciones(int num)
        {

            if (num < 0)
            {
                Numero palabra = new Numero()
                {
                    numero = num,
                    frase = "ERROR"

                };
                return palabra;

            }
            else
            {
                if (num == 0)
                {
                    Numero palabra = new Numero()
                    {
                        numero = num,
                        frase = "Realizado por Angelica Isabel Cladera Melgar"
                    };
                    return palabra;
                }
                else
                {
                    Numero palabra = new Numero()
                    {
                        numero = num,
                        frase = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg"
                    };
                    return palabra;
                }


            }
             
        }

    }
    
}
