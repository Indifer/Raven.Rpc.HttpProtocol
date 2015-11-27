﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Rpc.IContractModel
{
    /// <summary>
    /// IRequestModel
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public interface IRequestModel<TData>
    {
        /// <summary>
        /// 数据
        /// </summary>
        TData Body { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class RequestModelBase<TData>
    {
        /// <summary>
        /// 数据
        /// </summary>
        public virtual TData Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Header Header { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Header
    {
        /// <summary>
        /// 
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RpcID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TrackID { get; set; }

    }

}
