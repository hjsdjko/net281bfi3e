using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xiezn.Core.Common.Helpers;
using Xiezn.Core.Models;
using Xiezn.Core.Models.DbModel;


namespace Xiezn.Core.Business.Services
{
    public class YonghuService : BaseService<YonghuDbModel>
    {
        private readonly long _uid;
        private readonly string _role;
        private readonly string _tablename;

        public YonghuService()
        {
            try
            {
                if (CacheHelper.TokenModel != null)
                {
                    _uid = CacheHelper.TokenModel.Uid;
                    _role = CacheHelper.TokenModel.Role;
                    _tablename = CacheHelper.TokenModel.Tablename;
                }
            }
            catch
            {
                _uid = 0;
                _role = "游客";
            }
        }

		public dynamic Login(string username, string password)
        {
            return CurrentDb.GetSingle(it => it.Yonghuming == username && it.Mima == password);
        }
        public dynamic Login(string username)
        {
            return CurrentDb.GetSingle(it => it.Yonghuming == username);
        }
        
        public bool ResetPass(string username)
        {
            string mima = "123456";
            return CurrentDb.Update(it => new YonghuDbModel() { Mima = mima }, it => it.Yonghuming == username);
        }





        public PageModel<YonghuDbModel> GetPageList(int page, int limit, string sort, string order, List<IConditionalModel> conModels)
        {
            PageModel pageModel = new PageModel() { PageIndex = page, PageSize = limit };

            int totalNumber = 0;
            int totalPage = 0;
            string[] sortFields = sort.Split(',');
            string[] orderFields = order.Split(',');
            string mysort = "";
            for (int i = 0; i < sortFields.Length; i++)
            {
                if (i == sortFields.Length - 1)
                {
                    mysort += sortFields[i] + " " + orderFields[i];
                }
                else
                {
                    mysort += sortFields[i] + " " + orderFields[i] + ",";

                }

            }
            List<YonghuDbModel> ts = Db.Queryable<YonghuDbModel>().Where(conModels).OrderBy(mysort).ToPageList(page, limit, ref totalNumber, ref totalPage);


            PageModel<YonghuDbModel> t = new PageModel<YonghuDbModel>()
            {
                Code = ResponseCodeEnum.Success,
                Data = new Page<YonghuDbModel>()
                {
                    Total = totalNumber,
                    PageSize = limit,
                    TotalPage = totalPage,
                    CurrPage = page,
                    List = ts
                }
            };

            return t;
        }








    }
}
