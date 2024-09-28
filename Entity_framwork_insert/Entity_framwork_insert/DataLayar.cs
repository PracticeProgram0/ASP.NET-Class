//using Entity_framwork_insert.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI.WebControls;

//namespace Entity_framwork_insert
//{
//    public class DataLayar
//    {
//        public int DataInsert(Student data)
//        {
           
//            using (var btpsContext = new MvcEntities())
//            {
//                var entity = new @base
//                {
//                    name = data.name,
//                    address = data.address,
//                    phone = data.phone,
//                };
//                btpsContext.bases.Add(entity);
//                int result = btpsContext.SaveChanges();

//                return result;
//            }
            
           
//        }

//        public List<> SelectallData()
//        {
//            using(var context = new MvcEntities())
//            {
//                var data = context.bases.ToList();
//                return data;
//            }
//        }

//    }

//}