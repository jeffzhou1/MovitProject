    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：系统数据-职位信息
      /// </summary>
      public class Sys_Position
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 职位ID
			/// </summary>
			public String PositionId {get;set;}   
			 
                 
			/// <summary>
			/// 职位名称
			/// </summary>
			public String PositionName {get;set;}   
			 
                 
			/// <summary>
			/// 所属组织架构ID
			/// </summary>
			public String OrgID {get;set;}   
			 
                 
			/// <summary>
			/// 上级职位ID
			/// </summary>
			public String ParentPositionID {get;set;}   
			 
                 
			/// <summary>
			/// 职位编制数量
			/// </summary>
			public String PositionNum {get;set;}   
			 
                 
			/// <summary>
			/// 职位等级
			/// </summary>
			public String PositionLevel {get;set;}   
			 
                 
			/// <summary>
			/// 排序
			/// </summary>
			public Int32 Sort {get;set;}   
			 
                 
			/// <summary>
			/// 是否显示
			/// </summary>
			public Boolean IsShow {get;set;}   
			 
                 
			/// <summary>
			/// 创建人
			/// </summary>
			public String Creator {get;set;}   
			 
                 
			/// <summary>
			/// 创建时间
			/// </summary>
			public Nullable<DateTime> CreateTime {get;set;}
			 
                 
			/// <summary>
			/// 修改人
			/// </summary>
			public String Editor {get;set;}   
			 
                 
			/// <summary>
			/// 修改时间
			/// </summary>
			public Nullable<DateTime> EditTime {get;set;}
			 
                 
			/// <summary>
			/// 备用字段1
			/// </summary>
			public String F1 {get;set;}   
			 
                 
			/// <summary>
			/// 备用字段2
			/// </summary>
			public String F2 {get;set;}   
			 
                 
			/// <summary>
			/// 备用字段3
			/// </summary>
			public String F3 {get;set;}   
			 
                 
			/// <summary>
			/// 数据是否有效
			/// </summary>
			public Boolean Enabled {get;set;}   
			 
       
    }    
}

	