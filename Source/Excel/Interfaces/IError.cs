﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.ExcelApi
{
    /// <summary>
    /// Interface IError 
    /// SupportByVersion Excel, 10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public interface IError : ICOMObject
    {
        #region Properties

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.Application Application { get; }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16), ProxyResult]
        object Parent { get; }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        bool Value { get; }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        bool Ignore { get; set; }

        #endregion
    }
}
