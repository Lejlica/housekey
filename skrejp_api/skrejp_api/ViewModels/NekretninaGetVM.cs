using skrejp_api.Model;

namespace skrejp_api.ViewModels
{
    public class NekretninaGetVM
    {
        public int id{ get; set; }
        public string? naziv { get; set; }
        public string? cijena { get; set; }
        public string? lokacija { get; set; }
        public string? tip_akcije { get; set; }
        public decimal? kvadratura { get; set; }
        public string? tip_nekretnine { get; set; }
        public string? broj_soba { get; set; }
        //public string? detaljanOpis { get; set; }
        public string? broj_posrednickog_ugovora { get; set; }
        public string? kupatila { get; set; }
        public string? isNovogradnja { get; set; }
        public string? isKoristeno { get; set; }
        public string? sprat { get; set; }
        public string? vrsta_grijanja { get; set; }
        public string? lift { get; set; }
        public string? parking { get; set; }
        public string? garaza { get; set; }
        public string? voda { get; set; }
        public string? struja { get; set; }
        public string? kanalizacija { get; set; }
        public string? blindirana_vrata { get; set; }
        public string? Klima { get; set; }
        public string? telefonski_prikljucak { get; set; }
        public string? kablovska_tv { get; set; }
        public string? internet { get; set; }
        public string? ostava_spajz { get; set; }
        public string? uknjizeno_zk { get; set; }     
        public string? balkon { get; set; }
        public string? godina_izgradnje { get; set; }
        public List<Slike>? slike { get; set; }

    }
}
