    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：系统数据-角色权限
      /// </summary>
      public class Sys_Role_Option
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 角色ID
			/// </summary>
			public Guid RoleID {get;set;}   
			 
                 
			/// <summary>
			/// 控制器
			/// </summary>
			public String ControllerName {get;set;}   
			 
                 
			/// <summary>
			/// 视图
			/// </summary>
			public String ViewName {get;set;}   
			 
                 
			/// <summary>
			/// 操作选项，新增，删除，查询，修改，审核，其他
			/// </summary>
			public String Options {get;set;}   
			 
                 
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

	