    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：跟投数据-跟投转售详情
      /// </summary>
      public class Invest_Resale_Project
      {    
		                 
			/// <summary>
			/// 
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 
			/// </summary>
			public Guid ProjectId {get;set;}   
			 
                 
			/// <summary>
			/// 
			/// </summary>
			public String ProjectName {get;set;}   
			 
                 
			/// <summary>
			/// 
			/// </summary>
			public Guid ParentId {get;set;}   
			 
                 
			/// <summary>
			/// 数据是否有效
			/// </summary>
			public Boolean Enabled {get;set;}   
			 
       
    }    
}

	