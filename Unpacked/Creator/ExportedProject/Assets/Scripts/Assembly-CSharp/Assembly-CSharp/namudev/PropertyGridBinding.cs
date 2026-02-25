namespace namudev;

[Token(Token = "0x20002D2")]
public class PropertyGridBinding : MonoBehaviour
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AF8")]
	private EventHandler ValueChanged; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AF9")]
	private string <Caption>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AFA")]
	private object <Value>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AFB")]
	private Type <ValueType>k__BackingField; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AFC")]
	private object targetObject; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AFD")]
	private PropertyInfo propertyInfo; //Field offset: 0x48

	[Token(Token = "0x14000049")]
	public event EventHandler ValueChanged
	{
		[Address(RVA = "0x411620", Offset = "0x410820", Length = "0x9E")]
		[CalledBy(Type = typeof(PropertyGrid), Member = "AppendProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridItem`1), Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001AA1")]
		 add { } //Length: 158
		[Address(RVA = "0x4116C0", Offset = "0x4108C0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001AA2")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170008C4")]
	public private string Caption
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AA3")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AA4")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170008C5")]
	public private object Value
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AA5")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AA6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170008C6")]
	public private Type ValueType
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AA7")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AA8")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AAC")]
	public PropertyGridBinding() { }

	[Address(RVA = "0x411620", Offset = "0x410820", Length = "0x9E")]
	[CalledBy(Type = typeof(PropertyGrid), Member = "AppendProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridItem`1), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001AA1")]
	public void add_ValueChanged(EventHandler value) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA3")]
	public string get_Caption() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA5")]
	public object get_Value() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA7")]
	public Type get_ValueType() { }

	[Address(RVA = "0x411400", Offset = "0x410600", Length = "0x54")]
	[CalledBy(Type = typeof(PropertyGrid), Member = "AppendProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001AA9")]
	public void Initialize(string caption, object value, Type valueType) { }

	[Address(RVA = "0x411460", Offset = "0x410660", Length = "0xCA")]
	[CalledBy(Type = typeof(PropertyGrid), Member = "AppendProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001AAA")]
	public void Initialize(object targetObject, PropertyInfo propertyInfo) { }

	[Address(RVA = "0x4116C0", Offset = "0x4108C0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001AA2")]
	public void remove_ValueChanged(EventHandler value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA4")]
	private void set_Caption(string value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA6")]
	private void set_Value(object value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA8")]
	private void set_ValueType(Type value) { }

	[Address(RVA = "0x411530", Offset = "0x410730", Length = "0xEF")]
	[CalledBy(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AAB")]
	public void SetValue(object value) { }

}

