﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using run4cause.Data;

#nullable disable

namespace run4cause.Migrations
{
    [DbContext(typeof(Run4causeContext))]
    partial class Run4causeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EditionRun", b =>
                {
                    b.Property<int>("EditionsId")
                        .HasColumnType("integer")
                        .HasColumnName("editions_id");

                    b.Property<int>("RunsId")
                        .HasColumnType("integer")
                        .HasColumnName("runs_id");

                    b.HasKey("EditionsId", "RunsId")
                        .HasName("pk_edition_run");

                    b.HasIndex("RunsId")
                        .HasDatabaseName("ix_edition_run_runs_id");

                    b.ToTable("edition_run", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<string>("Headline")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("headline");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double precision")
                        .HasColumnName("latitude");

                    b.Property<string>("Location")
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double precision")
                        .HasColumnName("longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_editions");

                    b.ToTable("editions", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EditionId")
                        .HasColumnType("integer")
                        .HasColumnName("edition_id");

                    b.Property<DateTime>("Register")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("register");

                    b.Property<int>("RunId")
                        .HasColumnType("integer")
                        .HasColumnName("run_id");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_entries");

                    b.HasIndex("EditionId")
                        .HasDatabaseName("ix_entries_edition_id");

                    b.HasIndex("RunId")
                        .HasDatabaseName("ix_entries_run_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_entries_user_id");

                    b.ToTable("entries", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text")
                        .HasColumnName("normalized_name");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "8d2cefb3-88aa-4462-90f7-e2915f72bb96",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "408b981f-6eb4-411e-a5a3-f3ffce93c10a",
                            Name = "Moderator"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "711e4a85-d9d4-40f9-b745-af3004954a2a",
                            Name = "Runner"
                        });
                });

            modelBuilder.Entity("run4cause.Models.Run", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_runs");

                    b.ToTable("runs", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.RunWaypoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Instant")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("instant");

                    b.Property<int>("RunId")
                        .HasColumnType("integer")
                        .HasColumnName("run_id");

                    b.Property<int>("WaypointId")
                        .HasColumnType("integer")
                        .HasColumnName("waypoint_id");

                    b.HasKey("Id")
                        .HasName("pk_run_waypoints");

                    b.HasIndex("RunId")
                        .HasDatabaseName("ix_run_waypoints_run_id");

                    b.HasIndex("WaypointId")
                        .HasDatabaseName("ix_run_waypoints_waypoint_id");

                    b.ToTable("run_waypoints", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.Sponsorship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("AmountPerKilometer")
                        .HasColumnType("real")
                        .HasColumnName("amount_per_kilometer");

                    b.Property<int?>("PerformerId")
                        .HasColumnType("integer")
                        .HasColumnName("performer_id");

                    b.Property<int?>("SponsorId")
                        .HasColumnType("integer")
                        .HasColumnName("sponsor_id");

                    b.HasKey("Id")
                        .HasName("pk_sponsorships");

                    b.HasIndex("PerformerId")
                        .HasDatabaseName("ix_sponsorships_performer_id");

                    b.HasIndex("SponsorId")
                        .HasDatabaseName("ix_sponsorships_sponsor_id");

                    b.ToTable("sponsorships", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.Tracking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Instant")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("instant");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.Property<int>("WaypointId")
                        .HasColumnType("integer")
                        .HasColumnName("waypoint_id");

                    b.HasKey("Id")
                        .HasName("pk_trackings");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_trackings_user_id");

                    b.HasIndex("WaypointId")
                        .HasDatabaseName("ix_trackings_waypoint_id");

                    b.ToTable("trackings", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("email_confirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text")
                        .HasColumnName("security_stamp");

                    b.Property<decimal?>("TotalDistanceCovered")
                        .HasColumnType("numeric(20,2)")
                        .HasColumnName("total_distance_covered");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "29684717-b274-4c92-94d0-275810e21891",
                            EmailConfirmed = false,
                            FirstName = "Run4",
                            LastName = "admin",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "default_admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6b7773bd-8dc9-42e7-87ee-c678fb50c8d7",
                            EmailConfirmed = false,
                            FirstName = "Run4",
                            LastName = "moderator",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "default_moderator"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "83ed0c48-8ac9-4188-b340-d7cdfda0cf59",
                            EmailConfirmed = false,
                            FirstName = "Run4",
                            LastName = "runner",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "default_Runner"
                        });
                });

            modelBuilder.Entity("run4cause.Models.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claim_value");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_user_claims");

                    b.ToTable("user_claims", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text")
                        .HasColumnName("provider_key");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_user_logins");

                    b.ToTable("user_logins", (string)null);
                });

            modelBuilder.Entity("run4cause.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_user_roles");

                    b.ToTable("user_roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            RoleId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            RoleId = 3,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("run4cause.Models.Waypoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double?>("Latitude")
                        .HasColumnType("double precision")
                        .HasColumnName("latitude");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double precision")
                        .HasColumnName("longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_waypoints");

                    b.ToTable("waypoints", (string)null);
                });

            modelBuilder.Entity("EditionRun", b =>
                {
                    b.HasOne("run4cause.Models.Edition", null)
                        .WithMany()
                        .HasForeignKey("EditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_edition_run_editions_editions_id");

                    b.HasOne("run4cause.Models.Run", null)
                        .WithMany()
                        .HasForeignKey("RunsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_edition_run_runs_runs_id");
                });

            modelBuilder.Entity("run4cause.Models.Entry", b =>
                {
                    b.HasOne("run4cause.Models.Edition", "Edition")
                        .WithMany("Entries")
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_entries_editions_edition_id");

                    b.HasOne("run4cause.Models.Run", "Run")
                        .WithMany("Entries")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_entries_runs_run_id");

                    b.HasOne("run4cause.Models.User", "User")
                        .WithMany("Entries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_entries_users_user_id");

                    b.Navigation("Edition");

                    b.Navigation("Run");

                    b.Navigation("User");
                });

            modelBuilder.Entity("run4cause.Models.RunWaypoint", b =>
                {
                    b.HasOne("run4cause.Models.Run", "Run")
                        .WithMany("RunWaypoints")
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_run_waypoints_runs_run_id");

                    b.HasOne("run4cause.Models.Waypoint", "Waypoint")
                        .WithMany("RunWaypoints")
                        .HasForeignKey("WaypointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_run_waypoints_waypoints_waypoint_id");

                    b.Navigation("Run");

                    b.Navigation("Waypoint");
                });

            modelBuilder.Entity("run4cause.Models.Sponsorship", b =>
                {
                    b.HasOne("run4cause.Models.User", "Performer")
                        .WithMany()
                        .HasForeignKey("PerformerId")
                        .HasConstraintName("fk_sponsorships_users_performer_id");

                    b.HasOne("run4cause.Models.User", "Sponsor")
                        .WithMany()
                        .HasForeignKey("SponsorId")
                        .HasConstraintName("fk_sponsorships_users_sponsor_id");

                    b.Navigation("Performer");

                    b.Navigation("Sponsor");
                });

            modelBuilder.Entity("run4cause.Models.Tracking", b =>
                {
                    b.HasOne("run4cause.Models.User", "User")
                        .WithMany("Trackings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_trackings_users_user_id");

                    b.HasOne("run4cause.Models.Waypoint", "Waypoint")
                        .WithMany("Trackings")
                        .HasForeignKey("WaypointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_trackings_waypoints_waypoint_id");

                    b.Navigation("User");

                    b.Navigation("Waypoint");
                });

            modelBuilder.Entity("run4cause.Models.Edition", b =>
                {
                    b.Navigation("Entries");
                });

            modelBuilder.Entity("run4cause.Models.Run", b =>
                {
                    b.Navigation("Entries");

                    b.Navigation("RunWaypoints");
                });

            modelBuilder.Entity("run4cause.Models.User", b =>
                {
                    b.Navigation("Entries");

                    b.Navigation("Trackings");
                });

            modelBuilder.Entity("run4cause.Models.Waypoint", b =>
                {
                    b.Navigation("RunWaypoints");

                    b.Navigation("Trackings");
                });
#pragma warning restore 612, 618
        }
    }
}
