namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000E2")]
public class DynValueMemberDescriptor : IMemberDescriptor, IWireableDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003C6")]
	private DynValue m_Value; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003C7")]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003C8")]
	private MemberDescriptorAccess <MemberAccess>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700012D")]
	public override bool IsStatic
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700012F")]
	public private override MemberDescriptorAccess MemberAccess
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F8")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F9")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700012E")]
	public private override string Name
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F6")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000130")]
	public override DynValue Value
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x331870", Offset = "0x330A70", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Script), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "CreateDynamicExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynamicExpression))]
	[Calls(Type = typeof(DynamicExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008F2")]
	protected DynValueMemberDescriptor(string name, string serializedTableValue) { }

	[Address(RVA = "0x3319D0", Offset = "0x330BD0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008F3")]
	protected DynValueMemberDescriptor(string name) { }

	[Address(RVA = "0x331960", Offset = "0x330B60", Length = "0x6D")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "AddDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008F4")]
	public DynValueMemberDescriptor(string name, DynValue value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F5")]
	public override bool get_IsStatic() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F8")]
	public override MemberDescriptorAccess get_MemberAccess() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F6")]
	public override string get_Name() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FA")]
	public override DynValue get_Value() { }

	[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FB")]
	public override DynValue GetValue(Script script, object obj) { }

	[Address(RVA = "0x331340", Offset = "0x330540", Length = "0x450")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LuaTypeExtensions), Member = "ToErrorTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x60008FD")]
	public override void PrepareForWiring(Table t) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F9")]
	private void set_MemberAccess(MemberDescriptorAccess value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F7")]
	private void set_Name(string value) { }

	[Address(RVA = "0x3317C0", Offset = "0x3309C0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60008FC")]
	public override void SetValue(Script script, object obj, DynValue value) { }

}

