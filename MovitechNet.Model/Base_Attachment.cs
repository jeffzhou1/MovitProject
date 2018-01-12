    
using System;
namespace MovitechNet.Model 
{

		
      /// <summary>
      /// 数据表实体类：基础数据-附件信息
      /// </summary>
      public class Base_Attachment
      {    
		                 
			/// <summary>
			/// 
			/// </summary>
			public Guid Id {get;set;}   
			 
                 
			/// <summary>
			/// 原文件名
			/// </summary>
			public String OriginalName {get;set;}   
			 
                 
			/// <summary>
			/// 文件名
			/// </summary>
			public String FileName {get;set;}   
			 
                 
			/// <summary>
			/// 附件类型
			/// </summary>
			public String ContentType {get;set;}   
			 
                 
			/// <summary>
			/// 文件大小
			/// </summary>
			public Double ContentLength {get;set;}   
			 
                 
			/// <summary>
			/// 图片宽度
			/// </summary>
			public Nullable<Double> Width {get;set;}
			 
                 
			/// <summary>
			/// 图片高度
			/// </summary>
			public Nullable<Double> Height {get;set;}
			 
                 
			/// <summary>
			/// 文件后缀
			/// </summary>
			public String Extension {get;set;}   
			 
                 
			/// <summary>
			/// 所属表，直接存储附件关联的表名称
			/// </summary>
			public String OwnerTable {get;set;}   
			 
                 
			/// <summary>
			/// 所属记录ID
			/// </summary>
			public Nullable<Guid> OwnerRecordID {get;set;}
			 
                 
			/// <summary>
			/// 所属记录类型，根据程序枚举对应
			/// </summary>
			public String OwnerFlag {get;set;}   
			 
                 
			/// <summary>
			/// 上传人
			/// </summary>
			public String Uploader {get;set;}   
			 
                 
			/// <summary>
			/// 上传时间
			/// </summary>
			public Nullable<DateTime> UploadTime {get;set;}
			 
                 
			/// <summary>
			/// 数据是否有效
			/// </summary>
			public Boolean Enabled {get;set;}   
			 
       
    }    
}

	