// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NetSolutionFileSyntaxWalker
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  internal class NetSolutionFileSyntaxWalker : CSharpSyntaxWalker
  {
    private readonly HashSet<string> securityCriticalNamespaces;

    public NetSolutionFileSyntaxWalker()
      : base()
    {
      this.securityCriticalNamespaces = new HashSet<string>()
      {
        "System.Diagnostics",
        "System.Diagnostics.Process",
        "System.Diagnostics.StackTrace",
        "System.Diagnostics.TextWriterTraceListener",
        "System.Diagnostics.TraceSource",
        "System.Diagnostics.Tracing",
        "System.Dynamic",
        "System.IO",
        "System.IO.FileSystem",
        "System.IO.FileSystem.AccessControl",
        "System.IO.FileSystem.DriveInfo",
        "System.IO.FileSystem.Primitives",
        "System.IO.FileSystem.Watcher",
        "System.IO.IsolatedStorage",
        "System.IO.MemoryMappedFiles",
        "System.IO.Pipes",
        "System.IO.Pipes.AccessControl",
        "System.IO.UnmanagedMemoryStream",
        "System.Net",
        "System.Net.Http",
        "System.Net.Http.Json",
        "System.Net.HttpListener",
        "System.Net.Mail",
        "System.Net.NameResolution",
        "System.Net.NetworkInformation",
        "System.Net.Ping",
        "System.Net.Primitives",
        "System.Net.Quic",
        "System.Net.Requests",
        "System.Net.Security",
        "System.Net.ServicePoint",
        "System.Net.Sockets",
        "System.Net.WebClient",
        "System.Net.WebHeaderCollection",
        "System.Net.WebProxy",
        "System.Net.WebSockets.Client",
        "System.Net.WebSockets",
        "System.Reflection",
        "System.Reflection.DispatchProxy",
        "System.Reflection.Emit.ILGeneration",
        "System.Reflection.Emit.Lightweight",
        "System.Reflection.Emit",
        "System.Reflection.Extensions",
        "System.Reflection.Metadata",
        "System.Reflection.Primitives",
        "System.Reflection.TypeExtensions",
        "System.Runtime.CompilerServices.Unsafe",
        "System.Runtime.CompilerServices.VisualC",
        "System.Runtime.Extensions",
        "System.Runtime.Handles",
        "System.Runtime.InteropServices",
        "System.Runtime.InteropServices.RuntimeInformation",
        "System.Runtime.Intrinsics",
        "System.Runtime.Loader",
        "System.Runtime.Numerics",
        "System.Runtime.Serialization",
        "System.Runtime.Serialization.Formatters",
        "System.Runtime.Serialization.Json",
        "System.Runtime.Serialization.Primitives",
        "System.Runtime.Serialization.Xml",
        "System.Security",
        "System.Security.Cryptography",
        "System.Security.Cryptography.Algorithms",
        "System.Security.Cryptography.Cng",
        "System.Security.Cryptography.Csp",
        "System.Security.Cryptography.Encoding",
        "System.Security.Cryptography.OpenSsl",
        "System.Security.Cryptography.Primitives",
        "System.Security.Cryptography.X509Certificates",
        "System.Security.AccessControl",
        "System.Security.Claims",
        "System.Security.Principal",
        "System.Security.Principal.Windows",
        "System.ServiceModel.Web",
        "System.ServiceProcess",
        "System.Web",
        "System.Web.HttpUtility"
      };
    }

    public override void Visit(SyntaxNode node)
    {
      this.VisitTypeInfo(this.SemanticModel.GetTypeInfo(node));
      base.Visit(node);
    }

    public SemanticModel SemanticModel { get; set; }

    public List<string> ReferencedNamespaces { get; } = new List<string>();

    private void VisitTypeInfo(TypeInfo typeInfo)
    {
      ITypeSymbol type = typeInfo.Type;
      if (type == null)
        return;
      this.VisitTypeSymbolString(type.ToDisplayString());
      string displayString = type.ContainingNamespace?.ToDisplayString();
      if (string.IsNullOrEmpty(displayString) || !(displayString != "<global namespace>"))
        return;
      this.VisitTypeSymbolString(displayString);
    }

    private void VisitTypeSymbolString(string typeSymbolString)
    {
      if (!this.securityCriticalNamespaces.Contains(typeSymbolString))
        return;
      this.ReferencedNamespaces.Add(typeSymbolString);
      this.securityCriticalNamespaces.Remove(typeSymbolString);
    }
  }
}
