namespace System.Linq.Expressions;

[Token(Token = "0x20000B1")]
internal static class Utils
{
	[Token(Token = "0x4000181")]
	public static readonly object BoxedFalse; //Field offset: 0x0
	[Token(Token = "0x4000182")]
	public static readonly object BoxedTrue; //Field offset: 0x8
	[Token(Token = "0x4000183")]
	public static readonly object BoxedIntM1; //Field offset: 0x10
	[Token(Token = "0x4000184")]
	public static readonly object BoxedInt0; //Field offset: 0x18
	[Token(Token = "0x4000185")]
	public static readonly object BoxedInt1; //Field offset: 0x20
	[Token(Token = "0x4000186")]
	public static readonly object BoxedInt2; //Field offset: 0x28
	[Token(Token = "0x4000187")]
	public static readonly object BoxedInt3; //Field offset: 0x30
	[Token(Token = "0x4000188")]
	public static readonly object BoxedDefaultSByte; //Field offset: 0x38
	[Token(Token = "0x4000189")]
	public static readonly object BoxedDefaultChar; //Field offset: 0x40
	[Token(Token = "0x400018A")]
	public static readonly object BoxedDefaultInt16; //Field offset: 0x48
	[Token(Token = "0x400018B")]
	public static readonly object BoxedDefaultInt64; //Field offset: 0x50
	[Token(Token = "0x400018C")]
	public static readonly object BoxedDefaultByte; //Field offset: 0x58
	[Token(Token = "0x400018D")]
	public static readonly object BoxedDefaultUInt16; //Field offset: 0x60
	[Token(Token = "0x400018E")]
	public static readonly object BoxedDefaultUInt32; //Field offset: 0x68
	[Token(Token = "0x400018F")]
	public static readonly object BoxedDefaultUInt64; //Field offset: 0x70
	[Token(Token = "0x4000190")]
	public static readonly object BoxedDefaultSingle; //Field offset: 0x78
	[Token(Token = "0x4000191")]
	public static readonly object BoxedDefaultDouble; //Field offset: 0x80
	[Token(Token = "0x4000192")]
	public static readonly object BoxedDefaultDecimal; //Field offset: 0x88
	[Token(Token = "0x4000193")]
	public static readonly object BoxedDefaultDateTime; //Field offset: 0x90
	[Token(Token = "0x4000194")]
	private static readonly ConstantExpression s_true; //Field offset: 0x98
	[Token(Token = "0x4000195")]
	private static readonly ConstantExpression s_false; //Field offset: 0xA0
	[Token(Token = "0x4000196")]
	private static readonly ConstantExpression s_m1; //Field offset: 0xA8
	[Token(Token = "0x4000197")]
	private static readonly ConstantExpression s_0; //Field offset: 0xB0
	[Token(Token = "0x4000198")]
	private static readonly ConstantExpression s_1; //Field offset: 0xB8
	[Token(Token = "0x4000199")]
	private static readonly ConstantExpression s_2; //Field offset: 0xC0
	[Token(Token = "0x400019A")]
	private static readonly ConstantExpression s_3; //Field offset: 0xC8
	[Token(Token = "0x400019B")]
	public static readonly DefaultExpression Empty; //Field offset: 0xD0
	[Token(Token = "0x400019C")]
	public static readonly ConstantExpression Null; //Field offset: 0xD8

	[Address(RVA = "0x15AC500", Offset = "0x15AB700", Length = "0x7EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "Empty", ReturnType = typeof(DefaultExpression))]
	[Token(Token = "0x6000499")]
	private static Utils() { }

}

