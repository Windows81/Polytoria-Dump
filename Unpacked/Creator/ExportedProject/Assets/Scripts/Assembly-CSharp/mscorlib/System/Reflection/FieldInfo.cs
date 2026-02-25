namespace System.Reflection;

[Token(Token = "0x20004D2")]
public abstract class FieldInfo : MemberInfo
{

	[Token(Token = "0x17000421")]
	public abstract FieldAttributes Attributes
	{
		[Token(Token = "0x6002175")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700042E")]
	public abstract RuntimeFieldHandle FieldHandle
	{
		[Token(Token = "0x6002182")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000422")]
	public abstract Type FieldType
	{
		[Token(Token = "0x6002176")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000428")]
	public override bool IsAssembly
	{
		[Address(RVA = "0x13B98F0", Offset = "0x13B8AF0", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600217C")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000429")]
	public override bool IsFamily
	{
		[Address(RVA = "0x13B9980", Offset = "0x13B8B80", Length = "0x23")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600217D")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700042A")]
	public override bool IsFamilyAndAssembly
	{
		[Address(RVA = "0x13B9920", Offset = "0x13B8B20", Length = "0x23")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600217E")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700042B")]
	public override bool IsFamilyOrAssembly
	{
		[Address(RVA = "0x13B9950", Offset = "0x13B8B50", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600217F")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000423")]
	public override bool IsInitOnly
	{
		[Address(RVA = "0x13B99B0", Offset = "0x13B8BB0", Length = "0x21")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.FieldMember", Member = "get_IsReadOnly", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002177")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000424")]
	public override bool IsLiteral
	{
		[Address(RVA = "0x13B99E0", Offset = "0x13B8BE0", Length = "0x21")]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002178")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000425")]
	public override bool IsNotSerialized
	{
		[Address(RVA = "0x13B9A10", Offset = "0x13B8C10", Length = "0x24")]
		[CalledBy(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(MemberInfo[]))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002179")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700042C")]
	public override bool IsPrivate
	{
		[Address(RVA = "0x13B9A40", Offset = "0x13B8C40", Length = "0x23")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002180")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700042D")]
	public override bool IsPublic
	{
		[Address(RVA = "0x13B9A70", Offset = "0x13B8C70", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor")]
		[CalledBy(Type = "Battlehub.Reflection+<>c", Member = "<GetSerializableFields>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Battlehub.Reflection", Member = "IsSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002181")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000426")]
	public override bool IsSpecialName
	{
		[Address(RVA = "0x13B8120", Offset = "0x13B7320", Length = "0x24")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600217A")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000427")]
	public override bool IsStatic
	{
		[Address(RVA = "0x13B9AA0", Offset = "0x13B8CA0", Length = "0x21")]
		[CalledBy(Type = "MoonSharp.Interpreter.ModuleRegister+<>c", Member = "<RegisterModuleType>b__2_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "IsValidMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
		[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.ModuleRegister+<>c", Member = "<RegisterModuleType>b__2_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.MemberExpression")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "GetLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.Interpreter.Instruction")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "EmitStoreField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600217B")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000420")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002174")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002173")]
	protected FieldInfo() { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002183")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x6002175")]
	public abstract FieldAttributes get_Attributes() { }

	[Token(Token = "0x6002182")]
	public abstract RuntimeFieldHandle get_FieldHandle() { }

	[Token(Token = "0x6002176")]
	public abstract Type get_FieldType() { }

	[Address(RVA = "0x13B98F0", Offset = "0x13B8AF0", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600217C")]
	public override bool get_IsAssembly() { }

	[Address(RVA = "0x13B9980", Offset = "0x13B8B80", Length = "0x23")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600217D")]
	public override bool get_IsFamily() { }

	[Address(RVA = "0x13B9920", Offset = "0x13B8B20", Length = "0x23")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600217E")]
	public override bool get_IsFamilyAndAssembly() { }

	[Address(RVA = "0x13B9950", Offset = "0x13B8B50", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600217F")]
	public override bool get_IsFamilyOrAssembly() { }

	[Address(RVA = "0x13B99B0", Offset = "0x13B8BB0", Length = "0x21")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.FieldMember", Member = "get_IsReadOnly", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002177")]
	public override bool get_IsInitOnly() { }

	[Address(RVA = "0x13B99E0", Offset = "0x13B8BE0", Length = "0x21")]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002178")]
	public override bool get_IsLiteral() { }

	[Address(RVA = "0x13B9A10", Offset = "0x13B8C10", Length = "0x24")]
	[CalledBy(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002179")]
	public override bool get_IsNotSerialized() { }

	[Address(RVA = "0x13B9A40", Offset = "0x13B8C40", Length = "0x23")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002180")]
	public override bool get_IsPrivate() { }

	[Address(RVA = "0x13B9A70", Offset = "0x13B8C70", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor")]
	[CalledBy(Type = "Battlehub.Reflection+<>c", Member = "<GetSerializableFields>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.Reflection", Member = "IsSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002181")]
	public override bool get_IsPublic() { }

	[Address(RVA = "0x13B8120", Offset = "0x13B7320", Length = "0x24")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600217A")]
	public override bool get_IsSpecialName() { }

	[Address(RVA = "0x13B9AA0", Offset = "0x13B8CA0", Length = "0x21")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "EmitStoreField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "GetLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.Interpreter.Instruction")]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.MemberExpression")]
	[CalledBy(Type = "MoonSharp.Interpreter.ModuleRegister+<>c", Member = "<RegisterModuleType>b__2_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "IsValidMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.ModuleRegister+<>c", Member = "<RegisterModuleType>b__2_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600217B")]
	public override bool get_IsStatic() { }

	[Address(RVA = "0x1353C50", Offset = "0x1352E50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "mini_get_interp_callbacks")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002190")]
	private MarshalAsAttribute get_marshal_info() { }

	[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002174")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x13B8DB0", Offset = "0x13B7FB0", Length = "0xAC")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210530")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ComVisible(False)]
	[Token(Token = "0x600218E")]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	[Address(RVA = "0x13B8D40", Offset = "0x13B7F40", Length = "0x66")]
	[CalledBy(Type = typeof(RuntimeFieldHandle), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210530")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600218D")]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[Address(RVA = "0x13B8E60", Offset = "0x13B8060", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600218F")]
	internal override int GetFieldOffset() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002184")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13B9540", Offset = "0x13B8740", Length = "0x288")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsExplicitLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "mini_get_interp_callbacks")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002191")]
	internal Object[] GetPseudoCustomAttributes() { }

	[Address(RVA = "0x13B8EB0", Offset = "0x13B80B0", Length = "0x688")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "mini_get_interp_callbacks")]
	[Calls(Type = typeof(Type), Member = "get_IsExplicitLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002192")]
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	[Address(RVA = "0x13B97D0", Offset = "0x13B89D0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600218B")]
	public override object GetRawConstantValue() { }

	[Token(Token = "0x6002187")]
	public abstract object GetValue(object obj) { }

	[Address(RVA = "0x13B9AD0", Offset = "0x13B8CD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210530")]
	[Token(Token = "0x600218C")]
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	[Address(RVA = "0x13B6D10", Offset = "0x13B5F10", Length = "0x29")]
	[CallerCount(Count = 216)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002185")]
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	[Address(RVA = "0x13B8160", Offset = "0x13B7360", Length = "0x3E")]
	[CallerCount(Count = 129)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002186")]
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	[Token(Token = "0x6002189")]
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[Address(RVA = "0x13B9870", Offset = "0x13B8A70", Length = "0x77")]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.FieldMemberDescriptor", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Script", typeof(object), "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.StoreFieldInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.StoreStaticFieldInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.FieldByRefUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.FieldMember", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002188")]
	public override void SetValue(object obj, object value) { }

	[Address(RVA = "0x13B9820", Offset = "0x13B8A20", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CLSCompliant(False)]
	[Token(Token = "0x600218A")]
	public override void SetValueDirect(TypedReference obj, object value) { }

}

