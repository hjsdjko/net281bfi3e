using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 图书信息
    /// </summary>
    [SugarTable("tushuxinxi")]
	public class TushuxinxiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 图书编号
		/// </summary>
		[SugarColumn(ColumnName = "tushubianhao")]
		public string Tushubianhao { get; set; }

		/// <summary>
		/// Desc: 图书名称
		/// </summary>
		[SugarColumn(ColumnName = "tushumingcheng")]
		public string Tushumingcheng { get; set; }

		/// <summary>
		/// Desc: 图书分类
		/// </summary>
		[SugarColumn(ColumnName = "tushufenlei")]
		public string Tushufenlei { get; set; }

		/// <summary>
		/// Desc: 规格参数
		/// </summary>
		[SugarColumn(ColumnName = "guigecanshu")]
		public string Guigecanshu { get; set; }

		/// <summary>
		/// Desc: 数量
		/// </summary>
        [SugarColumn(ColumnName = "shuliang")]
		public int? Shuliang { get; set; } = 0;

		/// <summary>
		/// Desc: 图片
		/// </summary>
		[SugarColumn(ColumnName = "tupian")]
		public string Tupian { get; set; }

		/// <summary>
		/// Desc: 作者
		/// </summary>
		[SugarColumn(ColumnName = "zuozhe")]
		public string Zuozhe { get; set; }

		/// <summary>
		/// Desc: 出版社
		/// </summary>
		[SugarColumn(ColumnName = "chubanshe")]
		public string Chubanshe { get; set; }

		/// <summary>
		/// Desc: 位置
		/// </summary>
		[SugarColumn(ColumnName = "weizhi")]
		public string Weizhi { get; set; }

		/// <summary>
		/// Desc: 评论数
		/// </summary>
        [SugarColumn(ColumnName = "discussnum")]
		public int? Discussnum { get; set; } = 0;

		/// <summary>
		/// Desc: 收藏数
		/// </summary>
        [SugarColumn(ColumnName = "storeupnum")]
		public int? Storeupnum { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
