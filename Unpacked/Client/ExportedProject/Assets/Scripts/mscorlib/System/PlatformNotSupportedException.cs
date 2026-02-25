namespace System;

[Token(Token = "0x2000125")]
public class PlatformNotSupportedException : NotSupportedException
{

	[Address(RVA = "0x14BDB90", Offset = "0x14BCD90", Length = "0x44")]
	[CallerCount(Count = 194)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000941")]
	public PlatformNotSupportedException() { }

	[Address(RVA = "0x14BDB70", Offset = "0x14BCD70", Length = "0x1E")]
	[CalledBy(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(SafePasswordHandle)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "MoonSharp.Interpreter.Loaders.InvalidScriptLoader", Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.Table"}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Loaders.InvalidScriptLoader", Member = "ResolveModuleName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.Table"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "AdvertiseServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "StartDiscovery", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000942")]
	public PlatformNotSupportedException(string message) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000943")]
	protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) { }

}

