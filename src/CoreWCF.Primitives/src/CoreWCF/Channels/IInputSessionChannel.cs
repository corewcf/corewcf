// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace CoreWCF.Channels
{
    public interface IInputSessionChannel : IChannel, IInputChannel, ISessionChannel<IInputSession>, ICommunicationObject
    {
    }
}