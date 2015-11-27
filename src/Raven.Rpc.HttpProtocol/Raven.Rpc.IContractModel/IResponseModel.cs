﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Rpc.IContractModel
{
    /// <summary>
    /// IResponseModel
    /// </summary>
    /// <typeparam name="TCode"></typeparam>
    public interface IResponseModel<TCode>
    {
        /// <summary>
        /// 结果编码，1为成功
        /// </summary>
        TCode Code { get; set; }
    }

    /// <summary>
    /// IResponseModel
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    /// <typeparam name="TCode"></typeparam>
    public interface IResponseModel<TData, TCode> : IResponseModel<TCode>
    {
        /// <summary>
        /// 数据
        /// </summary>
        TData Data { get; set; }
    }

    /// <summary>
    /// ResponseModelBase
    /// </summary>
    /// <typeparam name="TCode"></typeparam>
    public class ResponseModelBase<TCode> : IResponseModel<TCode>
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual TCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Ext")]
        public virtual KeyValue<string, string>[] Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Msg")]
        public virtual string Message { get; set; }
    }

    /// <summary>
    /// ResponseModelBase
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    /// <typeparam name="TCode"></typeparam>
    public class ResponseModelBase<TData, TCode> : ResponseModelBase<TCode>
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual TData Data { get; set; }        
    }


}
