using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpImgLgn.DataLayers
{
    public class UserDataLayer
    {
        User Utilisateur = new User();

        public User GetOne(int Id) //methode pour aller recup l'id (pour les données) sur le serveur sql
        {
            using (SqlConnection context = new SqlConnection()) // ne pas oublier d'ajouter le using datasql...
            {
                string connectionString = Properties.Settings.Default.chaineDeConnexion; //chaineD...= propriété du projet (nom,type...)
                context.ConnectionString = connectionString; 

                context.Open();

                using (SqlCommand queryUser = context.CreateCommand())
                {
                    queryUser.CommandText = "SELECT Id," +
                                              "Nom," +
                                              "Prenom," +
                                              "Age," +
                                              "Login," +
                                              "Password " +
                                              "FROM [user] " +
                                              "Where Id = " + Id;

                    using (SqlDataReader ReaderUser = queryUser.ExecuteReader())
                    {
                        while(ReaderUser.Read())
                        { 
                        Utilisateur.Id = int.Parse(ReaderUser["Id"].ToString());
                        Utilisateur.Nom = ReaderUser["Nom"].ToString();
                        Utilisateur.Prenom = ReaderUser["Prenom"].ToString();
                        Utilisateur.Login = ReaderUser["Login"].ToString();
                        Utilisateur.Age = int.Parse(ReaderUser["Age"].ToString());
                        Utilisateur.Password = ReaderUser["Password"].ToString();
                        }
                    }
                }
            }

            return Utilisateur;
        }
        public decimal? SearchByLogin(string login)
        {
            decimal? res = null;

            using (SqlConnection context = new SqlConnection(Properties.Settings.Default.chaineDeConnexion))
            {
                context.Open();
                SqlCommand command = new SqlCommand("Select Id from [User] where Login = '" + login + "'", context);
                res = command.ExecuteScalar() as decimal?;
            }
            return res;
        }

        public bool PasswordOK(int Id, string pwd)
        {
            User user = GetOne(Id);
            return (pwd == user.Password);
        }

    }
}
