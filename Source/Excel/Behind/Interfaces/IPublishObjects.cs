﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface IPublishObjects 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public class IPublishObjects : COMObject, NetOffice.ExcelApi.IPublishObjects
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Instance Type        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IPublishObjects);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <param name="factory">current used factory core</param>
		/// <param name="parentObject">object there has created the proxy</param>
		/// <param name="proxyShare">proxy share instead if com proxy</param>
		public IPublishObjects(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
		{
		}

		///<param name="factory">current used factory core</param>		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IPublishObjects(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPublishObjects(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPublishObjects(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPublishObjects(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPublishObjects(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPublishObjects() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPublishObjects(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.ExcelApi.PublishObject this[object index]
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.PublishObject>(this, "_Default", typeof(NetOffice.ExcelApi.PublishObject), index);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlSourceType sourceType</param>
		/// <param name="filename">string filename</param>
		/// <param name="sheet">optional object sheet</param>
		/// <param name="source">optional object source</param>
		/// <param name="htmlType">optional object htmlType</param>
		/// <param name="divID">optional object divID</param>
		/// <param name="title">optional object title</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.PublishObject Add(NetOffice.ExcelApi.Enums.XlSourceType sourceType, string filename, object sheet, object source, object htmlType, object divID, object title)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PublishObject>(this, "Add", typeof(NetOffice.ExcelApi.PublishObject), new object[]{ sourceType, filename, sheet, source, htmlType, divID, title });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlSourceType sourceType</param>
		/// <param name="filename">string filename</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.PublishObject Add(NetOffice.ExcelApi.Enums.XlSourceType sourceType, string filename)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PublishObject>(this, "Add", typeof(NetOffice.ExcelApi.PublishObject), sourceType, filename);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlSourceType sourceType</param>
		/// <param name="filename">string filename</param>
		/// <param name="sheet">optional object sheet</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.PublishObject Add(NetOffice.ExcelApi.Enums.XlSourceType sourceType, string filename, object sheet)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PublishObject>(this, "Add", typeof(NetOffice.ExcelApi.PublishObject), sourceType, filename, sheet);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlSourceType sourceType</param>
		/// <param name="filename">string filename</param>
		/// <param name="sheet">optional object sheet</param>
		/// <param name="source">optional object source</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.PublishObject Add(NetOffice.ExcelApi.Enums.XlSourceType sourceType, string filename, object sheet, object source)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PublishObject>(this, "Add", typeof(NetOffice.ExcelApi.PublishObject), sourceType, filename, sheet, source);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlSourceType sourceType</param>
		/// <param name="filename">string filename</param>
		/// <param name="sheet">optional object sheet</param>
		/// <param name="source">optional object source</param>
		/// <param name="htmlType">optional object htmlType</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.PublishObject Add(NetOffice.ExcelApi.Enums.XlSourceType sourceType, string filename, object sheet, object source, object htmlType)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PublishObject>(this, "Add", typeof(NetOffice.ExcelApi.PublishObject), new object[]{ sourceType, filename, sheet, source, htmlType });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlSourceType sourceType</param>
		/// <param name="filename">string filename</param>
		/// <param name="sheet">optional object sheet</param>
		/// <param name="source">optional object source</param>
		/// <param name="htmlType">optional object htmlType</param>
		/// <param name="divID">optional object divID</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public NetOffice.ExcelApi.PublishObject Add(NetOffice.ExcelApi.Enums.XlSourceType sourceType, string filename, object sheet, object source, object htmlType, object divID)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PublishObject>(this, "Add", typeof(NetOffice.ExcelApi.PublishObject), new object[]{ sourceType, filename, sheet, source, htmlType, divID });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Delete()
		{
			return Factory.ExecuteInt32MethodGet(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Publish()
		{
			return Factory.ExecuteInt32MethodGet(this, "Publish");
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.PublishObject>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.PublishObject>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.PublishObject>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.PublishObject>

        /// <summary>
        /// SupportByVersion Excel, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public IEnumerator<NetOffice.ExcelApi.PublishObject> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.PublishObject item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

