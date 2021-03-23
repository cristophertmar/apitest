using APITests.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> login_get(string usuario, string contrasenia)
        {
            if (usuario != "75680923")
            {
                return StatusCode(500, $"No se pudo ingresar, Usuario No existe");
            } 
            else if (usuario != "75680923" || contrasenia != "mtclima2020$")
            {
                return StatusCode(500, $"No se pudo ingresar, Usuario / Clave no validos");
            }
            else
            {
                return Ok(new
                {
                    IdUsuario = 105534,
                    Codigo = "70452921",
                    Correo = "ODTD_temp006@mtc.gob.pe",
                    NombreCompleto = "CARASAS CURAY WALTER RUBEN JUNIOR",
                    AccessToken = "YLphCICtCeNn6v/pJb4f0NSJn5LbDCn+uPr8pOuoz5XqkqtMVXY160G1J0J2dBIE",
                    Empresa = new
                    {
                        IdEmpresa = 105532,
                        NombreCentro = "-",
                        Locales = (string)null
                    },
                    EmpresaLocal = new
                    {
                        IdLocal = 6822,
                        CodigoLocal = 0,
                        NombreLocal = "LOCAL LURIGANCHO"
                    },
                    Roles = new[] {
                    new
                    {
                       IdRol = 1145,
                       NombreRol = "MTC_Desguace",
                       Menus = new [] {
                            new
                            {
                                IdMenu = 3895,
                                Nombre = "Desguace",
                                Direccion = "#"
                            }
                       }
                    }
                }
                });
            }

            

        }

        [HttpPost]
        public async Task<IActionResult> login_proveedor([FromBody] UsuarioPost usuario)
        {
            if (usuario.Usuario != "75680923")
            {
                return StatusCode(500, $"No se pudo ingresar, Usuario No existe");
            }
            else if (usuario.Usuario != "75680923" || usuario.Contrasenia != "mtclima2020$")
            {
                return StatusCode(500, $"No se pudo ingresar, Usuario / Clave no validos");
            }
            else
            {
                return Ok(new
                {
                    IdUsuario = 105534,
                    Codigo = "70452921",
                    Correo = "ODTD_temp006@mtc.gob.pe",
                    NombreCompleto = "CARASAS CURAY WALTER RUBEN JUNIOR",
                    AccessToken = "YLphCICtCeNn6v/pJb4f0NSJn5LbDCn+uPr8pOuoz5XqkqtMVXY160G1J0J2dBIE",
                    Empresa = new
                    {
                        IdEmpresa = 105532,
                        NombreCentro = "-",
                        Locales = (string)null
                    },
                    EmpresaLocal = new
                    {
                        IdLocal = 6822,
                        CodigoLocal = 0,
                        NombreLocal = "LOCAL LURIGANCHO"
                    },
                    Roles = new[] {
                    new
                    {
                       IdRol = 1145,
                       NombreRol = "MTC_Desguace",
                       Menus = new [] {
                            new
                            {
                                IdMenu = 3895,
                                Nombre = "Desguace",
                                Direccion = "#"
                            }
                       }
                    }
                }
                });
            }

            

        }






    }
}
