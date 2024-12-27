namespace gestion_commandes.Fixtures;
using gestion_commandes.Datas;
using gestion_commandes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
public class ClientFixtures
{
    private readonly ApplicationDbContext _context;
    private readonly PasswordHasher<Object> _passwordHasher;

    public ClientFixtures(ApplicationDbContext context)
    {
        _context = context;
        _passwordHasher = new PasswordHasher<object>();

    }

    public void Load()
    {
        var roleClient = _context.Roles.FirstOrDefault(r => r.RoleName == "CLIENT");

        if(roleClient == null)
        {
            roleClient = new Role { RoleName = "CLIENT" };
            _context.Roles.Add(roleClient);
            _context.SaveChanges();
        }
        if (!_context.Clients.Any())
        {

            _context.Clients.AddRange(
                new Client
                {
                    Nom = "xxx1",
                    Prenom = "yyy1",
                    Telephone = "778965412",
                    Adresse = "21 rue Ave Ch. Anta Diop",
                    Compte = new Compte
                    {
                        Login = "xxx1@gmail.com",
                        Password = _passwordHasher.HashPassword(null, "xxx1pass"),
                        Role = roleClient
                    }
                },
                new Client
                {
                    Nom = "xxx2",
                    Prenom = "yyy2",
                    Telephone = "778965422",
                    Adresse = "21 rue Ave Ch. Anta Diop",
                    Compte = new Compte
                    {
                        Login = "xxx2@gmail.com",
                        Password = _passwordHasher.HashPassword(null, "xxx2pass"),
                        Role = roleClient

                    }
                },
                new Client
                {
                    Nom = "xxx3",
                    Prenom = "yyy3",
                    Telephone = "778965412",
                    Adresse = "21 rue Ave Ch. Anta Diop",
                    Compte = new Compte
                    {
                        Login = "xxx3@gmail.com",
                        Password = _passwordHasher.HashPassword(null, "xxx3pass"),
                        Role = roleClient
                    }
                }
             );

            _context.SaveChanges();
        }
    }
}
