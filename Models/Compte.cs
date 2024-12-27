namespace gestion_commandes.Models
{
    public class Compte
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public  Role Role { get; set; }

        public int RoleId { get; set; }

        public Utilisateur Utilisateur { get; set; }


    }
}
