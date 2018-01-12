    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：跟投数据-转售信息
      /// </summary>
      public class Invest_Resale
      {    
		                 
			/// <summary>
			/// 
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 被转售人（离职人员）
			/// </summary>
			public String BeResaleUserID {get;set;}   
			 
                 
			/// <summary>
			/// 转售接收人
			/// </summary>
			public String ResaleUserID {get;set;}   
			 
                 
			/// <summary>
			/// 转售金额
			/// </summary>
			public Decimal ResaleAmount {get;set;}   
			 
                 
			/// <summary>
			/// 转售时间
			/// </summary>
			public Nullable<DateTime> ResaleTime {get;set;}
			 
                 
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

	