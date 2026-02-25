namespace System.Reflection;

[Token(Token = "0x20004E8")]
public abstract class PropertyInfo : MemberInfo
{

	[Token(Token = "0x1700045C")]
	public abstract PropertyAttributes Attributes
	{
		[Token(Token = "0x6002208")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700045E")]
	public abstract bool CanRead
	{
		[Token(Token = "0x600220A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700045F")]
	public abstract bool CanWrite
	{
		[Token(Token = "0x600220B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000460")]
	public override MethodInfo GetMethod
	{
		[Address(RVA = "0x13C12F0", Offset = "0x13C04F0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600220C")]
		 get { } //Length: 22
	}

	[Token(Token = "0x1700045D")]
	public override bool IsSpecialName
	{
		[Address(RVA = "0x13C1310", Offset = "0x13C0510", Length = "0x24")]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.StandardUserDataDescriptor", Member = "FillMemberList", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002209")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700045A")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002205")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700045B")]
	public abstract Type PropertyType
	{
		[Token(Token = "0x6002206")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002204")]
	protected PropertyInfo() { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002217")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x6002208")]
	public abstract PropertyAttributes get_Attributes() { }

	[Token(Token = "0x600220A")]
	public abstract bool get_CanRead() { }

	[Token(Token = "0x600220B")]
	public abstract bool get_CanWrite() { }

	[Address(RVA = "0x13C12F0", Offset = "0x13C04F0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600220C")]
	public override MethodInfo get_GetMethod() { }

	[Address(RVA = "0x13C1310", Offset = "0x13C0510", Length = "0x24")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.StandardUserDataDescriptor", Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002209")]
	public override bool get_IsSpecialName() { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002205")]
	public virtual MemberTypes get_MemberType() { }

	[Token(Token = "0x6002206")]
	public abstract Type get_PropertyType() { }

	[Address(RVA = "0x13C11E0", Offset = "0x13C03E0", Length = "0x16")]
	[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600220D")]
	public override MethodInfo GetGetMethod() { }

	[Token(Token = "0x600220E")]
	public abstract MethodInfo GetGetMethod(bool nonPublic) { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002218")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6002207")]
	public abstract ParameterInfo[] GetIndexParameters() { }

	[Address(RVA = "0x13C1200", Offset = "0x13C0400", Length = "0x16")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600220F")]
	public override MethodInfo GetSetMethod() { }

	[Token(Token = "0x6002210")]
	public abstract MethodInfo GetSetMethod(bool nonPublic) { }

	[Address(RVA = "0x13C1240", Offset = "0x13C0440", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[Token(Token = "0x6002212")]
	public override object GetValue(object obj, Object[] index) { }

	[Token(Token = "0x6002213")]
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[Address(RVA = "0x13C1220", Offset = "0x13C0420", Length = "0x17")]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[Token(Token = "0x6002211")]
	public object GetValue(object obj) { }

	[Address(RVA = "0x13B6D10", Offset = "0x13B5F10", Length = "0x29")]
	[CallerCount(Count = 216)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002219")]
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	[Address(RVA = "0x13B8160", Offset = "0x13B7360", Length = "0x3E")]
	[CallerCount(Count = 129)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600221A")]
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	[Address(RVA = "0x13C1280", Offset = "0x13C0480", Length = "0x25")]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.CreatorPropertyGrid", Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.XmlNodeList", "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.PropertyByRefUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyMember", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002214")]
	public void SetValue(object obj, object value) { }

	[Address(RVA = "0x13C12B0", Offset = "0x13C04B0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002215")]
	public override void SetValue(object obj, object value, Object[] index) { }

	[Token(Token = "0x6002216")]
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

}

