namespace MoonSharp.Interpreter.Interop.BasicDescriptors;

[Token(Token = "0x2000139")]
public sealed class ParameterDescriptor : IWireableDescriptor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004C7")]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004C8")]
	private Type <Type>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C9")]
	private bool <HasDefaultValue>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004CA")]
	private object <DefaultValue>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004CB")]
	private bool <IsOut>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40004CC")]
	private bool <IsRef>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x40004CD")]
	private bool <IsVarArgs>k__BackingField; //Field offset: 0x32
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004CE")]
	private Type m_OriginalType; //Field offset: 0x38

	[Token(Token = "0x1700018C")]
	public private object DefaultValue
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB6")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000190")]
	public bool HasBeenRestricted
	{
		[Address(RVA = "0x35C7C0", Offset = "0x35B9C0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000BBE")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700018B")]
	public private bool HasDefaultValue
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB4")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB5")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700018D")]
	public private bool IsOut
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB8")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB9")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700018E")]
	public private bool IsRef
	{
		[Address(RVA = "0x35C800", Offset = "0x35BA00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBA")]
		 get { } //Length: 5
		[Address(RVA = "0x35C830", Offset = "0x35BA30", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBB")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700018F")]
	public private bool IsVarArgs
	{
		[Address(RVA = "0x35C810", Offset = "0x35BA10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBC")]
		 get { } //Length: 5
		[Address(RVA = "0x35C840", Offset = "0x35BA40", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBD")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000189")]
	public private string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB0")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB1")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000191")]
	public Type OriginalType
	{
		[Address(RVA = "0x35C820", Offset = "0x35BA20", Length = "0xE")]
		[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000BBF")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700018A")]
	public private Type Type
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB2")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB3")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x35C570", Offset = "0x35B770", Length = "0x249")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor+<>c", Member = "<.ctor>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(ParameterDescriptor))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor+<>c", Member = "<.ctor>b__16_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(ParameterDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BC2")]
	public ParameterDescriptor(ParameterInfo pi) { }

	[Address(RVA = "0x35C2F0", Offset = "0x35B4F0", Length = "0x1EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BC1")]
	public ParameterDescriptor(string name, Type type, bool hasDefaultValue, object defaultValue, bool isOut, bool isRef, bool isVarArgs, Type typeRestriction) { }

	[Address(RVA = "0x35C4E0", Offset = "0x35B6E0", Length = "0x8B")]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BC0")]
	public ParameterDescriptor(string name, Type type, bool hasDefaultValue = false, object defaultValue = null, bool isOut = false, bool isRef = false, bool isVarArgs = false) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB6")]
	public object get_DefaultValue() { }

	[Address(RVA = "0x35C7C0", Offset = "0x35B9C0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BBE")]
	public bool get_HasBeenRestricted() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB4")]
	public bool get_HasDefaultValue() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB8")]
	public bool get_IsOut() { }

	[Address(RVA = "0x35C800", Offset = "0x35BA00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBA")]
	public bool get_IsRef() { }

	[Address(RVA = "0x35C810", Offset = "0x35BA10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBC")]
	public bool get_IsVarArgs() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB0")]
	public string get_Name() { }

	[Address(RVA = "0x35C820", Offset = "0x35BA20", Length = "0xE")]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000BBF")]
	public Type get_OriginalType() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB2")]
	public Type get_Type() { }

	[Address(RVA = "0x35BDC0", Offset = "0x35AFC0", Length = "0x339")]
	[CalledBy(Type = typeof(ArrayMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000BC5")]
	public override void PrepareForWiring(Table table) { }

	[Address(RVA = "0x35C100", Offset = "0x35B300", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BC4")]
	public void RestrictType(Type type) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB7")]
	private void set_DefaultValue(object value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB5")]
	private void set_HasDefaultValue(bool value) { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB9")]
	private void set_IsOut(bool value) { }

	[Address(RVA = "0x35C830", Offset = "0x35BA30", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBB")]
	private void set_IsRef(bool value) { }

	[Address(RVA = "0x35C840", Offset = "0x35BA40", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBD")]
	private void set_IsVarArgs(bool value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB1")]
	private void set_Name(string value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB3")]
	private void set_Type(Type value) { }

	[Address(RVA = "0x35C250", Offset = "0x35B450", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BC3")]
	public virtual string ToString() { }

}

