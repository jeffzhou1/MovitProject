    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：基础数据-协议模板
      /// </summary>
      public class Base_AgreementTemplet
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 协议类型，0：未定义，1：强投协议，2：自愿协议
			/// </summary>
			public Int32 TempletType {get;set;}   
			 
                 
			/// <summary>
			/// 模板标题
			/// </summary>
			public String TempletTitle {get;set;}   
			 
                 
			/// <summary>
			/// 模板内容：内容中需要动态变化的内容预留{0}，{1}...参数模式填充
			/// </summary>
			public String TempletContent {get;set;}   
			 
                 
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

	