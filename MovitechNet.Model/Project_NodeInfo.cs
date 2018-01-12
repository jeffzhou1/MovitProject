    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：项目数据-节点信息
      /// </summary>
      public class Project_NodeInfo
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
			/// 节点类型，1：运营节点，2：销售节点，3：成本节点,，4：跟投方案
			/// </summary>
			public Int32 NodeCategory {get;set;}   
			 
                 
			/// <summary>
			/// 节点名称
			/// </summary>
			public String NodeName {get;set;}   
			 
                 
			/// <summary>
			/// 节点顺序
			/// </summary>
			public Int32 NodeSort {get;set;}   
			 
                 
			/// <summary>
			/// 节点计划值：日期格式，例如：2017-01-01
			/// </summary>
			public Nullable<DateTime> NodePlanValue {get;set;}
			 
                 
			/// <summary>
			/// 节点实际值：日期格式，例如：2017-02-01
			/// </summary>
			public Nullable<DateTime> NodeRealValue {get;set;}
			 
                 
			/// <summary>
			/// 节点计划值，字符串类型
			/// </summary>
			public String NodePlanValueStr {get;set;}   
			 
                 
			/// <summary>
			/// 节点实际值，字符串类型
			/// </summary>
			public String NodeRealValueStr {get;set;}   
			 
                 
			/// <summary>
			/// 节点计划值（数字）
			/// </summary>
			public Nullable<Int32> NodePlanValueInt {get;set;}
			 
                 
			/// <summary>
			/// 节点实际值（数字）
			/// </summary>
			public Nullable<Int32> NodeRealValueInt {get;set;}
			 
                 
			/// <summary>
			/// 是否为当前执行节点（跟投方案节点=4根据计划完成时间与当前时间进行判断，不要用此字段判断）
			/// </summary>
			public Boolean IsCurrent {get;set;}   
			 
                 
			/// <summary>
			/// 节点是否显示
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
			/// 审核状态，0：未审核，1：审核中，2：审核通过，3：审核不通过
			/// </summary>
			public Int32 AuditState {get;set;}   
			 
                 
			/// <summary>
			/// 审核意见
			/// </summary>
			public String AuditDesc {get;set;}   
			 
                 
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

	