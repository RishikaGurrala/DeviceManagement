using DeviceManagement.Controllers;
using DeviceManagement.Models;

namespace DeviceManagement.Core
{
    public class BusinessLL
        
    {
        private Models.MobileContext Model;
        public BusinessLL()
        {
            Model = new Models.MobileContext();
        }
        public List<Mob> GetMobs()
        {
            List<Mob> mobs = Model.GetMobs();
            return Model.GetMobs();

        }
        public void PostMobs(Mob mobs)
        {
            Model.PostMobs(mobs);
        }
        public void DeleteMobile(int MobId)
        {
            var db = new MobileContext();
            Mob mobs = new Mob();
            mobs = db.Mobs.FirstOrDefault(x => x.MobId == MobId);
            if (mobs == null)
                throw new Exception("Not Found");
            Model.DeleteMobile(MobId);
        }
        public List<Laptop> GetLaptop()
        {
            List<Mob> mobs = Model.GetMobs();
            return Model.Getlaptop();

        }
        public void PostLaptop(Laptop Lap)
        {
            Model.PostLaptop(Lap);
        }
        public void DeleteLaptop(int LapId)
        {
            var db = new MobileContext();
            Laptop lap = new Laptop();
            lap = db.Laptops.FirstOrDefault(x => x.LapId == LapId);
            if (lap == null)
                throw new Exception("Not Found");
            Model.DeleteLaptop(LapId);
        }
        public void PostRegistration(User user)
        {
            Model.PostRegistration(user);
        }
        
        //public void UpdateMob(int MobID, MobileContext context)
        //{
        //    Mob item = null;
        //    MobileContext db = new MobileContext();
        //    item = db.Mobs.Find(MobID);
        //    if (item == null)
        //    {
        //        context.ModelState.AddModelError("", String.Format("Item with id {0} was not found", MobID));
        //        return;
        //    }

        //    context.TryUpdateModel(item);
        //    if (context.ModelState.IsValid)
        //    {
        //        db.SaveChanges();
        //    }
        //}
        //public void UpdateMobs(int MobId)
        //{
        //    var db = new MobileContext();
        //    Mob mobs = new Mob();
        //    mobs = db.Mobs.FirstOrDefault(x => x.MobId == MobId);
        //    if (mobs == null)
        //        throw new Exception("Not Found");
        //    else
        //    {
        //        var ob = db.Mobs.GetMobs(MobId);
        //    }

        //}
    }
}
