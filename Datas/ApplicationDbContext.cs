namespace gestion_commandes.Datas;

using Microsoft.EntityFrameworkCore;

using gestion_commandes.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Commande> Commandes { get; set; }

    public DbSet<Livraison> Livraisons { get; set; }

    public DbSet<Livreur> Livreurs { get; set; }

    public DbSet<Produit> Produits { get; set; }

    public DbSet<Compte> Comptes { get; set; }

    public DbSet<Utilisateur> Utilisateurs { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Paiement> Paiements { get; set; }

    public DbSet<Detail> Details { get; set; }

    public DbSet<Panier> Paniers { get; set; }

    public DbSet<PanierProduit> PanierProduits { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasMany(c => c.Commandes)
            .WithOne(cm => cm.Client)
            .HasForeignKey(cm => cm.ClientId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Commande>()
            .HasMany(cm => cm.Produits)
            .WithMany(p => p.Commandes)
            .UsingEntity<Detail>(
            d => d.HasOne(d => d.Produit).WithMany().HasForeignKey(d => d.ProduitId),
            d =>d.HasOne(d => d.Commande).WithMany().HasForeignKey(d =>d.CommandeId),
            d =>
            {
                d.ToTable("Detail");
                d.HasKey(c => c.Id);
            });
        modelBuilder.Entity<Utilisateur>()
            .HasDiscriminator<string>("Discriminator")
            .HasValue<Utilisateur>("Utilisateur")
            .HasValue<Client>("Client");

        modelBuilder.Entity<Commande>()
            .HasOne(cm =>cm.Livraison)
            .WithOne(l =>l.Commande)
            .HasForeignKey<Livraison>(l => l.CommandeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Livraison>()
            .HasOne(li => li.Livreur)
            .WithMany(l => l.Livraisons)
            .HasForeignKey(li =>li.LivreurId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Paiement>()
            .HasOne(p => p.Commande)
            .WithOne(cm => cm.Paiement)
            .HasForeignKey<Paiement>(p => p.CommandeId);

        modelBuilder.Entity<Utilisateur>()
            .HasOne(u => u.Compte)
            .WithOne(c => c.Utilisateur)
            .HasForeignKey<Utilisateur>(u =>u.CompteId);

        modelBuilder.Entity<Compte>()
            .HasOne(c =>c.Role)
            .WithMany(r =>r.Comptes)
            .HasForeignKey(u => u.RoleId);

        modelBuilder.Entity<Client>()
            .HasMany(c => c.Paniers)
            .WithOne(p => p.Client)
            .HasForeignKey(p => p.ClientId);

        modelBuilder.Entity<Panier>()
            .HasMany(p => p.Produits)
            .WithMany(pr => pr.Paniers)
            .UsingEntity<PanierProduit>(
            pp => pp.HasOne(pp => pp.Produit).WithMany().HasForeignKey(pp => pp.ProduitId),
            pp => pp.HasOne(pp => pp.Panier).WithMany().HasForeignKey(pp => pp.PanierId),
            pp =>
            {
                pp.ToTable("PanierProduit");
                pp.HasKey(pp =>pp.Id);
            }
            );


    }

}
