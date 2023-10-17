using skrejp_api.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace skrejp_api.ViewModels
{
    public class SlikaGetVM
    {
        public int nekretnina_id { get; set; }
        public string image { get; set; }
    }
}
