namespace System.ComponentModel;

[Token(Token = "0x2000178")]
public class StringConverter : TypeConverter
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091C")]
	public StringConverter() { }

	[Address(RVA = "0x17996A0", Offset = "0x17988A0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091A")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x17A9750", Offset = "0x17A8950", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeConverter), Member = "GetConvertFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600091B")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

}

