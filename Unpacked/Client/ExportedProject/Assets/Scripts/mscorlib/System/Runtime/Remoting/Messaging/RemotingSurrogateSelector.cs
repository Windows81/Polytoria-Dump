namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003B9")]
public class RemotingSurrogateSelector : ISurrogateSelector
{
	[Token(Token = "0x4000EF7")]
	private static Type s_cachedTypeObjRef; //Field offset: 0x0
	[Token(Token = "0x4000EF8")]
	private static ObjRefSurrogate _objRefSurrogate; //Field offset: 0x8
	[Token(Token = "0x4000EF9")]
	private static RemotingSurrogate _objRemotingSurrogate; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EFA")]
	private ISurrogateSelector _next; //Field offset: 0x10

	[Address(RVA = "0x13911D0", Offset = "0x13903D0", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001C99")]
	private static RemotingSurrogateSelector() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C97")]
	public RemotingSurrogateSelector() { }

	[Address(RVA = "0x1391030", Offset = "0x1390230", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180188F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001C98")]
	public override ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

}

