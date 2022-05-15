using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LAB_4
{
    public class DatabaseHandler
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DatabaseHandler()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "app";
            uid = "root";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CheckUserCredimentals(String userName, String userPassword)
        {
            var userExist = false;

            var usersList = new List<User>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var newUser = new User();
                    newUser.Id = dataReader.GetInt32(0);
                    newUser.FirstName = dataReader.GetString(1);
                    newUser.SurName = dataReader.GetString(2);
                    newUser.Login = dataReader.GetString(3);
                    newUser.Password = dataReader.GetString(4);
                    newUser.Email = dataReader.GetString(5);
                    newUser.Permissions = dataReader.GetString(6);
                    newUser.AccountCreationDate = dataReader.GetString(7);

                    usersList.Add(newUser);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].Login.Equals(userName))
                {
                    if (usersList[i].Password.Equals(userPassword))
                    {
                        userExist = true;
                    }
                }
            }

            return userExist;
        }

        public bool CheckUserLogin(String userName)
        {
            var userExist = false;

            var usersList = new List<User>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var newUser = new User();
                    newUser.Id = dataReader.GetInt32(0);
                    newUser.FirstName = dataReader.GetString(1);
                    newUser.SurName = dataReader.GetString(2);
                    newUser.Login = dataReader.GetString(3);
                    newUser.Password = dataReader.GetString(4);
                    newUser.Email = dataReader.GetString(5);
                    newUser.Permissions = dataReader.GetString(6);
                    newUser.AccountCreationDate = dataReader.GetString(7);

                    usersList.Add(newUser);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].Login.Equals(userName))
                {
                    userExist = true;
                }
            }

            return userExist;
        }

        public User getUser(String userName)
        {
            var user = new User();
            var usersList = new List<User>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var newUser = new User();
                    newUser.Id = dataReader.GetInt32(0);
                    newUser.FirstName = dataReader.GetString(1);
                    newUser.SurName = dataReader.GetString(2);
                    newUser.Login = dataReader.GetString(3);
                    newUser.Password = dataReader.GetString(4);
                    newUser.Email = dataReader.GetString(5);
                    newUser.Permissions = dataReader.GetString(6);
                    newUser.AccountCreationDate = dataReader.GetString(7);

                    usersList.Add(newUser);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].Login.Equals(userName))
                {
                    user = usersList[i];
                    break;
                }
            }

            return user;
        }
        
        public User GetUser(int id)
        {
            var user = new User();
            var usersList = new List<User>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var newUser = new User();
                    newUser.Id = dataReader.GetInt32(0);
                    newUser.FirstName = dataReader.GetString(1);
                    newUser.SurName = dataReader.GetString(2);
                    newUser.Login = dataReader.GetString(3);
                    newUser.Password = dataReader.GetString(4);
                    newUser.Email = dataReader.GetString(5);
                    newUser.Permissions = dataReader.GetString(6);
                    newUser.AccountCreationDate = dataReader.GetString(7);

                    usersList.Add(newUser);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].Id.Equals(id))
                {
                    user = usersList[i];
                    break;
                }
            }

            return user;
        }

        public List<User> GetUsersList()
        {
            var usersList = new List<User>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var newUser = new User();
                    newUser.Id = dataReader.GetInt32(0);
                    newUser.FirstName = dataReader.GetString(1);
                    newUser.SurName = dataReader.GetString(2);
                    newUser.Login = dataReader.GetString(3);
                    newUser.Password = dataReader.GetString(4);
                    newUser.Email = dataReader.GetString(5);
                    newUser.Permissions = dataReader.GetString(6);
                    newUser.AccountCreationDate = dataReader.GetString(7);

                    usersList.Add(newUser);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return usersList;
        }

        public void AddUser(User user)
        {
            var todayDate = DateTime.Today;
            var strTodayDate = todayDate.Day + "-" + todayDate.Month + "-" + todayDate.Year;

            string query = "INSERT INTO users (imie," +
                           "nazwisko," +
                           "login," +
                           "haslo," +
                           "email," +
                           "uprawnienia," +
                           "data_rejestracji" +
                           ") VALUES('" + user.FirstName + "','" +
                           user.SurName + "','" +
                           user.Login + "','" +
                           user.Password + "','" +
                           user.Email + "','" +
                           "user" + "','" +
                           strTodayDate + "');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                MessageBox.Show("Konto zostało zarejestrowane!");
            }
        }

        public void RemoveUser(User user)
        {
            string query = "DELETE FROM users WHERE login = '" + user.Login + "'";

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                MessageBox.Show("Konto zostało usunięte!");
            }
        }

        public void ChangeUserPassword(User user, String newPassword)
        {
            string query = "UPDATE users SET haslo = '" + newPassword + "' WHERE login = '" + user.Login + "'";

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                MessageBox.Show("Hasło zostało zmienione!");
            }
        }

        public List<Event> GetEventsList()
        {
            var eventList = new List<Event>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM events", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var newEvent = new Event(
                        dataReader.GetInt32(0),
                        dataReader.GetString(1),
                        dataReader.GetString(2),
                        dataReader.GetString(3)
                    );
                    eventList.Add(newEvent);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return eventList;
        }
        
        public Event GetEventElement(int id)
        {
            var eventElement = new Event();
            var eventList = new List<Event>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM events", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var newEvent = new Event(
                        dataReader.GetInt32(0),
                        dataReader.GetString(1),
                        dataReader.GetString(2),
                        dataReader.GetString(3)
                    );
                    eventList.Add(newEvent);
                }

                dataReader.Close();
                this.CloseConnection();
            }
            
            for (int i = 0; i < eventList.Count; i++)
            {
                if (eventList[i].Id.Equals(id))
                {
                    eventElement = eventList[i];
                    break;
                }
            }

            return eventElement;
        }
        
        public List<UserEntries> GetUsersEntries()
        {
            var usersEntries = new List<UserEntries>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users_entries", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var userEntry = new UserEntries(
                        dataReader.GetInt32(0),
                        dataReader.GetInt32(1),
                        dataReader.GetString(2),
                        dataReader.GetString(3),
                        dataReader.GetString(4)
                    );
                    usersEntries.Add(userEntry);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return usersEntries;
        }
        
        public List<UserEntries> GetUserEntries(int userId)
        {
            var usersEntries = new List<UserEntries>();
            var userEntries = new List<UserEntries>();
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users_entries", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var userEntry = new UserEntries(
                        dataReader.GetInt32(0),
                        dataReader.GetInt32(1),
                        dataReader.GetString(2),
                        dataReader.GetString(3),
                        dataReader.GetString(4)
                    );
                    usersEntries.Add(userEntry);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            for (int i = 0; i < usersEntries.Count; i++)
            {
                if (usersEntries[i].UserId == userId)
                {
                    userEntries.Add(usersEntries[i]);
                }
            }

            return userEntries;
        }

        public void RemoveEvent(Event eventElement)
        {
            string query = "DELETE FROM events WHERE id = '" + eventElement.Id + "'";

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                MessageBox.Show("Wydarzenie zostało usunięte!");
            }
        }

        public void AddEventEntry(User user, Event eventElement, String participationType, String foodType)
        {
            var todayDate = DateTime.Today;
            var strTodayDate = todayDate.Day + "-" + todayDate.Month + "-" + todayDate.Year;

            string query = "INSERT INTO users_entries (user_id," +
                           "event_id," +
                           "status," +
                           "participation_type," +
                           "food_type" +
                           ") VALUES(" + user.Id + "," +
                           eventElement.Id + ",'" +
                           "niezweryfikowany','" +
                           participationType + "','" +
                           foodType + "');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                MessageBox.Show("Zgłoszenie zostało wysłane!");
            }
        }

        public void AddEvent(Event eventElement)
        {
            string query = "INSERT INTO events (event_name," +
                           "agenda," +
                           "event_date" +
                           ") VALUES('" + eventElement.Name + "','" +
                           eventElement.Agenda + "','" +
                           eventElement.Date + "');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                MessageBox.Show("Wydarzenie zostało utworzone!");
            }
        }

        public void ChangeEventInformations(Event eventElement)
        {
            string query = "UPDATE events " +
                           "SET event_name = '" + eventElement.Name + "'," +
                           "agenda = '" + eventElement.Agenda + "'," +
                           "event_date = '" + eventElement.Date + "'" +
                           " WHERE id = " + eventElement.Id;

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                MessageBox.Show("Elementy wydarzenia zostały zmienione!");
            }
        }

        public void ChangeEventEntryStatus(int entryID, bool status)
        {
            string query;
            if (status)
            {
                query = "UPDATE users_entries " +
                        "SET status = 'zatwierdzony'" +
                        " WHERE user_id = " + entryID;
            }
            else
            {
                query = "UPDATE users_entries " +
                        "SET status = 'odrzucony'" +
                        " WHERE user_id = " + entryID;
            }
            
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}