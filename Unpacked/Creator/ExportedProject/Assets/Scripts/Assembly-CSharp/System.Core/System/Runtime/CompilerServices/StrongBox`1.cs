namespace System.Runtime.CompilerServices;

[Token(Token = "0x200023A")]
public class StrongBox : IStrongBox
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CB")]
	public T Value; //Field offset: 0x0

	[Token(Token = "0x17000225")]
	private override object System.Runtime.CompilerServices.IStrongBox.Value
	{
		[Address(RVA = "0xF65D90", Offset = "0xF64F90", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A81")]
		private get { } //Length: 40
		[Address(RVA = "0xF65F40", Offset = "0xF65140", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A82")]
		private set { } //Length: 103
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7F")]
	public StrongBox`1() { }

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A80")]
	public StrongBox`1(T value) { }

	[Address(RVA = "0xF65D90", Offset = "0xF64F90", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A81")]
	private override object System.Runtime.CompilerServices.IStrongBox.get_Value() { }

	[Address(RVA = "0xF65F40", Offset = "0xF65140", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A82")]
	private override void System.Runtime.CompilerServices.IStrongBox.set_Value(object value) { }

}

