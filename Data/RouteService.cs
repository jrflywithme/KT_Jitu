using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace blalogin.Data
{
    public class RouteService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public RouteService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Routes
        public async Task<List<Route>> GetAllRoutesAsync(int currentPage,int pageSize)
        {
            return await _appDBContext.Routes.OrderByDescending(x=>x.Id).Skip((currentPage-1)*pageSize).Take(pageSize).ToListAsync();
        }
        #endregion

        public async Task<int> GetCountAsync()
        {
            return await _appDBContext.Routes.CountAsync();
        }
        

        #region Insert Route
        public async Task<bool> InsertRouteAsync(Route route)
        {
            await _appDBContext.Routes.AddAsync(route);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Route by Id
        public async Task<Route> GetRouteAsync(int Id)
        {
            Route route = await _appDBContext.Routes.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return route;
        }
        #endregion

         
        #region Get Route by Name
        public async Task<List<Route>> SearchRoutesAsync(string searchItem)
        {
            return await _appDBContext.Routes.Where(s => s.Routename.ToLower().Contains(searchItem.ToLower())).ToListAsync();
        }
        #endregion

        #region Update Route
        public async Task<bool> UpdateRouteAsync(Route route)
        {
             _appDBContext.Routes.Update(route);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Deleteroute
        public async Task<bool> DeleteRouteAsync(Route route)
        {
            _appDBContext.Remove(route);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
 
        public async Task<List<Route>> SearchIssuesAsync(string searchItem)
        {
            return await _appDBContext.Routes.Where(s => s.Routename.ToLower().Contains(searchItem.ToLower())).ToListAsync();
        }
        public async Task<bool> SaveRoutes(List<Route> routes) {
            try
            {
                foreach (var item in routes)
                {
                    _appDBContext.Routes.Add(item);
                }
                await _appDBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        
        }



    }
}
 