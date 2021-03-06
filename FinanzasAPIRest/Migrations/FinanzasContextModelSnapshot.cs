// <auto-generated />
using FinanzasAPIRest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanzasAPIRest.Migrations
{
    [DbContext(typeof(FinanzasContext))]
    partial class FinanzasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinanzasAPIRest.Models.DatosBono", b =>
                {
                    b.Property<int>("IdOperacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cavali")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("Colocacion")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("Cupon")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("Estructuracion")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("Flotacion")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("GastosAdicionales")
                        .HasColumnType("decimal(10,6)");

                    b.Property<int>("IdFrecuencia")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("InflacionAnual")
                        .HasColumnType("decimal(10,6)");

                    b.Property<int>("Plazo")
                        .HasColumnType("int");

                    b.Property<decimal>("PrimaRedencion")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("TasaInteresMercado")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("ValorComercial")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("ValorNominal")
                        .HasColumnType("decimal(10,6)");

                    b.HasKey("IdOperacion");

                    b.HasIndex("IdFrecuencia");

                    b.HasIndex("IdUsuario");

                    b.ToTable("DatosBono");
                });

            modelBuilder.Entity("FinanzasAPIRest.Models.FrecuenciaPago", b =>
                {
                    b.Property<int>("IdFrecuencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreUnidad")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdFrecuencia");

                    b.ToTable("FrecuenciaPago");
                });

            modelBuilder.Entity("FinanzasAPIRest.Models.IndicadorFinanciero", b =>
                {
                    b.Property<int>("IdIndicador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdOperacion")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioBono")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("TCEA_Emisor")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("TCEA_Escudo")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("TIR_Bonista")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("TIR_Emisor")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("TIR_Escudo")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("TREA_Bonista")
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal>("VAN")
                        .HasColumnType("decimal(10,6)");

                    b.HasKey("IdIndicador");

                    b.HasIndex("IdOperacion");

                    b.ToTable("IndicadorFinanciero");
                });

            modelBuilder.Entity("FinanzasAPIRest.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nombres")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("FinanzasAPIRest.Models.DatosBono", b =>
                {
                    b.HasOne("FinanzasAPIRest.Models.FrecuenciaPago", "Frecuencia")
                        .WithMany()
                        .HasForeignKey("IdFrecuencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanzasAPIRest.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Frecuencia");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("FinanzasAPIRest.Models.IndicadorFinanciero", b =>
                {
                    b.HasOne("FinanzasAPIRest.Models.DatosBono", "Bono")
                        .WithMany()
                        .HasForeignKey("IdOperacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bono");
                });
#pragma warning restore 612, 618
        }
    }
}
