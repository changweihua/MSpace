﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSpace.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	RssSource
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	RssSource
     * 创建时间:	2013/1/29 16:11:35
     * 作    者:	常伟华 Changweihua
	 * 版    权:	RssSource说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	2ae1a53d-4d3a-446a-9495-ef28d0f43a93  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 摘要
    /// </summary>
    public class RssSource
    {
        public int Id { get; set; }
        [Display(Name="RSS源名称")]
        [Required(ErrorMessage="{0} 必须填写")]
        public string SourceName { get; set; }
        [Display(Name = "RSS源链接")]
        [Required(ErrorMessage = "{0} 必须填写")]
        public string SourceUrl { get; set; }
        [Display(Name = "RSS源描述")]
        [Required(ErrorMessage = "{0} 必须填写")]
        public string SourceDescription { get; set; }
    }
}