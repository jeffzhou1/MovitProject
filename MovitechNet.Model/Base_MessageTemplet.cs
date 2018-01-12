    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：基础数据-消息模板
      /// </summary>
      public class Base_MessageTemplet
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 消息类型，0：未定义，1：项目预热，2：项目宣讲，3：报名截止（方案宣讲当天），4：报名截止（截止前一天）5：额度切分，6：打款截止（截止日前一天），7：打款截止（截止日上午），8：打款截止（截止日下午）9：签约截止（截止日前一周），10：签约截止（截止日前一天），11：签约截止（截止日当天），12：返本分红
			/// </summary>
			public Int32 MsgType {get;set;}   
			 
                 
			/// <summary>
			/// 消息性质，0：未定义，1：短信，2：邮件，3：企业微信消息
			/// </summary>
			public Int32 MsgCategory {get;set;}   
			 
                 
			/// <summary>
			/// 消息标题
			/// </summary>
			public String MsgTitle {get;set;}   
			 
                 
			/// <summary>
			/// 消息内容
			/// </summary>
			public String MsgContent {get;set;}   
			 
                 
			/// <summary>
			/// 创建人
			/// </summary>
			public String Creator {get;set;}   
			 
                 
			/// <summary>
			/// 修改人
			/// </summary>
			public String Editor {get;set;}   
			 
                 
			/// <summary>
			/// 创建时间
			/// </summary>
			public Nullable<DateTime> CreateTime {get;set;}
			 
                 
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

	