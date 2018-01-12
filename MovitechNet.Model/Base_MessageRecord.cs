    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：基础数据-消息发送记录
      /// </summary>
      public class Base_MessageRecord
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 项目ID
			/// </summary>
			public Nullable<Guid> ProjectID {get;set;}
			 
                 
			/// <summary>
			/// 消息性质，0：未定义，1：短信，2：邮件，3：企业微信消息
			/// </summary>
			public Nullable<Int32> MsgCategory {get;set;}
			 
                 
			/// <summary>
			/// 消息类型，0：未定义，1：项目预热，2：项目宣讲，3：报名截止（方案宣讲当天），4：报名截止（截止前一天）5：额度切分，6：打款截止（截止日前一天），7：打款截止（截止日上午），8：打款截止（截止日下午）9：签约截止（截止日前一周），10：签约截止（截止日前一天），11：签约截止（截止日当天），12：返本分红
			/// </summary>
			public Nullable<Int32> MsgType {get;set;}
			 
                 
			/// <summary>
			/// 发送时间
			/// </summary>
			public Nullable<DateTime> SendTime {get;set;}
			 
                 
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

	