    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：项目数据-收益信息
      /// </summary>
      public class Project_Profit
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
			/// 数据版本，月份，例如：2017-02 ，宣讲会发布的时候存储为当前月份，投中信息选择具体的月份
			/// </summary>
			public String DataVersion {get;set;}   
			 
                 
			/// <summary>
			/// 杠杆倍数，存数字，例如：0，1，2，3（字段已弃用）
			/// </summary>
			public String LeverTimes {get;set;}   
			 
                 
			/// <summary>
			/// 投资回报率（0倍杠杆）
			/// </summary>
			public String RepayRate {get;set;}   
			 
                 
			/// <summary>
			/// 投资回报率（1倍杠杆）
			/// </summary>
			public String RepayRate1 {get;set;}   
			 
                 
			/// <summary>
			/// 投资回报率（2倍杠杆）
			/// </summary>
			public String RepayRate2 {get;set;}   
			 
                 
			/// <summary>
			/// 投资回报率（3倍杠杆）
			/// </summary>
			public String RepayRate3 {get;set;}   
			 
                 
			/// <summary>
			/// 返本时间
			/// </summary>
			public Nullable<DateTime> CorpusReturnTime {get;set;}
			 
                 
			/// <summary>
			/// 分红时间
			/// </summary>
			public Nullable<DateTime> BonusReturnTime {get;set;}
			 
                 
			/// <summary>
			/// 数据类型，0：未定义，1：跟投收益（投资回报率），2：跟投收益（年化投资回报率），3：返本分红时间
			/// </summary>
			public Int32 DataType {get;set;}   
			 
                 
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

	