using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 图书归还
    /// </summary>
    [SugarTable("tushuguihai")]
	public class TushuguihaiDbModel
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
		/// Desc: 手机号
		/// </summary>
		[SugarColumn(ColumnName = "shoujihao")]
		public string Shoujihao { get; set; }

		/// <summary>
		/// Desc: 归还时间
		/// </summary>
        [SugarColumn(ColumnName = "guihaishijian")]
		public DateTime? Guihaishijian { get; set; }

		/// <summary>
		/// Desc: 图片
		/// </summary>
		[SugarColumn(ColumnName = "tupian")]
		public string Tupian { get; set; }

		/// <summary>
		/// Desc: 跨表用户id
		/// </summary>
        [SugarColumn(ColumnName = "crossuserid")]
		public long? Crossuserid { get; set; } = 0;

		/// <summary>
		/// Desc: 跨表主键id
		/// </summary>
        [SugarColumn(ColumnName = "crossrefid")]
		public long? Crossrefid { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
