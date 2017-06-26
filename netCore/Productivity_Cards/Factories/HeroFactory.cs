using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Productivity_Cards.Models;
using Dapper;
using System.Linq;

namespace Productivity_Cards.Factories{
    public class HeroFactory{
        static string server = "localhost";
        static string db = "productivity_cards";
        static string port = "8887";
        static string user = "root";
        static string pass = "root";
        internal static IDbConnection Connection {
            get {
                return new MySqlConnection($"Server={server};Port={port};Database={db};UserID={user};Password={pass};SslMode=None");
            }
        }
        public void CreateNewHero(Hero hero, int userId){
            using (IDbConnection dbConnection = Connection){
                string query = $"INSERT INTO heros (name, card_draw, deck_size, level, mana, mana_progression, hero_class, created_at, updated_at, users_user_id) VALUES ('{hero.name}', '{hero.card_draw}', '{hero.deck_size}', '{hero.level}', '{hero.mana}', '{hero.mana_progression}', '{hero.hero_class}', NOW(), NOW(), '{userId}')";
                dbConnection.Open();
                dbConnection.Execute(query);
            }
        }
    }
}