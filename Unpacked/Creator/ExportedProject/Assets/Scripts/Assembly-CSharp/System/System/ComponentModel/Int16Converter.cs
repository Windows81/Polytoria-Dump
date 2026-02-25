namespace System.ComponentModel;

[Token(Token = "0x200016A")]
public class Int16Converter : BaseNumberConverter
{

	[Token(Token = "0x170001A1")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x17A0C30", Offset = "0x179FE30", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x60008B5")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0x80BFB0", Offset = "0x80B1B0", Length = "0x7")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B9")]
	public Int16Converter() { }

	[Address(RVA = "0x17A0B30", Offset = "0x179FD30", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x60008B6")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x17A0B00", Offset = "0x179FD00", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x60008B7")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x17A0C30", Offset = "0x179FE30", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x60008B5")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x17A0BA0", Offset = "0x179FDA0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60008B8")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

