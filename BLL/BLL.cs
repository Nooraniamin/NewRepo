using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class bll_Student
    {
        public void saveStudent(string _sId, string _sName)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("st_insertempcat", _sId, _sName);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();

        }
        public void update(Int16 id,string _sId, string _sName)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("st_updateempcat", _sId, _sName, id);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();

        }
        public void update(Int16 id)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("st_delempcat", id);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();

        }
    }
}
