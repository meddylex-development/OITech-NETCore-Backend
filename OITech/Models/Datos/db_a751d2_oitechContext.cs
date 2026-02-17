using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class OITechContext : DbContext
    {
        public OITechContext()
        {
        }

        public OITechContext(DbContextOptions<OITechContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditTrack> AuditTracks { get; set; }
        public virtual DbSet<DataJson> DataJsons { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuProfile> MenuProfiles { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<TblBarrio> TblBarrios { get; set; }
        public virtual DbSet<TblCalificacion> TblCalificacions { get; set; }
        public virtual DbSet<TblDane> TblDanes { get; set; }
        public virtual DbSet<TblGeocodificador> TblGeocodificadors { get; set; }
        public virtual DbSet<TblGestor> TblGestors { get; set; }
        public virtual DbSet<TblMultivalore> TblMultivalores { get; set; }
        public virtual DbSet<TblPredio> TblPredios { get; set; }
        public virtual DbSet<TblTerritorio> TblTerritorios { get; set; }
        public virtual DbSet<TblTerritorioCoordenada> TblTerritorioCoordenadas { get; set; }
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }
        public virtual DbSet<TblavaluoCatastralIntegralPh> TblavaluoCatastralIntegralPhs { get; set; }
        public virtual DbSet<TblavaluoCatastralTerrenoNph> TblavaluoCatastralTerrenoNphs { get; set; }
        public virtual DbSet<TblavaluoComercialIntegralPh> TblavaluoComercialIntegralPhs { get; set; }
        public virtual DbSet<TblavaluoComercialTerrenoNph> TblavaluoComercialTerrenoNphs { get; set; }
        public virtual DbSet<Tblconstruccion> Tblconstruccions { get; set; }
        public virtual DbSet<Tbllote> Tbllotes { get; set; }
        public virtual DbSet<TblloteEstratoSocioeconomico> TblloteEstratoSocioeconomicos { get; set; }
        public virtual DbSet<TbllotePredio> TbllotePredios { get; set; }
        public virtual DbSet<TblloteUso> TblloteUsos { get; set; }
        public virtual DbSet<Tblpredio1> Tblpredios1 { get; set; }
        public virtual DbSet<Tblterreno> Tblterrenos { get; set; }
        public virtual DbSet<Tblunidad> Tblunidads { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=sql5105.site4now.net;Initial Catalog=db_a751d2_oitech;Persist Security Info=True;User ID=db_a751d2_oitech_admin;Password=OITech123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AuditTrack>(entity =>
            {
                entity.ToTable("auditTrack", "Seguridad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateUpdated");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module");
            });

            modelBuilder.Entity<DataJson>(entity =>
            {
                entity.HasKey(e => e.DataId);

                entity.ToTable("DataJson", "Admin");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu", "Seguridad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateUpdated");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Home).HasColumnName("home");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.Link).HasColumnName("link");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<MenuProfile>(entity =>
            {
                entity.ToTable("menuProfile", "Seguridad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateUpdated");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdMenu).HasColumnName("idMenu");

                entity.Property(e => e.IdProfile).HasColumnName("idProfile");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("profile", "Seguridad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateUpdated");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status", "Seguridad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateUpdated");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblBarrio>(entity =>
            {
                entity.HasKey(e => e.Objectid);

                entity.ToTable("tblBarrio", "Admin");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Barrio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("barrio");

                entity.Property(e => e.CodigoBarrio)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("codigo_barrio");

                entity.Property(e => e.Comuna)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Dptompio)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("DPTOMPIO");

                entity.Property(e => e.IdBarrio)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("id_barrio");

                entity.Property(e => e.NombreBarrio)
                    .IsRequired()
                    .HasColumnName("nombre_barrio");

                entity.Property(e => e.NombreComuna)
                    .IsRequired()
                    .HasColumnName("Nombre_comuna");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("zona");

                entity.Property(e => e.ZonaBarrio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("zona_barrio");
            });

            modelBuilder.Entity<TblCalificacion>(entity =>
            {
                entity.HasKey(e => e.IIdCalificacion)
                    .HasName("PK_tblCalificacion_iIdCalificacion")
                    .IsClustered(false);

                entity.ToTable("tblCalificacion", "Admin");

                entity.Property(e => e.IIdCalificacion).HasColumnName("iIdCalificacion");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblDane>(entity =>
            {
                entity.HasKey(e => e.IIdDane)
                    .HasName("PK_Dane_iIdDane")
                    .IsClustered(false);

                entity.ToTable("tblDane", "Admin");

                entity.Property(e => e.IIdDane).HasColumnName("iIdDane");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CodDepartamento).HasColumnName("cod_departamento");

                entity.Property(e => e.CodMunicipio).HasColumnName("Cod_municipio");

                entity.Property(e => e.Departamento).HasColumnName("departamento");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Municipio).HasColumnName("municipio");

                entity.Property(e => e.UpdateDate).HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblGeocodificador>(entity =>
            {
                entity.HasKey(e => e.IIdGeocodificador)
                    .HasName("PK_Ideca_iIdGeocodificador")
                    .IsClustered(false);

                entity.ToTable("tblGeocodificador", "Ideca");

                entity.Property(e => e.IIdGeocodificador).HasColumnName("iIdGeocodificador");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Codloc).HasColumnName("codloc");

                entity.Property(e => e.Codseccat).HasColumnName("codseccat");

                entity.Property(e => e.Codupz).HasColumnName("codupz");

                entity.Property(e => e.Cpocodigo).HasColumnName("cpocodigo");

                entity.Property(e => e.Diraprox).HasColumnName("diraprox");

                entity.Property(e => e.Dirinput).HasColumnName("dirinput");

                entity.Property(e => e.Dirtrad).HasColumnName("dirtrad");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Localidad).HasColumnName("localidad");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Lotcodigo).HasColumnName("lotcodigo");

                entity.Property(e => e.Mancodigo).HasColumnName("mancodigo");

                entity.Property(e => e.Nomseccat).HasColumnName("nomseccat");

                entity.Property(e => e.Nomupz).HasColumnName("nomupz");

                entity.Property(e => e.TipoDireccion).HasColumnName("tipo_direccion");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");

                entity.Property(e => e.Xinput).HasColumnName("xinput");

                entity.Property(e => e.Yinput).HasColumnName("yinput");
            });

            modelBuilder.Entity<TblGestor>(entity =>
            {
                entity.HasKey(e => e.UniIdgestor)
                    .HasName("PK_IGAC.tblGestor");

                entity.ToTable("tblGestor", "IGAC");

                entity.Property(e => e.UniIdgestor).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FlofechaContrato).HasColumnName("Flofecha_contrato");

                entity.Property(e => e.Intobjectid1).HasColumnName("Intobjectid_1");

                entity.Property(e => e.NvaShapeArea).HasColumnName("NvaShape__Area");

                entity.Property(e => e.NvaShapeLength).HasColumnName("NvaShape__Length");

                entity.Property(e => e.NvaactoAdmin).HasColumnName("Nvaacto_admin");

                entity.Property(e => e.NvaestadoActual).HasColumnName("Nvaestado_actual");

                entity.Property(e => e.NvagestorCatastral).HasColumnName("Nvagestor_catastral");

                entity.Property(e => e.NvagestorContrato).HasColumnName("Nvagestor_contrato");

                entity.Property(e => e.NvaidGc).HasColumnName("Nvaid_gc");

                entity.Property(e => e.NvashapeLeng).HasColumnName("Nvashape_leng");

                entity.Property(e => e.NvaurlHabilitacion).HasColumnName("Nvaurl_habilitacion");

                entity.Property(e => e.NvaurlServicio).HasColumnName("Nvaurl_servicio");
            });

            modelBuilder.Entity<TblMultivalore>(entity =>
            {
                entity.HasKey(e => e.IIdMultivalores)
                    .HasName("PK_tblMultivalores_iIdMultivalores")
                    .IsClustered(false);

                entity.ToTable("tblMultivalores", "Admin");

                entity.Property(e => e.IIdMultivalores).HasColumnName("iIdMultivalores");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CodAgrupador).HasColumnName("cod_agrupador");

                entity.Property(e => e.CodItem).HasColumnName("cod_item");

                entity.Property(e => e.CodItemstring).HasColumnName("cod_itemstring");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Maximo).HasColumnName("maximo");

                entity.Property(e => e.Minimo).HasColumnName("minimo");

                entity.Property(e => e.NombreAgrupador).HasColumnName("nombre_agrupador");

                entity.Property(e => e.NombreItem).HasColumnName("nombre_item");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblPredio>(entity =>
            {
                entity.HasKey(e => e.IIdPredio)
                    .HasName("PK_tblPredio_iIdPredio")
                    .IsClustered(false);

                entity.ToTable("tblPredio", "Ideca");

                entity.Property(e => e.IIdPredio).HasColumnName("iIdPredio");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Barmanpre).HasColumnName("BARMANPRE");

                entity.Property(e => e.IIdGeocodificador).HasColumnName("iIdGeocodificador");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Preacercha).HasColumnName("PREACERCHA");

                entity.Property(e => e.Preacons).HasColumnName("PREACONS");

                entity.Property(e => e.Preaconst)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("PREACONST");

                entity.Property(e => e.Preacubier).HasColumnName("PREACUBIER");

                entity.Property(e => e.Preafachad).HasColumnName("PREAFACHAD");

                entity.Property(e => e.Preapisos).HasColumnName("PREAPISOS");

                entity.Property(e => e.Preaterre)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("PREATERRE");

                entity.Property(e => e.Preauso)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("PREAUSO");

                entity.Property(e => e.Prebcons).HasColumnName("PREBCONS");

                entity.Property(e => e.Prebenchap).HasColumnName("PREBENCHAP");

                entity.Property(e => e.Prebmobili).HasColumnName("PREBMOBILI");

                entity.Property(e => e.Prebtamano).HasColumnName("PREBTAMANO");

                entity.Property(e => e.Precbarrio).HasColumnName("PRECBARRIO");

                entity.Property(e => e.Preccons).HasColumnName("PRECCONS");

                entity.Property(e => e.Precconse).HasColumnName("PRECCONSE");

                entity.Property(e => e.Precdestin).HasColumnName("PRECDESTIN");

                entity.Property(e => e.Precedcata).HasColumnName("PRECEDCATA");

                entity.Property(e => e.Precenchap).HasColumnName("PRECENCHAP");

                entity.Property(e => e.Prechip).HasColumnName("PRECHIP");

                entity.Property(e => e.Precindus).HasColumnName("PRECINDUS");

                entity.Property(e => e.Preclase).HasColumnName("PRECLASE");

                entity.Property(e => e.Preclcons).HasColumnName("PRECLCONS");

                entity.Property(e => e.Precmanz).HasColumnName("PRECMANZ");

                entity.Property(e => e.Precmobili).HasColumnName("PRECMOBILI");

                entity.Property(e => e.Precpredio).HasColumnName("PRECPREDIO");

                entity.Property(e => e.Precresto).HasColumnName("PRECRESTO");

                entity.Property(e => e.Prectamano).HasColumnName("PRECTAMANO");

                entity.Property(e => e.Precuso).HasColumnName("PRECUSO");

                entity.Property(e => e.Preczhf).HasColumnName("PRECZHF");

                entity.Property(e => e.Predirecc).HasColumnName("PREDIRECC");

                entity.Property(e => e.Predsi).HasColumnName("PREDSI");

                entity.Property(e => e.Preearmaz).HasColumnName("PREEARMAZ");

                entity.Property(e => e.Preecons).HasColumnName("PREECONS");

                entity.Property(e => e.Preecubier).HasColumnName("PREECUBIER");

                entity.Property(e => e.Preemuros).HasColumnName("PREEMUROS");

                entity.Property(e => e.Prefcalif).HasColumnName("PREFCALIF");

                entity.Property(e => e.Prefincorp).HasColumnName("PREFINCORP");

                entity.Property(e => e.Premdirecc).HasColumnName("PREMDIRECC");

                entity.Property(e => e.Prenbarrio).HasColumnName("PRENBARRIO");

                entity.Property(e => e.Prenupre).HasColumnName("PRENUPRE");

                entity.Property(e => e.Prepuntaje).HasColumnName("PREPUNTAJE");

                entity.Property(e => e.Pretdirecc).HasColumnName("PRETDIRECC");

                entity.Property(e => e.Pretprop).HasColumnName("PRETPROP");

                entity.Property(e => e.Preucalif).HasColumnName("PREUCALIF");

                entity.Property(e => e.Preusonph).HasColumnName("PREUSONPH");

                entity.Property(e => e.Preusoph).HasColumnName("PREUSOPH");

                entity.Property(e => e.Preuvivien).HasColumnName("PREUVIVIEN");

                entity.Property(e => e.Prevactual).HasColumnName("PREVACTUAL");

                entity.Property(e => e.Prevetustz).HasColumnName("PREVETUSTZ");

                entity.Property(e => e.Prevforma).HasColumnName("PREVFORMA");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblTerritorio>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("PK_Admin.tblTerritorio");

                entity.ToTable("tblTerritorio", "Admin");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.AreaHa).HasColumnName("AREA_HA");

                entity.Property(e => e.CodDpto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("COD_DPTO");

                entity.Property(e => e.CodigoVer)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("CODIGO_VER");

                entity.Property(e => e.Descripcio).HasColumnName("DESCRIPCIO");

                entity.Property(e => e.Dptompio)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("DPTOMPIO");

                entity.Property(e => e.Fuente)
                    .IsRequired()
                    .HasColumnName("FUENTE");

                entity.Property(e => e.NomDep)
                    .IsRequired()
                    .HasColumnName("NOM_DEP");

                entity.Property(e => e.NombMpio)
                    .IsRequired()
                    .HasColumnName("NOMB_MPIO");

                entity.Property(e => e.NombreVer)
                    .IsRequired()
                    .HasColumnName("NOMBRE_VER");

                entity.Property(e => e.Seudonimos).HasColumnName("SEUDONIMOS");

                entity.Property(e => e.ShapeStarea).HasColumnName("Shape_STArea");

                entity.Property(e => e.ShapeStlength).HasColumnName("Shape_STLength");

                entity.Property(e => e.Vigencia)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("VIGENCIA");
            });

            modelBuilder.Entity<TblTerritorioCoordenada>(entity =>
            {
                entity.HasKey(e => e.CoordenadasId)
                    .HasName("PK_Admin.tblTerritorioCoordenadas");

                entity.ToTable("tblTerritorioCoordenadas", "Admin");

                entity.Property(e => e.CoordenadasId).HasColumnName("CoordenadasID");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.X).IsRequired();

                entity.Property(e => e.Y).IsRequired();

                entity.Property(e => e.Z).IsRequired();
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK_Usuario_idUsuario")
                    .IsClustered(false);

                entity.ToTable("tblUsuario", "Administracion");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FechaInsercion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TblavaluoCatastralIntegralPh>(entity =>
            {
                entity.HasKey(e => e.IIdavaluoCatastralIntegralPh)
                    .HasName("PK_avaluoCatastralIntegralPH_iIdavaluoCatastralIntegralPH")
                    .IsClustered(false);

                entity.ToTable("tblavaluoCatastralIntegralPH", "catastro");

                entity.Property(e => e.IIdavaluoCatastralIntegralPh).HasColumnName("iIdavaluoCatastralIntegralPH");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.AvaluoCatMz).HasColumnName("AVALUO_CAT_MZ");

                entity.Property(e => e.CpTerrArea).HasColumnName("CP_TERR_AREA");

                entity.Property(e => e.Globalid).HasColumnName("GLOBALID");

                entity.Property(e => e.GrupopTerrArea).HasColumnName("GRUPOP_TERR_AREA");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Len).HasColumnName("LEN");

                entity.Property(e => e.ManzanaId).HasColumnName("MANZANA_ID");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observacion).HasColumnName("OBSERVACION");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.Shape).HasColumnName("SHAPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblavaluoCatastralTerrenoNph>(entity =>
            {
                entity.HasKey(e => e.IIdavaluoCatastralTerrenoNph)
                    .HasName("PK_avaluoCatastralTerrenoNPH_iIdavaluoCatastralTerrenoNPH")
                    .IsClustered(false);

                entity.ToTable("tblavaluoCatastralTerrenoNPH", "catastro");

                entity.Property(e => e.IIdavaluoCatastralTerrenoNph).HasColumnName("iIdavaluoCatastralTerrenoNPH");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.AvaluoCatMz).HasColumnName("AVALUO_CAT_MZ");

                entity.Property(e => e.CpTerrArea).HasColumnName("CP_TERR_AREA");

                entity.Property(e => e.Globalid).HasColumnName("GLOBALID");

                entity.Property(e => e.GrupopTerrArea).HasColumnName("GRUPOP_TERR_AREA");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Len).HasColumnName("LEN");

                entity.Property(e => e.ManzanaId).HasColumnName("MANZANA_ID");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observacion).HasColumnName("OBSERVACION");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.Shape).HasColumnName("SHAPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblavaluoComercialIntegralPh>(entity =>
            {
                entity.HasKey(e => e.IIdavaluoComercialIntegralPh)
                    .HasName("PK_avaluoComercialIntegralPH_iIdavaluoComercialIntegralPH")
                    .IsClustered(false);

                entity.ToTable("tblavaluoComercialIntegralPH", "catastro");

                entity.Property(e => e.IIdavaluoComercialIntegralPh).HasColumnName("iIdavaluoComercialIntegralPH");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.AvaluoComMz).HasColumnName("AVALUO_COM_MZ");

                entity.Property(e => e.CpTerrArea).HasColumnName("CP_TERR_AREA");

                entity.Property(e => e.Globalid).HasColumnName("GLOBALID");

                entity.Property(e => e.GrupopTerrArea).HasColumnName("GRUPOP_TERR_AREA");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Len).HasColumnName("LEN");

                entity.Property(e => e.ManzanaId).HasColumnName("MANZANA_ID");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observacion).HasColumnName("OBSERVACION");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.Shape).HasColumnName("SHAPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblavaluoComercialTerrenoNph>(entity =>
            {
                entity.HasKey(e => e.IIdavaluoComercialTerrenoNph)
                    .HasName("PK_avaluoComercialTerrenoNPH_iIdavaluoComercialTerrenoNPH")
                    .IsClustered(false);

                entity.ToTable("tblavaluoComercialTerrenoNPH", "catastro");

                entity.Property(e => e.IIdavaluoComercialTerrenoNph).HasColumnName("iIdavaluoComercialTerrenoNPH");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.AvaluoComMz).HasColumnName("AVALUO_COM_MZ");

                entity.Property(e => e.CpTerrArea).HasColumnName("CP_TERR_AREA");

                entity.Property(e => e.Globalid).HasColumnName("GLOBALID");

                entity.Property(e => e.GrupopTerrArea).HasColumnName("GRUPOP_TERR_AREA");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Len).HasColumnName("LEN");

                entity.Property(e => e.ManzanaId).HasColumnName("MANZANA_ID");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observacion).HasColumnName("OBSERVACION");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.Shape).HasColumnName("SHAPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<Tblconstruccion>(entity =>
            {
                entity.HasKey(e => e.UniIdconstruccion)
                    .HasName("PK__tblconst__61554937C3F78732");

                entity.ToTable("tblconstruccion", "IGAC");

                entity.Property(e => e.UniIdconstruccion)
                    .HasColumnName("uniIdconstruccion")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FloFechaInsercion).HasColumnName("floFechaInsercion");

                entity.Property(e => e.FloFechaModificacion).HasColumnName("floFechaModificacion");

                entity.Property(e => e.Floarea).HasColumnName("floarea");

                entity.Property(e => e.IntActivo).HasColumnName("intActivo");

                entity.Property(e => e.IntnumBanos).HasColumnName("intnumBanos");

                entity.Property(e => e.IntnumHabitaciones).HasColumnName("intnumHabitaciones");

                entity.Property(e => e.IntnumLocales).HasColumnName("intnumLocales");

                entity.Property(e => e.IntnumPisos).HasColumnName("intnumPisos");

                entity.Property(e => e.Intpuntaje).HasColumnName("intpuntaje");

                entity.Property(e => e.Intuso).HasColumnName("intuso");

                entity.Property(e => e.NvaObservacion).HasColumnName("nvaObservacion");

                entity.Property(e => e.UniUsuarioInsercion).HasColumnName("uniUsuarioInsercion");

                entity.Property(e => e.UniUsuarioModificacion).HasColumnName("uniUsuarioModificacion");

                entity.Property(e => e.Unipredio).HasColumnName("unipredio");
            });

            modelBuilder.Entity<Tbllote>(entity =>
            {
                entity.HasKey(e => e.IIdlote)
                    .HasName("PK_lote_iIdlote")
                    .IsClustered(false);

                entity.ToTable("tbllote", "catastro");

                entity.Property(e => e.IIdlote).HasColumnName("iIdlote");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Globalid).HasColumnName("GLOBALID");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Lotcodigo).HasColumnName("LOTCODIGO");

                entity.Property(e => e.Lotdispers).HasColumnName("LOTDISPERS");

                entity.Property(e => e.Lotdistrit).HasColumnName("LOTDISTRIT");

                entity.Property(e => e.Lotildispe).HasColumnName("LOTILDISPE");

                entity.Property(e => e.Lotupredia).HasColumnName("LOTUPREDIA");

                entity.Property(e => e.Manzcodigo).HasColumnName("MANZCODIGO");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.Shape).HasColumnName("SHAPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblloteEstratoSocioeconomico>(entity =>
            {
                entity.HasKey(e => e.IIdloteEstratoSocioeconomico)
                    .HasName("PK_loteEstratoSocioeconomico_iIdloteEstratoSocioeconomico")
                    .IsClustered(false);

                entity.ToTable("tblloteEstratoSocioeconomico", "catastro");

                entity.Property(e => e.IIdloteEstratoSocioeconomico).HasColumnName("iIdloteEstratoSocioeconomico");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Esochip).HasColumnName("ESOCHIP");

                entity.Property(e => e.Esoclote).HasColumnName("ESOCLOTE");

                entity.Property(e => e.Esoestrato).HasColumnName("ESOESTRATO");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TbllotePredio>(entity =>
            {
                entity.HasKey(e => e.IIdlotePredio)
                    .HasName("PK_lotePredio_iIdlotePredio")
                    .IsClustered(false);

                entity.ToTable("tbllotePredio", "catastro");

                entity.Property(e => e.IIdlotePredio).HasColumnName("iIdlotePredio");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Barmanpre).HasColumnName("BARMANPRE");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.Preacercha).HasColumnName("PREACERCHA");

                entity.Property(e => e.Preacons).HasColumnName("PREACONS");

                entity.Property(e => e.Preaconst)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("PREACONST");

                entity.Property(e => e.Preacubier).HasColumnName("PREACUBIER");

                entity.Property(e => e.Preafachad).HasColumnName("PREAFACHAD");

                entity.Property(e => e.Preapisos).HasColumnName("PREAPISOS");

                entity.Property(e => e.Preaterre)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("PREATERRE");

                entity.Property(e => e.Preauso)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("PREAUSO");

                entity.Property(e => e.Prebcons).HasColumnName("PREBCONS");

                entity.Property(e => e.Prebenchap).HasColumnName("PREBENCHAP");

                entity.Property(e => e.Prebmobili).HasColumnName("PREBMOBILI");

                entity.Property(e => e.Prebtamano).HasColumnName("PREBTAMANO");

                entity.Property(e => e.Precbarrio).HasColumnName("PRECBARRIO");

                entity.Property(e => e.Preccons).HasColumnName("PRECCONS");

                entity.Property(e => e.Precconse).HasColumnName("PRECCONSE");

                entity.Property(e => e.Precdestin).HasColumnName("PRECDESTIN");

                entity.Property(e => e.Precedcata).HasColumnName("PRECEDCATA");

                entity.Property(e => e.Precenchap).HasColumnName("PRECENCHAP");

                entity.Property(e => e.Prechip).HasColumnName("PRECHIP");

                entity.Property(e => e.Precindus).HasColumnName("PRECINDUS");

                entity.Property(e => e.Preclase).HasColumnName("PRECLASE");

                entity.Property(e => e.Preclcons).HasColumnName("PRECLCONS");

                entity.Property(e => e.Precmanz).HasColumnName("PRECMANZ");

                entity.Property(e => e.Precmobili).HasColumnName("PRECMOBILI");

                entity.Property(e => e.Precpredio).HasColumnName("PRECPREDIO");

                entity.Property(e => e.Precresto).HasColumnName("PRECRESTO");

                entity.Property(e => e.Prectamano).HasColumnName("PRECTAMANO");

                entity.Property(e => e.Precuso).HasColumnName("PRECUSO");

                entity.Property(e => e.Preczhf).HasColumnName("PRECZHF");

                entity.Property(e => e.Predirecc).HasColumnName("PREDIRECC");

                entity.Property(e => e.Predsi).HasColumnName("PREDSI");

                entity.Property(e => e.Preearmaz).HasColumnName("PREEARMAZ");

                entity.Property(e => e.Preecons).HasColumnName("PREECONS");

                entity.Property(e => e.Preecubier).HasColumnName("PREECUBIER");

                entity.Property(e => e.Preemuros).HasColumnName("PREEMUROS");

                entity.Property(e => e.Prefcalif).HasColumnName("PREFCALIF");

                entity.Property(e => e.Prefincorp).HasColumnName("PREFINCORP");

                entity.Property(e => e.Premdirecc).HasColumnName("PREMDIRECC");

                entity.Property(e => e.Prenbarrio).HasColumnName("PRENBARRIO");

                entity.Property(e => e.Prenupre).HasColumnName("PRENUPRE");

                entity.Property(e => e.Prepuntaje).HasColumnName("PREPUNTAJE");

                entity.Property(e => e.Pretdirecc).HasColumnName("PRETDIRECC");

                entity.Property(e => e.Pretprop).HasColumnName("PRETPROP");

                entity.Property(e => e.Preucalif).HasColumnName("PREUCALIF");

                entity.Property(e => e.Preusonph).HasColumnName("PREUSONPH");

                entity.Property(e => e.Preusoph).HasColumnName("PREUSOPH");

                entity.Property(e => e.Preuvivien).HasColumnName("PREUVIVIEN");

                entity.Property(e => e.Prevactual).HasColumnName("PREVACTUAL");

                entity.Property(e => e.Prevetustz).HasColumnName("PREVETUSTZ");

                entity.Property(e => e.Prevforma).HasColumnName("PREVFORMA");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");
            });

            modelBuilder.Entity<TblloteUso>(entity =>
            {
                entity.HasKey(e => e.IIdloteUso)
                    .HasName("PK_loteUso_iIdloteUso")
                    .IsClustered(false);

                entity.ToTable("tblloteUso", "catastro");

                entity.Property(e => e.IIdloteUso).HasColumnName("iIdloteUso");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.InsertUser).HasColumnName("insertUser");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertionDate");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser).HasColumnName("updateUser");

                entity.Property(e => e.Usoarea)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("USOAREA");

                entity.Property(e => e.Usoclote).HasColumnName("USOCLOTE");

                entity.Property(e => e.Usotuso).HasColumnName("USOTUSO");
            });

            modelBuilder.Entity<Tblpredio1>(entity =>
            {
                entity.HasKey(e => e.UniIdpredio)
                    .HasName("PK__tblpredi__C2CCD9E29661402B");

                entity.ToTable("tblpredio", "IGAC");

                entity.Property(e => e.UniIdpredio)
                    .HasColumnName("uniIdpredio")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FloFechaInsercion).HasColumnName("floFechaInsercion");

                entity.Property(e => e.FloFechaModificacion).HasColumnName("floFechaModificacion");

                entity.Property(e => e.FloareaConstruccion).HasColumnName("floareaConstruccion");

                entity.Property(e => e.FloareaTerreno).HasColumnName("floareaTerreno");

                entity.Property(e => e.Nvaavaluo).HasColumnName("Nvaavaluo");

                entity.Property(e => e.IntActivo).HasColumnName("intActivo");

                entity.Property(e => e.NvaObservacion).HasColumnName("nvaObservacion");

                entity.Property(e => e.NvacodDestino).HasColumnName("nvacodDestino");

                entity.Property(e => e.NvacodDpto).HasColumnName("nvacodDpto");

                entity.Property(e => e.NvacodMpio).HasColumnName("nvacodMpio");

                entity.Property(e => e.Nvadireccion).HasColumnName("nvadireccion");

                entity.Property(e => e.NvanumPredial).HasColumnName("nvanumPredial");

                entity.Property(e => e.NvanumPredialAnterior).HasColumnName("nvanumPredialAnterior");

                entity.Property(e => e.UniUsuarioInsercion).HasColumnName("uniUsuarioInsercion");

                entity.Property(e => e.UniUsuarioModificacion).HasColumnName("uniUsuarioModificacion");

                entity.Property(e => e.Uniunidad).HasColumnName("uniunidad");
            });

            modelBuilder.Entity<Tblterreno>(entity =>
            {
                entity.HasKey(e => e.UniIdterreno)
                    .HasName("PK__tblterre__2FEA96B447C7DCA8");

                entity.ToTable("tblterreno", "IGAC");

                entity.Property(e => e.UniIdterreno)
                    .HasColumnName("uniIdterreno")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FloFechaInsercion).HasColumnName("floFechaInsercion");

                entity.Property(e => e.FloFechaModificacion).HasColumnName("floFechaModificacion");

                entity.Property(e => e.FloShapeArea).HasColumnName("floShape__Area");

                entity.Property(e => e.FloShapeLength).HasColumnName("floShape__Length");

                entity.Property(e => e.Flocentroidx).HasColumnName("flocentroidx");

                entity.Property(e => e.Flocentroidy).HasColumnName("flocentroidy");

                entity.Property(e => e.IntActivo).HasColumnName("intActivo");

                entity.Property(e => e.IntNumeroSubterraneos).HasColumnName("intNUMERO_SUBTERRANEOS");

                entity.Property(e => e.IntObjectid).HasColumnName("intOBJECTID");

                entity.Property(e => e.IntlatestWkid).HasColumnName("intlatestWkid");

                entity.Property(e => e.Intwkid).HasColumnName("intwkid");

                entity.Property(e => e.NvaCodigo).HasColumnName("nvaCODIGO");

                entity.Property(e => e.NvaCodigoAnterior).HasColumnName("nvaCODIGO_ANTERIOR");

                entity.Property(e => e.NvaFuente).HasColumnName("nvaFuente");

                entity.Property(e => e.NvaGlobalid).HasColumnName("nvaGLOBALID");

                entity.Property(e => e.NvaObservacion).HasColumnName("nvaObservacion");

                entity.Property(e => e.NvaVeredaCodigo).HasColumnName("nvaVEREDA_CODIGO");

                entity.Property(e => e.NvacodigoMunicipio).HasColumnName("nvacodigo_municipio");

                entity.Property(e => e.NvageometryType).HasColumnName("nvageometryType");

                entity.Property(e => e.NvaglobalIdFieldName).HasColumnName("nvaglobalIdFieldName");

                entity.Property(e => e.NvaobjectIdFieldName).HasColumnName("nvaobjectIdFieldName");

                entity.Property(e => e.UniUsuarioInsercion).HasColumnName("uniUsuarioInsercion");

                entity.Property(e => e.UniUsuarioModificacion).HasColumnName("uniUsuarioModificacion");

                entity.Property(e => e.Unipredio).HasColumnName("unipredio");
            });

            modelBuilder.Entity<Tblunidad>(entity =>
            {
                entity.HasKey(e => e.UniIdunidad)
                    .HasName("PK__tblunida__ED83571619C7D662");

                entity.ToTable("tblunidad", "IGAC");

                entity.Property(e => e.UniIdunidad)
                    .HasColumnName("uniIdunidad")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FloFechaInsercion).HasColumnName("floFechaInsercion");

                entity.Property(e => e.FloFechaModificacion).HasColumnName("floFechaModificacion");

                entity.Property(e => e.IntActivo).HasColumnName("intActivo");

                entity.Property(e => e.NvaCedulacatastral).HasColumnName("nvaCEDULACATASTRAL");

                entity.Property(e => e.NvaCodigo).HasColumnName("nvaCODIGO");

                entity.Property(e => e.NvaIdUnidadGeo).HasColumnName("nvaID_UNIDAD_GEO");

                entity.Property(e => e.NvaNombre).HasColumnName("nvaNOMBRE");

                entity.Property(e => e.NvaNombreCompleto).HasColumnName("nvaNOMBRE_COMPLETO");

                entity.Property(e => e.NvaObservacion).HasColumnName("nvaObservacion");

                entity.Property(e => e.NvaTipo).HasColumnName("nvaTIPO");

                entity.Property(e => e.UniUsuarioInsercion).HasColumnName("uniUsuarioInsercion");

                entity.Property(e => e.UniUsuarioModificacion).HasColumnName("uniUsuarioModificacion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario", "Seguridad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("birthDate");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateUpdated");

                entity.Property(e => e.DocumentNumber).HasColumnName("documentNumber");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName");

                entity.Property(e => e.IdCity).HasColumnName("idCity");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdDocumentType).HasColumnName("idDocumentType");

                entity.Property(e => e.IdProfile).HasColumnName("idProfile");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.Property(e => e.SecondFirstName).HasColumnName("secondFirstName");

                entity.Property(e => e.SecondLastName).HasColumnName("secondLastName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
