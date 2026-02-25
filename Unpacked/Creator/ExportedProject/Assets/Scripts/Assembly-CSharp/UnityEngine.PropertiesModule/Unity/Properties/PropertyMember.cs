namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200001F")]
internal struct PropertyMember : IMemberInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000039")]
	internal readonly PropertyInfo m_PropertyInfo; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003A")]
	private readonly string <Name>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700001C")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x1A0EC50", Offset = "0x1A0DE50", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000078")]
		 get { } //Length: 46
	}

	[Token(Token = "0x1700001B")]
	public override string Name
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000077")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001D")]
	public override Type ValueType
	{
		[Address(RVA = "0x1A0EC80", Offset = "0x1A0DE80", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000079")]
		 get { } //Length: 41
	}

	[Address(RVA = "0x19F5A90", Offset = "0x19F4C90", Length = "0x30")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ReflectionUtilities), Member = "SanitizeMemberName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	public PropertyMember(PropertyInfo propertyInfo) { }

	[Address(RVA = "0x1A0EC50", Offset = "0x1A0DE50", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000078")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public override string get_Name() { }

	[Address(RVA = "0x1A0EC80", Offset = "0x1A0DE80", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	public override Type get_ValueType() { }

	[Address(RVA = "0x19F5A30", Offset = "0x19F4C30", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	public override IEnumerable<Attribute> GetCustomAttributes() { }

	[Address(RVA = "0x1A0EC10", Offset = "0x1A0DE10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600007B")]
	public override object GetValue(object obj) { }

	[Address(RVA = "0x1A0EC30", Offset = "0x1A0DE30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600007C")]
	public override void SetValue(object obj, object value) { }

}

