namespace System.Net;

[Token(Token = "0x2000235")]
internal class KnownHttpVerb
{
	[Token(Token = "0x400090F")]
	private static ListDictionary NamedHeaders; //Field offset: 0x0
	[Token(Token = "0x4000910")]
	internal static KnownHttpVerb Get; //Field offset: 0x8
	[Token(Token = "0x4000911")]
	internal static KnownHttpVerb Connect; //Field offset: 0x10
	[Token(Token = "0x4000912")]
	internal static KnownHttpVerb Head; //Field offset: 0x18
	[Token(Token = "0x4000913")]
	internal static KnownHttpVerb Put; //Field offset: 0x20
	[Token(Token = "0x4000914")]
	internal static KnownHttpVerb Post; //Field offset: 0x28
	[Token(Token = "0x4000915")]
	internal static KnownHttpVerb MkCol; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400090A")]
	internal string Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400090B")]
	internal bool RequireContentBody; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x400090C")]
	internal bool ContentBodyNotAllowed; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x400090D")]
	internal bool ConnectRequest; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x400090E")]
	internal bool ExpectNoContentResponse; //Field offset: 0x1B

	[Address(RVA = "0x17DD870", Offset = "0x17DCA70", Length = "0x480")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ListDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6000E20")]
	private static KnownHttpVerb() { }

	[Address(RVA = "0x17DDD00", Offset = "0x17DCF00", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E1F")]
	internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	[Address(RVA = "0x17DD790", Offset = "0x17DC990", Length = "0xD5")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "CanGetRequestStream", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ListDictionary), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E21")]
	public static KnownHttpVerb Parse(string name) { }

}

