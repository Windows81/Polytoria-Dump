namespace System.Reflection;

[Token(Token = "0x20004CA")]
public abstract class ConstructorInfo : MethodBase
{
	[Token(Token = "0x4001315")]
	public static readonly string ConstructorName; //Field offset: 0x0
	[Token(Token = "0x4001316")]
	public static readonly string TypeConstructorName; //Field offset: 0x8

	[Token(Token = "0x1700041A")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002155")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x13B6C60", Offset = "0x13B5E60", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600215C")]
	private static ConstructorInfo() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002154")]
	protected ConstructorInfo() { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002158")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002155")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002159")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13B6C20", Offset = "0x13B5E20", Length = "0x36")]
	[CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = "Invoke", ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Script", typeof(object), "MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "UnityEngine.Events.PersistentCall", Member = "GetObjectCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Object", typeof(MethodInfo), "UnityEngine.Events.ArgumentCache"}, ReturnType = "UnityEngine.Events.BaseInvokableCall")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NewInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ByRefNewInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002156")]
	public object Invoke(Object[] parameters) { }

	[Token(Token = "0x6002157")]
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x13B6D10", Offset = "0x13B5F10", Length = "0x29")]
	[CallerCount(Count = 216)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600215A")]
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	[Address(RVA = "0x13B6D40", Offset = "0x13B5F40", Length = "0x93")]
	[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.GuidConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "SetImplicitConstructor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600215B")]
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

}

