namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000D8")]
public class PropertyTableAssigner : IPropertyTableAssigner
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400039D")]
	private PropertyTableAssigner m_InternalAssigner; //Field offset: 0x0

	[Address(RVA = "0xE95730", Offset = "0xE94930", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyTableAssigner), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C5")]
	public PropertyTableAssigner`1(String[] expectedMissingProperties) { }

	[Address(RVA = "0xE95530", Offset = "0xE94730", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyTableAssigner), Member = "AddExpectedMissingProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C6")]
	public void AddExpectedMissingProperty(string name) { }

	[Address(RVA = "0xE95550", Offset = "0xE94750", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(PropertyTableAssigner), Member = "AssignObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Table)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C7")]
	public void AssignObject(T obj, Table data) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C8")]
	public PropertyTableAssigner GetTypeUnsafeAssigner() { }

	[Address(RVA = "0xE95620", Offset = "0xE94820", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008CB")]
	private override void MoonSharp.Interpreter.Interop.IPropertyTableAssigner.AssignObjectUnchecked(object o, Table data) { }

	[Address(RVA = "0x605390", Offset = "0x604590", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyTableAssigner), Member = "SetSubassignerForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IPropertyTableAssigner)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008CA")]
	public void SetSubassigner(PropertyTableAssigner<SubassignerType> assigner) { }

	[Address(RVA = "0xE95710", Offset = "0xE94910", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyTableAssigner), Member = "SetSubassignerForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IPropertyTableAssigner)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C9")]
	public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner) { }

}

