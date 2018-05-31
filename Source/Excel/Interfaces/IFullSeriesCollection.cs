﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.ExcelApi
{
    /// <summary>
    /// Interface IFullSeriesCollection 
    /// SupportByVersion Excel, 15, 16
    /// </summary>
    [SupportByVersion("Excel", 15, 16)]
    [EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Method), HasIndexProperty(IndexInvoke.Method, "_Default")]
    public interface IFullSeriesCollection : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.Series>
    {
        #region Properties

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        NetOffice.ExcelApi.Application Application { get; }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 15, 16), ProxyResult]
        object Parent { get; }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        Int32 Count { get; }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Excel", 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        NetOffice.ExcelApi.Series this[object index] { get; }

        #endregion
    }
}
