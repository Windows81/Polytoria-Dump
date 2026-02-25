namespace namudev;

[Token(Token = "0x20002DB")]
public abstract class PropertyGridItem : MonoBehaviour
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B12")]
	private EventHandler ValueChanged; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B13")]
	private PropertyGridBinding binding; //Field offset: 0x0

	[Token(Token = "0x1400004A")]
	public event EventHandler ValueChanged
	{
		[Address(RVA = "0xE94410", Offset = "0xE93610", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD5")]
		 add { } //Length: 158
		[Address(RVA = "0xE951B0", Offset = "0xE943B0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD6")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170008C7")]
	public string Caption
	{
		[Address(RVA = "0xE947D0", Offset = "0xE939D0", Length = "0x1B")]
		[CalledBy(Type = typeof(PropertyGridBool), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridColor), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridEnum), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridFloat), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridInt), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridQuaternion), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridString), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridVector2), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridVector3), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyGridVector4), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD7")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170008C8")]
	public T Value
	{
		[Address(RVA = "0xE94AE0", Offset = "0xE93CE0", Length = "0x64")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD8")]
		 get { } //Length: 100
		[Address(RVA = "0xE95460", Offset = "0xE94660", Length = "0x45")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(PropertyGridBinding), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD9")]
		 set { } //Length: 69
	}

	[Token(Token = "0x170008C9")]
	public Type ValueType
	{
		[Address(RVA = "0xE947F0", Offset = "0xE939F0", Length = "0x1B")]
		[CalledBy(Type = typeof(PropertyGridEnum), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ADA")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ADC")]
	protected PropertyGridItem`1() { }

	[Address(RVA = "0xE93E10", Offset = "0xE93010", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ADD")]
	private void <Awake>b__11_0(object o, EventArgs e) { }

	[Address(RVA = "0xE94410", Offset = "0xE93610", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AD5")]
	public void add_ValueChanged(EventHandler value) { }

	[Address(RVA = "0xE93A20", Offset = "0xE92C20", Length = "0xC2")]
	[CalledBy(Type = typeof(PropertyGridBool), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyGridBinding), Member = "add_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ADB")]
	protected override void Awake() { }

	[Address(RVA = "0xE947D0", Offset = "0xE939D0", Length = "0x1B")]
	[CalledBy(Type = typeof(PropertyGridBool), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridColor), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridEnum), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridFloat), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridInt), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridQuaternion), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridString), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridVector2), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridVector3), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridVector4), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AD7")]
	public string get_Caption() { }

	[Address(RVA = "0xE94AE0", Offset = "0xE93CE0", Length = "0x64")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AD8")]
	public T get_Value() { }

	[Address(RVA = "0xE947F0", Offset = "0xE939F0", Length = "0x1B")]
	[CalledBy(Type = typeof(PropertyGridEnum), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ADA")]
	public Type get_ValueType() { }

	[Address(RVA = "0xE951B0", Offset = "0xE943B0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AD6")]
	public void remove_ValueChanged(EventHandler value) { }

	[Address(RVA = "0xE95460", Offset = "0xE94660", Length = "0x45")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(PropertyGridBinding), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AD9")]
	protected void set_Value(T value) { }

}

