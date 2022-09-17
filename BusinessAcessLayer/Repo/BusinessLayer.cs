using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using DataTransferObject.ViewModel;

namespace BusinessAcessLayer.Repo
{
    public class BusinessLayer : IBusinessLayer
    {
        //public SqlConnection con;

        //public void connection()
        //{

        //    string dbCon = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //    con =new SqlConnection(dbCon);
        //}


        public IEnumerable<EmployeeModel> GetEmployees()
        {

            var sqlQuery = @"SELECT E.EmployeeId, E.EmployeeName, E.EmployeeSalary, D.DetailId, D.FatherName, D.Address, D.Contact, D.EmployeeId
                             FROM Employee E INNER JOIN EmployeeDetail D ON E.EmployeeId = D.EmployeeId";


            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
            {
                return db.Query<EmployeeModel>(sqlQuery);
            };
        }

        public IEnumerable<EmployeeModel> GetEmployeeById(int id)
        {
            var sqlQuery = @"SELECT E.EmployeeId, E.EmployeeName, E.EmployeeSalary, D.DetailId, D.FatherName, D.Address, D.Contact, D.EmployeeId
                             FROM Employee E INNER JOIN EmployeeDetail D ON E.EmployeeId = D.EmployeeId WHERE E.EmployeeId =" + id;

            using(IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
            {
                return db.Query<EmployeeModel>(sqlQuery);
            }
               
        }
    }
}
