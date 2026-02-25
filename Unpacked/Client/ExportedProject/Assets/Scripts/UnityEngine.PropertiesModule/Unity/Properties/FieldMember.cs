namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200001E")]
internal struct FieldMember : IMemberInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000037")]
	internal readonly FieldInfo m_FieldInfo; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000038")]
	private readonly string <Name>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000019")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x19F5AC0", Offset = "0x19F4CC0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldInfo), Member = "get_IsInitOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000072")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000018")]
	public override string Name
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000071")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001A")]
	public override Type ValueType
	{
		[Address(RVA = "0x19F5AE0", Offset = "0x19F4CE0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000073")]
		 get { } //Length: 41
	}

	[Address(RVA = "0x19F5A90", Offset = "0x19F4C90", Length = "0x30")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ReflectionUtilities), Member = "SanitizeMemberName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000070")]
	public FieldMember(FieldInfo fieldInfo) { }

	[Address(RVA = "0x19F5AC0", Offset = "0x19F4CC0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsInitOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000072")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000071")]
	public override string get_Name() { }

	[Address(RVA = "0x19F5AE0", Offset = "0x19F4CE0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000073")]
	public override Type get_ValueType() { }

	[Address(RVA = "0x19F5A30", Offset = "0x19F4C30", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public override IEnumerable<Attribute> GetCustomAttributes() { }

	[Address(RVA = "0x19F5A40", Offset = "0x19F4C40", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	public override object GetValue(object obj) { }

	[Address(RVA = "0x19F5A70", Offset = "0x19F4C70", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000075")]
	public override void SetValue(object obj, object value) { }

}

