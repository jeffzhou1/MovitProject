    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：项目数据-指标信息
      /// </summary>
      public class Project_Quota
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 项目ID
			/// </summary>
			public Guid ProjectID {get;set;}   
			 
                 
			/// <summary>
			/// 指标项
			/// </summary>
			public String QuotaKey {get;set;}   
			 
                 
			/// <summary>
			/// 指标名称
			/// </summary>
			public String QuotaName {get;set;}   
			 
                 
			/// <summary>
			/// 指标值
			/// </summary>
			public String QuotaValue {get;set;}   
			 
                 
			/// <summary>
			/// 指标类型,，1：总体评价指标
			/// </summary>
			public Nullable<Int32> QuotaType {get;set;}
			 
                 
			/// <summary>
			/// 指标单位，例如：平方，万元，元/ m2等
			/// </summary>
			public String QuotaUnit {get;set;}   
			 
                 
			/// <summary>
			/// 指标说明
			/// </summary>
			public String QuotaDesc {get;set;}   
			 
                 
			/// <summary>
			/// 父级指标项
			/// </summary>
			public String ParentKey {get;set;}   
			 
                 
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

	