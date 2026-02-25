namespace U8Xml.Internal;

[IsReadOnly]
[Token(Token = "0x2000035")]
internal struct XmlObjectCore : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000055")]
	private readonly IntPtr _rawByteData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000056")]
	private readonly int _byteLength; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000057")]
	private readonly int _offset; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000058")]
	private readonly NodeStore _store; //Field offset: 0x10
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000059")]
	private readonly OptionalNodeList _optional; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005A")]
	private readonly RawStringTable _entities; //Field offset: 0x30

	[Token(Token = "0x17000034")]
	public override XmlNode Root
	{
		[Address(RVA = "0x180CF30", Offset = "0x180C130", Length = "0x75")]
		[CalledBy(Type = typeof(XmlObject), Member = "get_Root", ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomList`1), Member = "get_FirstItem", ReturnType = "T*")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000F8")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x180CE80", Offset = "0x180C080", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000F9")]
	internal XmlObjectCore(ref UnmanagedBuffer buffer, int offset, ref NodeStore store, OptionalNodeList optional, RawStringTable entities) { }

	[Address(RVA = "0x180CCD0", Offset = "0x180BED0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000FB")]
	public override RawString AsRawString() { }

	[Address(RVA = "0x180CD30", Offset = "0x180BF30", Length = "0x14E")]
	[CalledBy(Type = typeof(XmlObject), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlObject), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(U8Xml.Internal.CustomList`1<U8Xml.XmlNode_>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(OptionalNodeList), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RawStringTable), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000FA")]
	public override void Dispose() { }

	[Address(RVA = "0x180CF30", Offset = "0x180C130", Length = "0x75")]
	[CalledBy(Type = typeof(XmlObject), Member = "get_Root", ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomList`1), Member = "get_FirstItem", ReturnType = "T*")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000F8")]
	public override XmlNode get_Root() { }

}

