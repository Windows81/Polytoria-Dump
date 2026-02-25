namespace System.ComponentModel;

[Token(Token = "0x200016C")]
public class Int64Converter : BaseNumberConverter
{

	[Token(Token = "0x170001A3")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x17A0F10", Offset = "0x17A0110", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x60008BF")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0x80BFB0", Offset = "0x80B1B0", Length = "0x7")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C3")]
	public Int64Converter() { }

	[Address(RVA = "0x17A0E10", Offset = "0x17A0010", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x60008C0")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x17A0DE0", Offset = "0x179FFE0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x60008C1")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x17A0F10", Offset = "0x17A0110", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x60008BF")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x17A0E80", Offset = "0x17A0080", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60008C2")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

