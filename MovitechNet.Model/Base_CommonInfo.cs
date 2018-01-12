    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：基础数据-公共信息
      /// </summary>
      public class Base_CommonInfo
      {    
		                 
			/// <summary>
			/// 主键ID
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 信息类型，0：未定义，1：动态新闻，2：公告信息，3：消息推送，4：邮件发送记录，5:短信发送记录
			/// </summary>
			public Int32 InfoType {get;set;}   
			 
                 
			/// <summary>
			/// 信息接收人
			/// </summary>
			public String Receiver {get;set;}   
			 
                 
			/// <summary>
			/// 信息发送人
			/// </summary>
			public String Sender {get;set;}   
			 
                 
			/// <summary>
			/// 信息标题
			/// </summary>
			public String InfoTitle {get;set;}   
			 
                 
			/// <summary>
			/// 信息内容
			/// </summary>
			public String InfoContent {get;set;}   
			 
                 
			/// <summary>
			/// 发送时间
			/// </summary>
			public Nullable<DateTime> SendTime {get;set;}
			 
                 
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

	