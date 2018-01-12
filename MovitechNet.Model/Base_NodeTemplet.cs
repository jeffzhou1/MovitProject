    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：基础数据-节点模板
      /// </summary>
      public class Base_NodeTemplet
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 节点类型，1：项目运营节点，2：项目销售节点，3：项目成本节点，4：项目方案节点
			/// </summary>
			public Nullable<Int32> NodeType {get;set;}
			 
                 
			/// <summary>
			/// 节点名称
			/// </summary>
			public String NodeName {get;set;}   
			 
                 
			/// <summary>
			/// 节点顺序
			/// </summary>
			public Int32 Sort {get;set;}   
			 
                 
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

	