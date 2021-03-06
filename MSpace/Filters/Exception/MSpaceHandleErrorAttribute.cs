﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Filters.Exception
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	MSpaceHandleErrorAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Filters
     * 文 件 名:	MSpaceHandleErrorAttribute
     * 创建时间:	2013/3/17 12:12:48
     * 作    者:	常伟华 Changweihua
	 * 版    权:	MSpaceHandleErrorAttribute说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	98636e8a-e3d3-47c4-b3aa-1d13f1650104  
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
    public class MSpaceHandleErrorAttribute : HandleErrorAttribute 
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            filterContext.Result = new RedirectResult("http://www.cmono.net");
            filterContext.ExceptionHandled = true;  //标志异常已经被处理，不加，则会继续执行
        }

    }
}