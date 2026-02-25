namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000058")]
public struct UnsafeText : IDisposable, IUTF8Bytes, INativeList<Byte>, IIndexable<Byte>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C6")]
	internal UntypedUnsafeList m_UntypedListData; //Field offset: 0x0

	[Token(Token = "0x17000017")]
	public bool IsCreated
	{
		[Address(RVA = "0x18218A0", Offset = "0x1820AA0", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		[Token(Token = "0x6000092")]
		 get { } //Length: 88
	}

	[Token(Token = "0x17000018")]
	public override int Length
	{
		[Address(RVA = "0x1821900", Offset = "0x1820B00", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		[Token(Token = "0x6000096")]
		 get { } //Length: 112
	}

	[Address(RVA = "0x18216C0", Offset = "0x18208C0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnsafeList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6000094")]
	public override void Dispose() { }

	[Address(RVA = "0x1821720", Offset = "0x1820920", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnsafeList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000093")]
	internal static void Free(UnsafeText* data) { }

	[Address(RVA = "0x18218A0", Offset = "0x1820AA0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	[Token(Token = "0x6000092")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x1821900", Offset = "0x1820B00", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	[Token(Token = "0x6000096")]
	public override int get_Length() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000095")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x1821800", Offset = "0x1820A00", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x6000097")]
	public virtual string ToString() { }

}

