    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：跟投数据-额度切分
      /// </summary>
      public class Invest_AllotSetting
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
			/// 切分金额
			/// </summary>
			public Decimal AllotMoney {get;set;}   
			 
                 
			/// <summary>
			/// 股权金额
			/// </summary>
			public Decimal StockMoney {get;set;}   
			 
                 
			/// <summary>
			/// 债权金额
			/// </summary>
			public Decimal DebtRightMoney {get;set;}   
			 
                 
			/// <summary>
			/// 切分的配资比例（强投人员）
			/// </summary>
			public Decimal AllotLever {get;set;}   
			 
                 
			/// <summary>
			/// 杠杆金额
			/// </summary>
			public Decimal LeverMoney {get;set;}   
			 
                 
			/// <summary>
			/// 首付款金额
			/// </summary>
			public Decimal FirstPayment {get;set;}   
			 
                 
			/// <summary>
			/// 垫资利息
			/// </summary>
			public Nullable<Decimal> LoaningInterest {get;set;}
			 
                 
			/// <summary>
			/// 审核状态，0：未审核，1：审核中，2：审核通过，3：审核不通过
			/// </summary>
			public Int32 AuditStatus {get;set;}   
			 
                 
			/// <summary>
			/// 审核意见
			/// </summary>
			public String AuditDesc {get;set;}   
			 
                 
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
			/// 数据来源，0：未定义，1：导入
			/// </summary>
			public Int32 DataSource {get;set;}   
			 
                 
			/// <summary>
			/// 备注
			/// </summary>
			public String Remarks {get;set;}   
			 
                 
			/// <summary>
			/// 备用字段1
			/// </summary>
			public String F1 {get;set;}   
			 
                 
			/// <summary>
			/// 备用字段
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

	