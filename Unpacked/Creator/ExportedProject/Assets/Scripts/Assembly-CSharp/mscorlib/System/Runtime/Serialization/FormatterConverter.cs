namespace System.Runtime.Serialization;

[Token(Token = "0x20003CB")]
public class FormatterConverter : IFormatterConverter
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CE5")]
	public FormatterConverter() { }

	[Address(RVA = "0x137E930", Offset = "0x137DB30", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
	[Token(Token = "0x6001CDE")]
	public override object Convert(object value, Type type) { }

	[Address(RVA = "0x137E9D0", Offset = "0x137DBD0", Length = "0x4E")]
	[CalledBy(Type = typeof(FormatterConverter), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001CE4")]
	private static void ThrowValueNullException() { }

	[Address(RVA = "0x137EA20", Offset = "0x137DC20", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
	[Token(Token = "0x6001CDF")]
	public override bool ToBoolean(object value) { }

	[Address(RVA = "0x137EAB0", Offset = "0x137DCB0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
	[Token(Token = "0x6001CE0")]
	public override int ToInt32(object value) { }

	[Address(RVA = "0x137EB40", Offset = "0x137DD40", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
	[Token(Token = "0x6001CE1")]
	public override long ToInt64(object value) { }

	[Address(RVA = "0x137EBD0", Offset = "0x137DDD0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
	[Token(Token = "0x6001CE2")]
	public override float ToSingle(object value) { }

	[Address(RVA = "0x137EC60", Offset = "0x137DE60", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
	[Token(Token = "0x6001CE3")]
	public override string ToString(object value) { }

}

