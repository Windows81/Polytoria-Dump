namespace System.Linq.Expressions;

[Token(Token = "0x2000084")]
internal class ExpressionN : Expression<TDelegate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000135")]
	private IReadOnlyList<ParameterExpression> _parameters; //Field offset: 0x0

	[Token(Token = "0x1700008B")]
	internal virtual int ParameterCount
	{
		[Address(RVA = "0xC30A20", Offset = "0xC2FC20", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000381")]
		internal get { } //Length: 70
	}

	[Address(RVA = "0xC2FD80", Offset = "0xC2EF80", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000380")]
	public ExpressionN`1(Expression body, IReadOnlyList<ParameterExpression> parameters) { }

	[Address(RVA = "0xC30A20", Offset = "0xC2FC20", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000381")]
	internal virtual int get_ParameterCount() { }

	[Address(RVA = "0xC308A0", Offset = "0xC2FAA0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000382")]
	internal virtual ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0xC30950", Offset = "0xC2FB50", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000383")]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

