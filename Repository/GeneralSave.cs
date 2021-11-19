using Microsoft.Data.SqlClient;
using Model;
using Repository.VM;
using System;
using System.Threading.Tasks;

namespace Repository
{
    public class GeneralSave
    {

        public async Task<ResultMessageVM> save(DatabaseCTX db)
        {
            ResultMessageVM res = new ResultMessageVM
            {
                Code = -1,
                Message = "",
                IsSuccess = false
            };
            try
            {
                int Addres =await db.SaveChangesAsync();
                if (Addres > 0)
                {
                    res.IsSuccess = true;
                    res.Message = "عملیات با موفقیت انجام شد";
                    res.Code = 200;
                }
                else
                {
                    res.IsSuccess = false;
                    res.Message = "عملیات با موفقیت انجام نشد";
                    res.Code = 400;
                }
            }
            catch (Exception ex)
            {
                res.Code = 1000;
                res.Message = "عملیات با موفقیت انجام نشد";
                res.IsSuccess = false;
            }

            return res;

        }
    }
}
