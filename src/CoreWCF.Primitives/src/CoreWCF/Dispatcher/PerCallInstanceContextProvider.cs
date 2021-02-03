﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using CoreWCF.Channels;

namespace CoreWCF.Dispatcher
{
    internal class PerCallInstanceContextProvider : InstanceContextProviderBase
    {
        internal PerCallInstanceContextProvider(DispatchRuntime dispatchRuntime)
            : base(dispatchRuntime)
        {
        }

        #region IInstanceContextProvider Members

        public override InstanceContext GetExistingInstanceContext(Message message, IContextChannel channel)
        {
            //Always return null so we will create new InstanceContext for each message
            return null;
        }

        public override void InitializeInstanceContext(InstanceContext instanceContext, Message message, IContextChannel channel)
        {
            //no-op
        }

        public override bool IsIdle(InstanceContext instanceContext)
        {
            //By default return true if no channels are bound to this context
            return true;
        }

        public override void NotifyIdle(Action<InstanceContext> callback, InstanceContext instanceContext)
        {
            //no-op
        }

        #endregion
    }
}