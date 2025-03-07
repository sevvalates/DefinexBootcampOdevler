using AttributeClassLibrary;
using AttributeOgrenciKayitWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttributeOgrenciKayitWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostOgrenci([FromBody] Ogrenci ogrenci)
        {
            
            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                return BadRequest(new { Message = "Eksik veya geçersiz alanlar var!" });
            }

            return Ok(new { Message = "Öğrenci başarıyla kaydedildi!", Data = ogrenci });
        }
    }
}
