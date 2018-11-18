using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUIform
{
    /*
     * The constructor opens the connection, but the user must close the connection by calling the 'closeConnection()' function.
     * DO NOT leave connection open for entire duration of App uptime. Connection may time out, and cause errors when attempting to send commands.
     * INTENDED USE:
     *      Create new 'HighScoreDB' object on new game load.
     *      Populate top scores sidebar of game window.
     *      Close connection.
     *      
     *      Game over.
     *      Open connection.
     *      Upload new high score with 'insert()' function.
     *      Close connection.
     */


    public class HighScoreDB
    {
        SqlConnection _cnn;

        public HighScoreDB()
        {
            openConnection();
        }

        //Inserts a new score.
        public void insert(string initials, int score)
        {
            System.Text.StringBuilder query = new System.Text.StringBuilder();
            query.Append("INSERT INTO HighScores1 (Initials,Score) Values ('");
            query.Append(initials);
            query.Append("',");
            query.Append(score.ToString());
            query.Append(");");

            SqlCommand insertCmd = new SqlCommand(query.ToString(), _cnn);
            SqlDataReader reader = insertCmd.ExecuteReader();
            reader.Close();
        }

        //Returns the top 5 highscores from the database.
        public Tuple<string, string>[] getTop5()
        {

            System.Text.StringBuilder query = new System.Text.StringBuilder();
            query.Append("SELECT TOP(5) Initials,Score FROM HighScores1 ORDER BY Score DESC;");

            SqlCommand getCmd = new SqlCommand(query.ToString(), _cnn);
            SqlDataReader reader = getCmd.ExecuteReader();

            Tuple<string, string>[] top5 = new Tuple<string, string>[5];

            int i = 0;

            while (reader.Read())
            {
                top5[i] = new Tuple<string, string>(reader["Initials"].ToString(), reader["Score"].ToString());

                ++i;
            }
            reader.Close();
            return top5;
        }

        //Removes ALL highscores from database.
        public void wipeScores()
        {
            SqlCommand wipeCmd = new SqlCommand("DELETE FROM HighScores1;", _cnn);
            SqlDataReader reader = wipeCmd.ExecuteReader();

            reader.Close();
        }

        public void openConnection()
        {
            /*
             * Dylan's GearHost.com account is hosting the database.
            */
            string connetionString = "Data Source=den1.mssql8.gear.host;Initial Catalog=highscores1;User ID=highscores1;Password=Rn6G39!c6!2i";
            _cnn = new SqlConnection(connetionString);

            try
            {
                _cnn.Open();
                System.Windows.Forms.MessageBox.Show("Connected!");


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());

            }
        }

        public void closeConnection()
        {
            _cnn.Close();
        }
    }
}