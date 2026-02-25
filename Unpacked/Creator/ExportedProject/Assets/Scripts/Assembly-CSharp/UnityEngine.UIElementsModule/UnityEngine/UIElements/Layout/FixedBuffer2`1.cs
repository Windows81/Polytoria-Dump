namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
[Token(Token = "0x20005D9")]
internal struct FixedBuffer2
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001535")]
	private T __0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001536")]
	private T __1; //Field offset: 0x0

	[Token(Token = "0x17000A81")]
	public T Item
	{
		[Address(RVA = "0xC3F730", Offset = "0xC3E930", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002985")]
		 get { } //Length: 101
	}

	[Address(RVA = "0xC3F730", Offset = "0xC3E930", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002985")]
	public T get_Item(int index) { }

}

