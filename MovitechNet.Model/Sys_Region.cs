    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：城市地区
      /// </summary>
      public class Sys_Region
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Int32 id {get;set;}   
			 
                 
			/// <summary>
			/// 地区名称
			/// </summary>
			public String areaname {get;set;}   
			 
                 
			/// <summary>
			/// 父级ID
			/// </summary>
			public Nullable<Int32> parentid {get;set;}
			 
                 
			/// <summary>
			/// 行政隶属（直接关联上级行政区域ID）
			/// </summary>
			public Nullable<Int32> subjection {get;set;}
			 
                 
			/// <summary>
			/// 所属省份ID
			/// </summary>
			public Nullable<Int32> province {get;set;}
			 
                 
			/// <summary>
			/// 简称
			/// </summary>
			public String shortname {get;set;}   
			 
                 
			/// <summary>
			/// 地区编码
			/// </summary>
			public Nullable<Int32> areacode {get;set;}
			 
                 
			/// <summary>
			/// 邮编
			/// </summary>
			public Nullable<Int32> zipcode {get;set;}
			 
                 
			/// <summary>
			/// 拼音
			/// </summary>
			public String pinyin {get;set;}   
			 
                 
			/// <summary>
			/// 经度
			/// </summary>
			public Nullable<Decimal> lng {get;set;}
			 
                 
			/// <summary>
			/// 纬度
			/// </summary>
			public Nullable<Decimal> lat {get;set;}
			 
                 
			/// <summary>
			/// 等级，1：省份，2：城市，3：地区
			/// </summary>
			public Nullable<Byte> level {get;set;}
			 
                 
			/// <summary>
			/// 位置（表格显示）
			/// </summary>
			public String position {get;set;}   
			 
                 
			/// <summary>
			/// 排序
			/// </summary>
			public Nullable<Byte> sort {get;set;}
			 
                 
			/// <summary>
			/// 是否为重点关注区域
			/// </summary>
			public Boolean ispoint {get;set;}   
			 
                 
			/// <summary>
			/// 是否需要显示在首页地图
			/// </summary>
			public Boolean isshowmap {get;set;}   
			 
                 
			/// <summary>
			/// 进驻状态，0：未进驻，1：已进驻，2：拟进驻
			/// </summary>
			public Int32 isenter {get;set;}   
			 
                 
			/// <summary>
			/// 项目数量
			/// </summary>
			public Int32 projectcount {get;set;}   
			 
                 
			/// <summary>
			/// 修改人
			/// </summary>
			public String modifyuser {get;set;}   
			 
                 
			/// <summary>
			/// 修改时间
			/// </summary>
			public Nullable<DateTime> modifytime {get;set;}
			 
                 
			/// <summary>
			/// 城市等级，1.一线，2.二线，3.三线，4.四线
			/// </summary>
			public Nullable<Int32> citygrade {get;set;}
			 
       
    }    
}

	