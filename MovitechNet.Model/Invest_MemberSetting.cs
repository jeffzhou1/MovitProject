    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：跟投数据-人员设置
      /// </summary>
      public class Invest_MemberSetting
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 用户ID
			/// </summary>
			public String UserID {get;set;}   
			 
                 
			/// <summary>
			/// 项目ID
			/// </summary>
			public Guid ProjectID {get;set;}   
			 
                 
			/// <summary>
			/// 跟投性质，0：未定义，1：强投，2：优先，3：自愿
			/// </summary>
			public Int32 InvestCategory {get;set;}   
			 
                 
			/// <summary>
			/// 跟投额度上限
			/// </summary>
			public Decimal MoneyUpperLimit {get;set;}   
			 
                 
			/// <summary>
			/// 跟投额度下限
			/// </summary>
			public Decimal MoneyLowerLimit {get;set;}   
			 
                 
			/// <summary>
			/// 配资比例上限（强投人员）
			/// </summary>
			public Nullable<Decimal> LeverTimeUP {get;set;}
			 
                 
			/// <summary>
			/// 当前进度，0：未开始，1：已报名，2：已缴款，3：已签约，4；已结算
			/// </summary>
			public Int32 CurrentStatus {get;set;}   
			 
                 
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
			/// 备注
			/// </summary>
			public String Remarks {get;set;}   
			 
                 
			/// <summary>
			/// 备用字段1：设置强投人员的配资比例上限
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
			 
                 
			/// <summary>
			/// 审核状态，0：未审核，1：审核中，2：审核通过，3：审核不通过
			/// </summary>
			public Int32 AuditState {get;set;}   
			 
                 
			/// <summary>
			/// 审核意见
			/// </summary>
			public String AuditDesc {get;set;}   
			 
       
    }    
}

	