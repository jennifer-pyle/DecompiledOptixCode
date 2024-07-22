// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.BaseNetLogic
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using System;

using FTOptix.Core;

using UAManagedCore;
////#nullable disable

namespace FTOptix.NetLogic
{
    public abstract class BaseNetLogic : IDisposable
    {
        private bool disposedValue;

        internal void Initialize(NetLogicObject logicNode)
        {
            this.LogicObject = (IUAObject)logicNode;
            this.Session = (Session)logicNode.Context.Sessions.CurrentSessionInfo.SessionObject;
        }

        public virtual void Start()
        {
        }

        public virtual void Stop() => this.Dispose();

        public void Dispose() => this.Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposedValue)
                return;
            if (disposing)
                DisposableFieldDisposing.DisposeFields(this.GetType(), (object)this);
            this.disposedValue = true;
        }

        protected IUAObject LogicObject { get; private set; }

        protected IUANode Owner => this.LogicObject.Owner;

        protected Session Session { get; private set; }
    }
}