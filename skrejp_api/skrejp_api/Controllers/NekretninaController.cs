using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using skrejp_api.Data;
using skrejp_api.Model;
using skrejp_api.ViewModels;

namespace skrejp_api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NekretninaController : ControllerBase
    {
       

        private readonly ILogger<NekretninaController> _logger;
        public ApplicationDbContext _dbContext;

        public NekretninaController(ILogger<NekretninaController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            this._dbContext = dbContext;
        }



        //[HttpGet]
        //public async Task<ActionResult> GetAll()
        //{
        //    var data = await _dbContext.Nekretnina
        //        .Select(s => new NekretninaGetVM
        //        {
        //            id = s.ID,
        //            naziv = s.naziv,
        //            cijena = s.cijena
        //        })
        //        .ToListAsync();

        //    return Ok(data);
        //}

        [HttpGet]
        public async Task<ActionResult<NekretninaGetVM>> GetAll(int? id)
        {
            var query = _dbContext.Nekretnina.AsQueryable();
            var slike = _dbContext.Slike.Where(x => x.nekretninaID == id).ToList();

            if (id.HasValue)
            {
                query = query.Where(s => s.ID == id);
            }

            var data = await query
                .Select(s => new NekretninaGetVM
                {

                    id = s.ID,
                    naziv = s.naziv,
                    cijena = s.cijena.ToString(), // Use null-conditional operator
                    kvadratura = s.kvadratura,
                    lokacija = s.lokacija,
                    tip_akcije = s.tip_akcije,
                    tip_nekretnine = s.tip_nekretnine,
                    broj_soba = s.broj_soba,
                    //detaljanOpis = s.detaljanOpis.ToString(), // Use null-conditional operator
                    slike = _dbContext.Slike.Where(x => x.nekretninaID == s.ID).ToList(),
                    isKoristeno = s.isKoristeno,
                    isNovogradnja = s.isNovogradnja,
                    sprat = s.sprat,
                    vrsta_grijanja = s.vrsta_grijanja,
                    lift = s.lift,
                    parking = s.parking,
                    garaza = s.garaza,
                    voda = s.voda,
                    struja = s.struja,
                    kanalizacija = s.kanalizacija,
                    blindirana_vrata = s.blindirana_vrata,
                    telefonski_prikljucak = s.telefonski_prikljucak,
                    kablovska_tv = s.kablovska_tv,
                    internet = s.internet,
                    ostava_spajz = s.ostava_spajz,
                    uknjizeno_zk = s.uknjizeno_zk,
                    balkon = s.balkon,
                    godina_izgradnje = s.godina_izgradnje,
                    Klima = s.Klima,
                    kupatila = s.kupatila

                }).ToListAsync();

            data = data.GroupBy(s => s.naziv).Select(group => group.First()).Distinct().ToList();

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }

        //[HttpGet("{id}")]
        //public ActionResult GetById(int id)
        //{
        //    var data = _dbContext.Nekretnina.Where(s=>s.ID==id)
        //        .Select(s => new NekretninaGetVM
        //        {
        //            id=s.ID,
        //            naziv=s.naziv,
        //            cijena=s.cijena

        //        })
        //        .AsQueryable().Take(10).ToList();
        //    return Ok(data);
        //}

    }
}