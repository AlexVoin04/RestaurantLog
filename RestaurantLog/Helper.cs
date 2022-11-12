using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLog
{
    internal class Helper
    {
        private static Model.RestaurantEntities s_restaurantEntities;
        public static Model.RestaurantEntities GetContext()
        {
            if (s_restaurantEntities == null)
            {
                s_restaurantEntities = new Model.RestaurantEntities();
            }
            return s_restaurantEntities;
        }

        public void CreateEmployees(Model.Employees employees, Model.EmployeeInformation employeeInformation, Model.Authorization authorization)
        {
            s_restaurantEntities.Employees.Add(employees);
            s_restaurantEntities.EmployeeInformation.Add(employeeInformation);
            //s_restaurantEntities.Posts.Add(posts);
            s_restaurantEntities.Authorization.Add(authorization);
            s_restaurantEntities.SaveChanges();
        }

        public int GetLastIDEmployee()
        {
            int id = s_restaurantEntities.Employees.OrderByDescending(employees => employees.ID).First().ID;
            return id + 1;
        }

        public int GetLastIDInfo()
        {
            int id = s_restaurantEntities.EmployeeInformation.OrderByDescending(employeeInformation => employeeInformation.ID).First().ID;
            return id + 1;
        }

        public int GetLastIDAuth()
        {
            int id = s_restaurantEntities.Authorization.OrderByDescending(authorization => authorization.ID).First().ID;
            return id + 1;
        }

        public int GetLastIDPost()
        {
            int id = s_restaurantEntities.Posts.OrderByDescending(posts => posts.ID).First().ID;
            return id + 1;
        }
        /*
        public int GetLogIn(string login, string password)
        {
            if(s_restaurantEntities.Authorization.Any(x=>x.Login==login && x.Password == password))
            {
                int idaut = s_restaurantEntities.Authorization.Where(x => x.Login == login).First().ID;
                int idinf = s_restaurantEntities.EmployeeInformation.Where(x=>x.AuthorizationID == idaut).First().ID;   
                int id = s_restaurantEntities.EmployeeInformation.Where(x=>x.)
            }
        }*/
    }
}
