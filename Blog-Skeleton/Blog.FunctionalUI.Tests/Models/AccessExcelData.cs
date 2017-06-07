using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.OleDb;

namespace Blog.FunctionalUI.Tests.Models
{
  public class AccessExcelData
    {

        public static string fileName;
        public static string TestDataFileConnection()
        {
           // var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\DataDrivenTests\\");
        var path = @"C:\Users\DISHLIEV\Documents\Visual Studio 2015\Projects\Blog-Skeleton\Blog\Blog-Skeleton\Blog.Unit.Tests\DataDrivenTests\";
      
      
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                              Data Source = {0}; 
		                              Extended Properties=Excel 12.0;", path + fileName);
            return con;
        }

        public static RegistrationUser GetRegistrationTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<RegistrationUser>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

        public static LogInUser GetLoginTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<LogInUser>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
        public static CreateArticle GetArticleTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<CreateArticle>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
        public static ChangePassword GetPasswordTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<ChangePassword>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

    }
}
