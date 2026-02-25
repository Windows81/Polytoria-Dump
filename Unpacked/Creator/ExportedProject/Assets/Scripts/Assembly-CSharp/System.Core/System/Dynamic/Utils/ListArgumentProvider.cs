namespace System.Dynamic.Utils;

[Token(Token = "0x2000245")]
internal sealed class ListArgumentProvider : ListProvider<Expression>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003D7")]
	private readonly IArgumentProvider _provider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003D8")]
	private readonly Expression _arg0; //Field offset: 0x18

	[Token(Token = "0x17000231")]
	protected virtual int ElementCount
	{
		[Address(RVA = "0x15D6730", Offset = "0x15D5930", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000ABF")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000230")]
	protected virtual Expression First
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15D66B0", Offset = "0x15D58B0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ABD")]
	internal ListArgumentProvider(IArgumentProvider provider, Expression arg0) { }

	[Address(RVA = "0x15D6730", Offset = "0x15D5930", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ABF")]
	protected virtual int get_ElementCount() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABE")]
	protected virtual Expression get_First() { }

	[Address(RVA = "0x15D6650", Offset = "0x15D5850", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AC0")]
	protected virtual Expression GetElement(int index) { }

}

