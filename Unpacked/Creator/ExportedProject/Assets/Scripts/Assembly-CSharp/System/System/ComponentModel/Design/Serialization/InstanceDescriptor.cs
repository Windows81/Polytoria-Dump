namespace System.ComponentModel.Design.Serialization;

[Token(Token = "0x200019E")]
public sealed class InstanceDescriptor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000666")]
	private readonly ICollection <Arguments>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000667")]
	private readonly bool <IsComplete>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000668")]
	private readonly MemberInfo <MemberInfo>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001D1")]
	public ICollection Arguments
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009DF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D2")]
	public MemberInfo MemberInfo
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17A0490", Offset = "0x179F690", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009DD")]
	public InstanceDescriptor(MemberInfo member, ICollection arguments) { }

	[Address(RVA = "0x17A04B0", Offset = "0x179F6B0", Length = "0x644")]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DecimalConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GuidConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(EnumConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InstanceDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(PropertyInfo), Member = "GetGetMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60009DE")]
	public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009DF")]
	public ICollection get_Arguments() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E0")]
	public MemberInfo get_MemberInfo() { }

	[Address(RVA = "0x17A0070", Offset = "0x179F270", Length = "0x41D")]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GuidConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NullableConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReferenceConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(StringConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(EnumConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009E1")]
	public object Invoke() { }

}

