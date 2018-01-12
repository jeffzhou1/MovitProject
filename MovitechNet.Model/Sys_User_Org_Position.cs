    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：系统数据-人员-组织-岗位关系表
      /// </summary>
      public class Sys_User_Org_Position
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 所属部门ID
			/// </summary>
			public String OrgID {get;set;}   
			 
                 
			/// <summary>
			/// 所属城市公司ID
			/// </summary>
			public String BaseOrgID {get;set;}   
			 
                 
			/// <summary>
			/// 用户ID
			/// </summary>
			public String UserID {get;set;}   
			 
                 
			/// <summary>
			/// 职位ID
			/// </summary>
			public String PositionID {get;set;}   
			 
                 
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

	