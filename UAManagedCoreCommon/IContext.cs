// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IContext
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface IContext
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    INodeFactory NodeFactory { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISessions Sessions { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsDisposed { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUANode GetNode(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAObject GetObject(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAObjectType GetObjectType(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariable GetVariable(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariableType GetVariableType(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAReferenceType GetReferenceType(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUADataType GetDataType(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAMethod GetMethod(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUANode GetNodeInternal(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ITransactionResource CreateGenericTransaction(LockType referencesLockType);

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsCurrentThreadInTransaction { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    uint CurrentThreadTransactionId { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    DateTime CurrentThreadTransactionTimestamp { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    ulong AssignSenderId();

    [EditorBrowsable(EditorBrowsableState.Never)]
    ulong CurrentThreadSenderId { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IDisposable SetCurrentThreadSenderId(ulong senderId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    int AssignNamespaceIndex(string namespaceUri, string serverUri = "", NamespaceType namespaceType = NamespaceType.Dynamic);

    [EditorBrowsable(EditorBrowsableState.Never)]
    int GetNamespaceIndex(string namespaceUri);

    [EditorBrowsable(EditorBrowsableState.Never)]
    string GetNamespaceUri(int namespaceIndex);

    [EditorBrowsable(EditorBrowsableState.Never)]
    NamespaceInfo GetNamespaceInfo(int namespaceIndex);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IReadOnlyList<int> GetNamespaceIndexes();

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsValidNamespaceIndex(int namespaceIndex);

    [EditorBrowsable(EditorBrowsableState.Never)]
    int DefaultNamespaceIndex { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    string GetAggregatedNamespaceUri(string namespaceUri, string serverUri);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void RegisterTransactionCoordinator(ITransactionCoordinator coordinator);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ITransactionCoordinator UnregisterTransactionCoordinator();

    [EditorBrowsable(EditorBrowsableState.Never)]
    ITransactionCoordinator GetTransactionCoordinator();

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetValue(IUAVariable variable, object value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetValue(IUAVariable variable, object value, uint[] index);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetValue(IEnumerable<VariableValue> items);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void GetValue(IEnumerable<VariableValue> items);

    [EditorBrowsable(EditorBrowsableState.Never)]
    LockType GetLockTypeForNode(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    uint GetLockedNodesCount();

    [EditorBrowsable(EditorBrowsableState.Never)]
    IDisposable DisableThreadSecurityChecks();

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool SecurityChecksEnabled { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IContextExtensions Extensions { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    LocalizedText LookupTranslation(LocalizedText localizedText);

    [EditorBrowsable(EditorBrowsableState.Never)]
    LocalizedText LookupTranslation(LocalizedText localizedText, IReadOnlyList<string> localeIds);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IReadOnlyList<TranslationItem> GetTranslationKeys(int namespaceIndex, string localeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetTranslation(LocalizedText localizedText);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariable GetLocalizationDictionary(LocalizedText localizedText);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IDisposable LockReferencesIfNotLocked(LockType lockType);

    [EditorBrowsable(EditorBrowsableState.Never)]
    LockType GetCurrentThreadReferencesLockType();

    [EditorBrowsable(EditorBrowsableState.Never)]
    void DispatchUAEvent(
      IUAObject startingNotifier,
      IUAObjectType eventType,
      IReadOnlyList<object> eventArgs);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void LoadModule(string moduleName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void LoadModule(string moduleName, string version);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ForceModuleImplLoad(string modulename);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void LoadLocalizationDictionary(IReadOnlyList<string> locales, string moduleName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void LoadCoreLocalizationDictionary(IReadOnlyList<string> locales);

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsModuleRegistered(string moduleName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsModuleLoaded(string moduleName);

    string GetModuleLibraryDirectory(string moduleName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    string FormatToPathNodeId(NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    uint AssignAffinityId();

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Dispatch(Action action, uint affinityId = 0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IDisposable SuspendDispatch(uint affinityId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IDisposable TerminateDispatchOnStop(uint affinityId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    string GetProjectDirectory(int namespaceIndex);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetProjectDirectory(int namespaceIndex, string directory);

    [EditorBrowsable(EditorBrowsableState.Never)]
    string GetApplicationDirectory(int namespaceIndex);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetApplicationDirectory(int namespaceIndex, string directory);

    [EditorBrowsable(EditorBrowsableState.Never)]
    string GetBindingsFolder();

    [EditorBrowsable(EditorBrowsableState.Never)]
    PathResolverResult ResolvePath(string path);

    [EditorBrowsable(EditorBrowsableState.Never)]
    PathResolverResult ResolvePath(IUANode node, string path);

    [EditorBrowsable(EditorBrowsableState.Never)]
    int NodeCount { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IEnumerable<RemoteVariableValue> RemoteRead(
      IEnumerable<RemoteVariable> variables,
      double timeoutMilliseconds = 30000.0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void RemoteWrite(IEnumerable<RemoteVariableValue> variableValues, double timeoutMilliseconds = 30000.0);
  }
}
