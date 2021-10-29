using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace blalogin.Data
{
    public class DailyproductService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public DailyproductService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Dailyproducts
        public async Task<List<Dailyproduct>> GetAllDailyproductsAsync()
        {
            return await _appDBContext.Dailyproducts.ToListAsync();
        }
        #endregion

        #region Get Dailyproduct by Id
        public async Task<Dailyproduct> GetdailyproductAsync(int Id)
        {
            Dailyproduct dailyproduct = await _appDBContext.Dailyproducts.FirstOrDefaultAsync(c => c.Sid.Equals(Id));
            return dailyproduct;
        }
        #endregion

        #region Insert Dailyproduct
        public async Task<bool> InsertDailyproductAsync(Dailyproduct dailyproduct)
        {
            await _appDBContext.Dailyproducts.AddAsync(dailyproduct);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Update Dailyproduct
        public async Task<bool> UpdateDailyproduct(Dailyproduct dailyproduct)
        {
            _appDBContext.Dailyproducts.Update(dailyproduct);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Dailyproduct
        public async Task<bool> DeleteDailyproductAsync(Dailyproduct dailyproduct)
        {
            _appDBContext.Remove(dailyproduct);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

         
    }
}
