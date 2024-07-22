// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UACoreContext
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UAManagedCore.ExternalVariableSynchronizer;

#nullable disable
namespace UAManagedCore
{
  public class UACoreContext : IContext, IDisposable
  {
    internal IntPtr nativeContextPtr;
    private bool disposed;
    private ISynchronizerContext synchronizerContext;

    internal UACoreContext(IntPtr nativeContext)
    {
      this.nativeContextPtr = nativeContext;
      this.NodeFactory = (INodeFactory) new UAManagedCore.NodeFactory(nativeContext);
      this.Sessions = (ISessions) new UAManagedCore.Sessions(nativeContext);
      this.synchronizerContext = (ISynchronizerContext) new SynchronizerContextWrapper((IContext) this, TimeSpan.FromMilliseconds(100.0));
    }

    public int AssignNamespaceIndex(
      string namespaceUri,
      string serverUri = "",
      NamespaceType namespaceType = NamespaceType.Dynamic)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextAssignNamespaceIndex(this.nativeContextPtr, namespaceUri, serverUri, (int) namespaceType);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetInt();
    }

    public int GetNamespaceIndex(string namespaceUri)
    {
      InteropCallResult namespaceIndex = UACoreContext.Interop.UACoreContextGetNamespaceIndex(this.nativeContextPtr, namespaceUri);
      namespaceIndex.CheckOutcome();
      return namespaceIndex.GetInt();
    }

    public string GetBindingsFolder()
    {
      InteropCallResult bindingsFolder = UACoreContext.Interop.UACoreContextGetBindingsFolder(this.nativeContextPtr);
      bindingsFolder.CheckOutcome();
      return bindingsFolder.GetString();
    }

    public string GetModuleVersion(string moduleName)
    {
      InteropCallResult moduleVersion = UACoreContext.Interop.UACoreContextGetModuleVersion(this.nativeContextPtr, moduleName);
      moduleVersion.CheckOutcome();
      return moduleVersion.GetString();
    }

    public string GetModuleLibraryFilePath(string moduleName, string version)
    {
      InteropCallResult moduleLibraryFilePath = UACoreContext.Interop.UACoreContextGetModuleLibraryFilePath(this.nativeContextPtr, moduleName, version);
      moduleLibraryFilePath.CheckOutcome();
      return moduleLibraryFilePath.GetString();
    }

    public IUANode GetNode(NodeId nodeId)
    {
      InteropCallResult node = UACoreContext.Interop.UACoreContextGetNode(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      node.CheckOutcome();
      return (IUANode) node.Get<UANode>();
    }

    public NamespaceInfo GetNamespaceInfo(int namespaceIndex)
    {
      InteropCallResult namespaceInfo = UACoreContext.Interop.UACoreContextGetNamespaceInfo(this.nativeContextPtr, namespaceIndex);
      namespaceInfo.CheckOutcome();
      return (NamespaceInfo) namespaceInfo.GetStruct<NamespaceInfoInterop>();
    }

    public IReadOnlyList<int> GetNamespaceIndexes()
    {
      InteropCallResult namespaceIndexes = UACoreContext.Interop.UACoreContextGetNamespaceIndexes(this.nativeContextPtr);
      namespaceIndexes.CheckOutcome();
      return (IReadOnlyList<int>) namespaceIndexes.GetIntArray();
    }

    public void Dispatch(Action action, uint affinityId = 0)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      UACoreContext.Interop.ContextDispatch(this.nativeContextPtr, Marshal.GetFunctionPointerForDelegate<Action>(action), action, affinityId).CheckOutcome();
    }

    public IUAObject GetObject(NodeId nodeId)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextGetObject(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      interopCallResult.CheckOutcome();
      return (IUAObject) interopCallResult.Get<UAObject>();
    }

    public IUAObjectType GetObjectType(NodeId nodeId)
    {
      InteropCallResult objectType = UACoreContext.Interop.UACoreContextGetObjectType(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      objectType.CheckOutcome();
      return (IUAObjectType) objectType.Get<UAObjectType>();
    }

    public IUAVariable GetVariable(NodeId nodeId)
    {
      InteropCallResult variable = UACoreContext.Interop.UACoreContextGetVariable(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      variable.CheckOutcome();
      return (IUAVariable) variable.Get<UAVariable>();
    }

    public IUAVariableType GetVariableType(NodeId nodeId)
    {
      InteropCallResult variableType = UACoreContext.Interop.UACoreContextGetVariableType(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      variableType.CheckOutcome();
      return (IUAVariableType) variableType.Get<UAVariableType>();
    }

    public IUAReferenceType GetReferenceType(NodeId nodeId)
    {
      InteropCallResult referenceType = UACoreContext.Interop.UACoreContextGetReferenceType(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      referenceType.CheckOutcome();
      return (IUAReferenceType) referenceType.Get<UAReferenceType>();
    }

    public IUADataType GetDataType(NodeId nodeId)
    {
      InteropCallResult dataType = UACoreContext.Interop.UACoreContextGetDataType(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      dataType.CheckOutcome();
      return (IUADataType) dataType.Get<UADataType>();
    }

    public IUAMethod GetMethod(NodeId nodeId)
    {
      InteropCallResult method = UACoreContext.Interop.UACoreContextGetMethod(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      method.CheckOutcome();
      return (IUAMethod) method.Get<UAMethod>();
    }

    public IUANode GetNodeInternal(NodeId nodeId)
    {
      InteropCallResult nodeInternal = UACoreContext.Interop.UACoreContextGetNodeInternal(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      nodeInternal.CheckOutcome();
      return (IUANode) nodeInternal.Get<UANode>();
    }

    public ITransactionResource CreateGenericTransaction(LockType referencesLockType)
    {
      InteropCallResult genericTransaction = UACoreContext.Interop.UACoreContextCreateGenericTransaction(this.nativeContextPtr, (int) referencesLockType);
      genericTransaction.CheckOutcome();
      return (ITransactionResource) genericTransaction.Get<TransactionResource>();
    }

    public ulong AssignSenderId()
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextAssignSenderId(this.nativeContextPtr);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetULong();
    }

    public IDisposable SetCurrentThreadSenderId(ulong senderId)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextSetCurrentThreadSenderId(this.nativeContextPtr, senderId);
      interopCallResult.CheckOutcome();
      return (IDisposable) new OnScopeExit(interopCallResult.Get<OnScopeExitSafeHandle>());
    }

    public string GetNamespaceUri(int namespaceIndex)
    {
      InteropCallResult namespaceUri = UACoreContext.Interop.UACoreContextGetNamespaceUri(this.nativeContextPtr, namespaceIndex);
      namespaceUri.CheckOutcome();
      return namespaceUri.GetString();
    }

    public bool IsValidNamespaceIndex(int namespaceIndex) => namespaceIndex >= 0;

    public string GetAggregatedNamespaceUri(string namespaceUri, string serverUri)
    {
      InteropCallResult aggregatedNamespaceUri = UACoreContext.Interop.UACoreContextGetAggregatedNamespaceUri(this.nativeContextPtr, namespaceUri, serverUri);
      aggregatedNamespaceUri.CheckOutcome();
      return aggregatedNamespaceUri.GetString();
    }

    public void RegisterTransactionCoordinator(ITransactionCoordinator coordinator)
    {
      throw new NotImplementedException();
    }

    public ITransactionCoordinator UnregisterTransactionCoordinator()
    {
      throw new NotImplementedException();
    }

    public ITransactionCoordinator GetTransactionCoordinator()
    {
      throw new NotImplementedException();
    }

    public void SetValue(IUAVariable variable, object value)
    {
      UACoreContext.Interop.UACoreContextSetValue(this.nativeContextPtr, (IntPtr) ((UANode) variable).nodeHandle, ObjectMarshal.ToIntPtr(value)).CheckOutcome();
    }

    public void SetValue(IUAVariable variable, object value, uint[] index)
    {
      if (index == null)
        throw new ArgumentNullException(nameof (index));
      UACoreContext.Interop.UACoreContextSetValueWithIndexes(this.nativeContextPtr, (IntPtr) ((UANode) variable).nodeHandle, ObjectMarshal.ToIntPtr(value), ArrayMarshal.ToNative(index)).CheckOutcome();
    }

    public void SetValue(IEnumerable<VariableValue> items)
    {
      UACoreContext.Interop.UACoreContextSetValueFromVariableValues(this.nativeContextPtr, StructMarshal.ToNativeArray(items)).CheckOutcome();
    }

    public void GetValue(IEnumerable<VariableValue> items)
    {
      List<IndexedVariable> indexedVariableList = new List<IndexedVariable>(items.Count<VariableValue>());
      foreach (VariableValue variableValue in items)
        indexedVariableList.Add(new IndexedVariable(variableValue.Variable, variableValue.Index));
      InteropCallResult fromVariableValues = UACoreContext.Interop.UACoreContextGetValueFromVariableValues(this.nativeContextPtr, StructMarshal.ToNativeArray((IEnumerable<IndexedVariable>) indexedVariableList));
      fromVariableValues.CheckOutcome();
      VariableValueInterop[] structArray = fromVariableValues.GetStructArray<VariableValueInterop>();
      int num = 0;
      foreach (VariableValueInterop variableValueInterop in structArray)
        items.ElementAt<VariableValue>(num++).Value = ObjectMarshal.ReleaseGCHandle<object>(variableValueInterop.Value);
    }

    public LockType GetLockTypeForNode(NodeId nodeId)
    {
      InteropCallResult lockTypeForNode = UACoreContext.Interop.UACoreContextGetLockTypeForNode(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      lockTypeForNode.CheckOutcome();
      return (LockType) lockTypeForNode.GetInt();
    }

    public uint GetLockedNodesCount()
    {
      InteropCallResult lockedNodesCount = UACoreContext.Interop.UACoreContextGetLockedNodesCount(this.nativeContextPtr);
      lockedNodesCount.CheckOutcome();
      return lockedNodesCount.GetUInt();
    }

    public IDisposable DisableThreadSecurityChecks()
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextDisableThreadSecurityChecks(this.nativeContextPtr);
      interopCallResult.CheckOutcome();
      return (IDisposable) new OnScopeExit(interopCallResult.Get<OnScopeExitSafeHandle>());
    }

    public LocalizedText LookupTranslation(LocalizedText localizedText)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextLookupTranslation(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) localizedText));
      interopCallResult.CheckOutcome();
      return interopCallResult.Get<LocalizedText>();
    }

    public LocalizedText LookupTranslation(
      LocalizedText localizedText,
      IReadOnlyList<string> localeIds)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextLookupTranslationWithLocaleIds(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) localizedText), StringMarshal.ToNativeStringArray((IEnumerable<string>) localeIds));
      interopCallResult.CheckOutcome();
      return interopCallResult.Get<LocalizedText>();
    }

    public IReadOnlyList<TranslationItem> GetTranslationKeys(int namespaceIndex, string localeId)
    {
      InteropCallResult translationKeys1 = UACoreContext.Interop.UACoreContextGetTranslationKeys(this.nativeContextPtr, namespaceIndex, localeId);
      translationKeys1.CheckOutcome();
      TranslationItemInterop[] structArray = translationKeys1.GetStructArray<TranslationItemInterop>();
      TranslationItem[] translationKeys2 = new TranslationItem[structArray.Length];
      for (int index = 0; index < structArray.Length; ++index)
        translationKeys2[index] = (TranslationItem) structArray[index];
      return (IReadOnlyList<TranslationItem>) translationKeys2;
    }

    public void SetTranslation(LocalizedText localizedText)
    {
      UACoreContext.Interop.UACoreContextSetTranslation(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) localizedText)).CheckOutcome();
    }

    public IUAVariable GetLocalizationDictionary(LocalizedText localizedText)
    {
      InteropCallResult localizationDictionary = UACoreContext.Interop.UACoreContextGetLocalizationDictionary(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) localizedText));
      localizationDictionary.CheckOutcome();
      return (IUAVariable) localizationDictionary.Get<UAVariable>();
    }

    public IDisposable LockReferencesIfNotLocked(LockType lockType)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextLockReferencesIfNotLocked(this.nativeContextPtr, (int) lockType);
      interopCallResult.CheckOutcome();
      return (IDisposable) new OnScopeExit(interopCallResult.Get<OnScopeExitSafeHandle>());
    }

    public LockType GetCurrentThreadReferencesLockType()
    {
      InteropCallResult referencesLockType = UACoreContext.Interop.UACoreContextGetCurrentThreadReferencesLockType(this.nativeContextPtr);
      referencesLockType.CheckOutcome();
      return (LockType) referencesLockType.GetInt();
    }

    public void DispatchUAEvent(
      IUAObject startingNotifier,
      IUAObjectType eventType,
      IReadOnlyList<object> eventArgs)
    {
      UACoreContext.Interop.UACoreContextDispatchUAEvent(this.nativeContextPtr, (IntPtr) ((UANode) startingNotifier).nodeHandle, (IntPtr) ((UANode) eventType).nodeHandle, ArrayMarshal.ToNative(eventArgs.ToArray<object>())).CheckOutcome();
    }

    public void LoadModule(string moduleName)
    {
      UACoreContext.Interop.UACoreContextLoadModuleNoVersion(this.nativeContextPtr, moduleName).CheckOutcome();
    }

    public void LoadModule(string moduleName, string version)
    {
      UACoreContext.Interop.UACoreContextLoadModule(this.nativeContextPtr, moduleName, version).CheckOutcome();
    }

    public void ForceModuleImplLoad(string moduleName)
    {
      UACoreContext.Interop.UACoreContextForceModuleImplLoad(this.nativeContextPtr, moduleName).CheckOutcome();
    }

    public void LoadLocalizationDictionary(IReadOnlyList<string> locales, string moduleName)
    {
      UACoreContext.Interop.UACoreContextLoadLocalizationDictionary(this.nativeContextPtr, StringMarshal.ToNativeStringArray((IEnumerable<string>) locales), moduleName).CheckOutcome();
    }

    public void LoadCoreLocalizationDictionary(IReadOnlyList<string> locales)
    {
      UACoreContext.Interop.UACoreContextLoadCoreLocalizationDictionary(this.nativeContextPtr, StringMarshal.ToNativeStringArray((IEnumerable<string>) locales)).CheckOutcome();
    }

    public bool IsModuleRegistered(string moduleName)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextIsModuleRegistered(this.nativeContextPtr, moduleName);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    public bool IsModuleLoaded(string moduleName)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextIsModuleLoaded(this.nativeContextPtr, moduleName);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    public string GetModuleLibraryDirectory(string moduleName)
    {
      InteropCallResult libraryDirectory = UACoreContext.Interop.UACoreContextGetModuleLibraryDirectory(this.nativeContextPtr, moduleName);
      libraryDirectory.CheckOutcome();
      return libraryDirectory.GetString();
    }

    public string FormatToPathNodeId(NodeId nodeId)
    {
      InteropCallResult pathNodeId = UACoreContext.Interop.UACoreContextFormatToPathNodeId(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) nodeId));
      pathNodeId.CheckOutcome();
      return pathNodeId.GetString();
    }

    public uint AssignAffinityId()
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextAssignAffinityId(this.nativeContextPtr);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetUInt();
    }

    public IDisposable SuspendDispatch(uint affinityId)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextSuspendDispatch(this.nativeContextPtr, affinityId);
      interopCallResult.CheckOutcome();
      return (IDisposable) new OnScopeExit(interopCallResult.Get<OnScopeExitSafeHandle>());
    }

    public IDisposable TerminateDispatchOnStop(uint affinityId)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextTerminateDispatchOnStop(this.nativeContextPtr, affinityId);
      interopCallResult.CheckOutcome();
      return (IDisposable) new OnScopeExit(interopCallResult.Get<OnScopeExitSafeHandle>());
    }

    public string GetProjectDirectory(int namespaceIndex)
    {
      InteropCallResult projectDirectory = UACoreContext.Interop.UACoreContextGetProjectDirectory(this.nativeContextPtr, namespaceIndex);
      projectDirectory.CheckOutcome();
      return projectDirectory.GetString();
    }

    public void SetProjectDirectory(int namespaceIndex, string directory)
    {
      UACoreContext.Interop.UACoreContextSetProjectDirectory(this.nativeContextPtr, namespaceIndex, directory).CheckOutcome();
    }

    public string GetApplicationDirectory(int namespaceIndex)
    {
      InteropCallResult applicationDirectory = UACoreContext.Interop.UACoreContextGetApplicationDirectory(this.nativeContextPtr, namespaceIndex);
      applicationDirectory.CheckOutcome();
      return applicationDirectory.GetString();
    }

    public void SetApplicationDirectory(int namespaceIndex, string directory)
    {
      UACoreContext.Interop.UACoreContextSetApplicationDirectory(this.nativeContextPtr, namespaceIndex, directory).CheckOutcome();
    }

    public PathResolverResult ResolvePath(string path)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextResolvePath(this.nativeContextPtr, path);
      interopCallResult.CheckOutcome();
      return interopCallResult.Get<PathResolverResult>();
    }

    public PathResolverResult ResolvePath(IUANode node, string path)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextResolvePathWithStartNode((IntPtr) ((UANode) node).nodeHandle, path);
      interopCallResult.CheckOutcome();
      return interopCallResult.Get<PathResolverResult>();
    }

    public IEnumerable<RemoteVariableValue> RemoteRead(
      IEnumerable<RemoteVariable> variables,
      double timeoutMilliseconds = 30000.0)
    {
      InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextRemoteRead(this.nativeContextPtr, StructMarshal.ToNativeArray(variables), timeoutMilliseconds);
      interopCallResult.CheckOutcome();
      RemoteVariableValueInterop[] structArray = interopCallResult.GetStructArray<RemoteVariableValueInterop>();
      RemoteVariableValue[] remoteVariableValueArray = new RemoteVariableValue[structArray.Length];
      for (int index = 0; index < structArray.Length; ++index)
        remoteVariableValueArray[index] = (RemoteVariableValue) structArray[index];
      return (IEnumerable<RemoteVariableValue>) remoteVariableValueArray;
    }

    public void RemoteWrite(
      IEnumerable<RemoteVariableValue> variableValues,
      double timeoutMilliseconds = 30000.0)
    {
      UACoreContext.Interop.UACoreContextRemoteWrite(this.nativeContextPtr, StructMarshal.ToNativeArray(variableValues), timeoutMilliseconds).CheckOutcome();
    }

    public INodeFactory NodeFactory { get; }

    public ISessions Sessions { get; }

    public ISynchronizerContext SynchronizerContext => this.synchronizerContext;

    public bool IsDisposed => this.disposed;

    public bool IsCurrentThreadInTransaction
    {
      get
      {
        InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextIsCurrentThreadInTransaction(this.nativeContextPtr);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public uint CurrentThreadTransactionId
    {
      get
      {
        InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextCurrentThreadTransactionId(this.nativeContextPtr);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetUInt();
      }
    }

    public DateTime CurrentThreadTransactionTimestamp
    {
      get
      {
        InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextCurrentThreadTransactionTimestamp(this.nativeContextPtr);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetDateTime();
      }
    }

    public ulong CurrentThreadSenderId
    {
      get
      {
        InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextCurrentThreadSenderId(this.nativeContextPtr);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetULong();
      }
    }

    public int DefaultNamespaceIndex
    {
      get
      {
        InteropCallResult defaultNamespaceIndex = UACoreContext.Interop.UACoreContextGetDefaultNamespaceIndex(this.nativeContextPtr);
        defaultNamespaceIndex.CheckOutcome();
        return defaultNamespaceIndex.GetInt();
      }
      set
      {
        UACoreContext.Interop.UACoreContextSetDefaultNamespaceIndex(this.nativeContextPtr, value).CheckOutcome();
      }
    }

    public bool SecurityChecksEnabled
    {
      get
      {
        InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextSecurityChecksEnabled(this.nativeContextPtr);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public IContextExtensions Extensions => throw new NotImplementedException();

    public int NodeCount
    {
      get
      {
        InteropCallResult interopCallResult = UACoreContext.Interop.UACoreContextNodeCount(this.nativeContextPtr);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetInt();
      }
    }

    public void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
      {
        this.synchronizerContext.Dispose();
        this.synchronizerContext = (ISynchronizerContext) null;
      }
      this.disposed = true;
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextAssignNamespaceIndex(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string namespaceUri,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string serverUri,
        int namespaceType);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetNamespaceIndex(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string namespaceUri);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetBindingsFolder(IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetModuleVersion(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetModuleLibraryFilePath(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string version);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetNode(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetNamespaceInfo(
        IntPtr contextPtr,
        int namespaceIndex);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetNamespaceIndexes(IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult ContextDispatch(
        IntPtr contextPtr,
        IntPtr actionPtr,
        Action action,
        uint affinityId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetObject(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetObjectType(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetVariable(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetVariableType(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetReferenceType(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetDataType(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetMethod(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetNodeInternal(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextCreateGenericTransaction(
        IntPtr contextPtr,
        int referencesLockType);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextAssignSenderId(IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetCurrentThreadSenderId(
        IntPtr contextPtr,
        ulong senderId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetNamespaceUri(
        IntPtr contextPtr,
        int namespaceIndex);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetAggregatedNamespaceUri(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string namespaceUri,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string serverUri);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetValue(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr valuePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetValueWithIndexes(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr valuePtr,
        IntPtr indexesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetValueFromVariableValues(
        IntPtr contextPtr,
        IntPtr variableValuesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetValueFromVariableValues(
        IntPtr contextPtr,
        IntPtr variableValuesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetLockTypeForNode(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetLockedNodesCount(IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextDisableThreadSecurityChecks(
        IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextLookupTranslation(
        IntPtr contextPtr,
        IntPtr localizedTextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextLookupTranslationWithLocaleIds(
        IntPtr contextPtr,
        IntPtr localizedTextPtr,
        IntPtr localeIdsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetTranslationKeys(
        IntPtr contextPtr,
        int namespaceIndex,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string localeId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetTranslation(
        IntPtr contextPtr,
        IntPtr localizedTextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetLocalizationDictionary(
        IntPtr contextPtr,
        IntPtr localizedTextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextLockReferencesIfNotLocked(
        IntPtr contextPtr,
        int lockType);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetCurrentThreadReferencesLockType(
        IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextDispatchUAEvent(
        IntPtr contextPtr,
        IntPtr startingNotifierPtr,
        IntPtr eventTypePtr,
        IntPtr eventArgsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextLoadModuleNoVersion(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextLoadModule(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string version);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextForceModuleImplLoad(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextLoadLocalizationDictionary(
        IntPtr contextPtr,
        IntPtr localesPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextLoadCoreLocalizationDictionary(
        IntPtr contextPtr,
        IntPtr localesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextIsModuleRegistered(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextIsModuleLoaded(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetModuleLibraryDirectory(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextFormatToPathNodeId(
        IntPtr contextPtr,
        IntPtr nodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextAssignAffinityId(IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSuspendDispatch(
        IntPtr contextPtr,
        uint affinityId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextTerminateDispatchOnStop(
        IntPtr contextPtr,
        uint affinityId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetProjectDirectory(
        IntPtr contextPtr,
        int namespaceIndex);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetProjectDirectory(
        IntPtr contextPtr,
        int namespaceIndex,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string directory);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetApplicationDirectory(
        IntPtr contextPtr,
        int namespaceIndex);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetApplicationDirectory(
        IntPtr contextPtr,
        int namespaceIndex,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string directory);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextResolvePath(
        IntPtr contextPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string path);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextResolvePathWithStartNode(
        IntPtr startNodePtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string path);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextRemoteRead(
        IntPtr contextPtr,
        IntPtr variablesPtr,
        double timeoutMilliseconds);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextRemoteWrite(
        IntPtr contextPtr,
        IntPtr variablesPtr,
        double timeoutMilliseconds);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextIsCurrentThreadInTransaction(
        IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextCurrentThreadTransactionId(
        IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextCurrentThreadTransactionTimestamp(
        IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextCurrentThreadSenderId(IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextGetDefaultNamespaceIndex(
        IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSetDefaultNamespaceIndex(
        IntPtr contextPtr,
        int namespaceIndex);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextSecurityChecksEnabled(IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextNodeCount(IntPtr contextPtr);
    }
  }
}
