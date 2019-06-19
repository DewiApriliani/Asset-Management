using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository.Application
{
    public class ProcurementRepository
    {
        MyContext myContext = new MyContext();
        bool status;

        public Procurement Get(int id)
        {
            var get = myContext.Procurements.Find(id);
            return get;
        }

        public bool Insert(ProcurementVM procurementVM)
        {
            var push = new Procurement(procurementVM);
            var getTypeItem = myContext.TypeItems.Find(procurementVM.TypeItem_Id);
            var getItem = myContext.Items.Find(procurementVM.Item_Id);
            push.TypeItem = getTypeItem;
            push.Item = getItem;
            myContext.Procurements.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {

                status = true;
            }
            else
            {
                return status;
            }
            return status;
        }

        public bool Update(int id, ProcurementVM procurementVM)
        {
            var get = Get(id);
            var getTypeItem = myContext.TypeItems.Find(procurementVM.TypeItem_Id);
            var getItem = myContext.Items.Find(procurementVM.Item_Id);
            get.TypeItem = getTypeItem;
            get.Item = getItem;
            if (get != null)
            {
                get.Update(id, procurementVM);
                myContext.Entry(get).State = EntityState.Modified;
                myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = EntityState.Modified;
                myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
