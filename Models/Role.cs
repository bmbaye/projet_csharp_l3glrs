using System.ComponentModel.DataAnnotations;

namespace gestion_commandes.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required()]
        public string RoleName { get; set; }

        public ICollection<Compte> Comptes { get; set; }


    }
}
