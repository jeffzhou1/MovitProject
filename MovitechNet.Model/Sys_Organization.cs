    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：系统数据-组织架构
      /// </summary>
      public class Sys_Organization
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 组织ID
			/// </summary>
			public String OrgID {get;set;}   
			 
                 
			/// <summary>
			/// 父级组织ID
			/// </summary>
			public String ParentOrgID {get;set;}   
			 
                 
			/// <summary>
			/// 组织编码
			/// </summary>
			public String OrgCode {get;set;}   
			 
                 
			/// <summary>
			/// 组织名称
			/// </summary>
			public String OrgName {get;set;}   
			 
                 
			/// <summary>
			/// 组织层级，集团/城市公司/项目部
			/// </summary>
			public String OrgLevel {get;set;}   
			 
                 
			/// <summary>
			/// 显示排序
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
			/// 修改人
			/// </summary>
			public String Editor {get;set;}   
			 
                 
			/// <summary>
			/// 创建时间
			/// </summary>
			public Nullable<DateTime> CreateTime {get;set;}
			 
                 
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

	