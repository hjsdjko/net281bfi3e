using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 图书续借
    /// </summary>
    [SugarTable("tushuxujie")]
	public class TushuxujieDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 借阅编号
		/// </summary>
		[SugarColumn(ColumnName = "jieyuebianhao")]
		public string Jieyuebianhao { get; set; }

		/// <summary>
		/// Desc: 图书编号
		/// </summary>
		[SugarColumn(ColumnName = "tushubianhao")]
		public string Tushubianhao { get; set; }

		/// <summary>
		/// Desc: 图片
		/// </summary>
		[SugarColumn(ColumnName = "tupian")]
		public string Tupian { get; set; }

		/// <summary>
		/// Desc: 图书名称
		/// </summary>
		[SugarColumn(ColumnName = "tushumingcheng")]
		public string Tushumingcheng { get; set; }

		/// <summary>
		/// Desc: 数量
		/// </summary>
        [SugarColumn(ColumnName = "shuliang")]
		public int? Shuliang { get; set; } = 0;

		/// <summary>
		/// Desc: 续借天数
		/// </summary>
        [SugarColumn(ColumnName = "xujietianshu")]
		public int? Xujietianshu { get; set; } = 0;

		/// <summary>
		/// Desc: 用户名
		/// </summary>
		[SugarColumn(ColumnName = "yonghuming")]
		public string Yonghuming { get; set; }

		/// <summary>
		/// Desc: 姓名
		/// </summary>
		[SugarColumn(ColumnName = "xingming")]
		public string Xingming { get; set; }

		/// <summary>
		/// Desc: 申请时间
		/// </summary>
        [SugarColumn(ColumnName = "shenqingshijian")]
		public DateTime? Shenqingshijian { get; set; }

		/// <summary>
		/// Desc: 是否审核
		/// </summary>
		[SugarColumn(ColumnName = "sfsh")]
		public string Sfsh { get; set; }

		/// <summary>
		/// Desc: 审核回复
		/// </summary>
		[SugarColumn(ColumnName = "shhf")]
		public string Shhf { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
