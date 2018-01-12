    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：跟投数据-缴款信息
      /// </summary>
      public class Invest_Payment
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
			/// 流水号
			/// </summary>
			public String SerialNo {get;set;}   
			 
                 
			/// <summary>
			/// 缴款金额
			/// </summary>
			public Decimal PayMoney {get;set;}   
			 
                 
			/// <summary>
			/// 追加缴款记录（存储追加缴款的目标日期）
			/// </summary>
			public String DataVersion {get;set;}   
			 
                 
			/// <summary>
			/// 缴款时间
			/// </summary>
			public Nullable<DateTime> PayTime {get;set;}
			 
                 
			/// <summary>
			/// 缴款方式，0：未定义，1：线下缴款，2：线上缴款
			/// </summary>
			public Int32 PayType {get;set;}   
			 
                 
			/// <summary>
			/// 用户是否确认缴款
			/// </summary>
			public Boolean IsUserConfirm {get;set;}   
			 
                 
			/// <summary>
			/// 是否确认收款
			/// </summary>
			public Boolean IsConfirmPay {get;set;}   
			 
                 
			/// <summary>
			/// 收款确认时间
			/// </summary>
			public Nullable<DateTime> ConfirmTime {get;set;}
			 
                 
			/// <summary>
			/// 收款确认人
			/// </summary>
			public String ConfirmUserID {get;set;}   
			 
                 
			/// <summary>
			/// 备注
			/// </summary>
			public String Remarks {get;set;}   
			 
                 
			/// <summary>
			/// 审核状态，0：未审核，1：审核通过，2：审核不通过
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

	